using Market.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Forms
{
    public partial class AllForm : Form
    {
        private Account account;
        private List<UserDB> allUsers = new List<UserDB>();
        private Tree tree;
        private List<UserDB> currentUsers = new List<UserDB>();
        private User selectedUser = null;

        public AllForm(Account account)
        {
            this.account = account;
            InitializeComponent();

            allUsers = DataBase.getAllUsers();
            allUsers.Sort(new Comparison<UserDB>(UserDB.compareByPhone));

            tree = new Tree(allUsers);

            fillUsersList("");
        }

        private void AllForm_Load(object sender, EventArgs e)
        {

        }

        private void phoneTextChanged(object sender, EventArgs e)
        {
            string text = phoneTextBox.Text;
            if (text.Length > 0 && text[0] == '9')
            {
                text = "8" + text;
            }


            fillUsersList(text);
            if (currentUsers.Count == 1)
            {
                fillSelectedUserData(currentUsers[0].id);
            } else
            {
                clearSelectedUserData();
            }
        }

        private void usersSelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersListBox.SelectedIndex != -1)
            {
                fillSelectedUserData(currentUsers[usersListBox.SelectedIndex].id);
            } else if (currentUsers.Count != 1)
            {
                clearSelectedUserData();
            }
        }

        private void fillSelectedUserData(int id)
        {
            selectedUser = tree.tree[id];
            bonusesLabel.Text = selectedUser.bonus.ToString();
            nameLabel.Text = $"{selectedUser.firstName} {selectedUser.secondName}";

            f1FriendListComboBox.Items.Clear();
            foreach (User child in selectedUser.children)
            {
                f1FriendListComboBox.Items.Add(userToString(child));
            }

            bonusBox.Maximum = Math.Min(selectedUser.bonus, sumBox.Value);
            bonusBox.Refresh();

            if (selectedUser.type != 0)
            {
                TABonusLabel.Text = selectedUser.agentBonus.ToString();
                TAbonusSumSpend.Maximum = selectedUser.agentBonus;
                statusLabel.Text = "Торговый агент";
            } else
            {
                statusLabel.Text = "Пользователь";
                TABonusLabel.Text = "-";
            }

            friendSendSumBox.Maximum = selectedUser.bonus;
        }

        private void clearSelectedUserData()
        {
            bonusesLabel.Text = "-";
            AllSpendLabel.Text = "-";
            nameLabel.Text = "-";
            selectedUser = null;
            f1FriendListComboBox.Items.Clear();
            f1FriendListComboBox.Text = "";
            bonusBox.Maximum = 1000000000;
            TABonusLabel.Text = "-";
            TAbonusSumSpend.Maximum = 1000000000;
            friendSendSumBox.Maximum = 1000000000;
            statusLabel.Text = "-";
        }


        private void fillUsersList(string text)
        {
            usersListBox.Items.Clear();
            currentUsers.Clear();

            foreach (UserDB user in allUsers)
            {
                if (user.phone.StartsWith(text))
                {
                    currentUsers.Add(user);
                    usersListBox.Items.Add(userToString(user));
                }
            }
        }

        private string userToString(UserDB user)
        {
            return userDataToString(user.phone, user.firstName, user.secondName);
        }

        private string userToString(User user)
        {
            return userDataToString(user.phone, user.firstName, user.secondName);
        }

        private string userDataToString(string phone, string firstName, string secondName)
        {
            return $"{phone} - {firstName} {secondName}";
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Выберете пользователя");
                return;
            }

            int userId = selectedUser.id;
            int sum = (int)sumBox.Value;
            int bonus = (int)bonusBox.Value;

            int saleId = (int)DataBase.createSale(userId, sum, bonus);

            if (bonus > 0)
            {
                DataBase.changeUserBonus(saleId, userId, -bonus);
            }

            calculateBonuses(saleId, userId, sum);
            MessageBox.Show("Покупка зарегистрирована");
        }

        private void calculateBonuses(int saleId, int userId, int sum)
        {


            Tree tree = new Tree(DataBase.getAllUsers());

            int sum5 = sum / 20;

            // 5% cashback
            DataBase.changeUserBonus(saleId, userId, sum5);

            List<User> parents = tree.getParents(userId);

            for (int i = 2; i < Math.Min(4, parents.Count); i++)
            {
                DataBase.changeUserBonus(saleId, parents[i].id, sum5);
            }

            bool megaPay = false;

            if (parents.Count >= 2)
            {
                if (parents[1].type != 0)
                {
                    DataBase.changeUserBonus(saleId, parents[1].id, sum5, true);
                    megaPay = true;
                }
            }

            int agentId = -1;

            for (int i = 1; i < Math.Min(parents.Count, 9); i++)
            {
                if (parents[i].type != 0)
                {
                    agentId = i;
                }
            }

            if (agentId > 3)
            {
                if (agentId <= 5)
                {
                    DataBase.changeUserBonus(saleId, parents[agentId].id, sum5, true);
                    megaPay = true;
                }
                else
                {
                    if (parents[agentId].type == 2)
                    {
                        DataBase.changeUserBonus(saleId, parents[agentId].id, sum5, true);
                        megaPay = true;
                    }
                }
            }

            if (!megaPay)
            {
                DataBase.changeMegaBonus(saleId, sum5);
            }
        }

        private void sumChanged(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                bonusBox.Maximum = Math.Min(selectedUser.bonus, sumBox.Value);
            }
            else
            {
                bonusBox.Maximum = sumBox.Value;
            }
            bonusBox.Refresh();
        }

        private void spendTAButton_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Выберете пользователя");
                return;
            }

            if(selectedUser.type == 0)
            {
                MessageBox.Show("Пользователь не является агентом");
                return;
            }

            DataBase.changeUserBonus(-2, selectedUser.id, (int) -TAbonusSumSpend.Value, true);

        }

        private void friendSendButton_Click(object sender, EventArgs e)
        {
            int id = f1FriendListComboBox.SelectedIndex;

            if (id == -1)
            {
                MessageBox.Show("Выберите друга");
                return;
            }

            int friendId = tree.tree[selectedUser.id].children[id].id;
            
            DataBase.changeUserBonus(-2, selectedUser.id, (int) -friendSendSumBox.Value, friendSendCheckBox.Checked);
            DataBase.changeUserBonus(-2, friendId, (int) friendSendSumBox.Value, friendSendCheckBox.Checked);
        }
    }
}
