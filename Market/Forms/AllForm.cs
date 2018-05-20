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
        private List<Control> adminElements = new List<Control>();
        
        public AllForm(Account account)
        {
            this.account = account;
            InitializeComponent();

            adminElements.Add(label10);
            adminElements.Add(TABonusLabel);
            adminElements.Add(TAbonusSumSpend);
            adminElements.Add(spendTAButton);
            adminElements.Add(label12);
            adminElements.Add(label3);
            adminElements.Add(makeSTAbutton);
            adminElements.Add(makeUserbutton);
            adminElements.Add(makeTAbutton);

            allUsers = DataBase.getAllUsers();
            allUsers.Sort(new Comparison<UserDB>(UserDB.compareByPhone));

            tree = new Tree(allUsers);

            fillUsersList("");
            setMegaBonusData();
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
                statusLabel.Text = selectedUser.type == 2 ? "Старший торговый агент" : "Торговый агент";
            } else
            {
                statusLabel.Text = "Пользователь";
                TABonusLabel.Text = "-";
            }

            friendSendSumBox.Maximum = selectedUser.bonus;
            AllSpendLabel.Text = DataBase.getAllSalesByUserId(id).ToString();

            setMegaBonusData();
        }

        private void setMegaBonusData()
        {
            int megaBonus = DataBase.getMegaBonus();
            MegaBonusLabel.Text = megaBonus.ToString();
            SpendedMegaBonusLabel.Text = DataBase.getSpendedMegaBonus().ToString();
            spendMegaBonusSum.Maximum = megaBonus;
            sentMegaSum.Maximum = megaBonus;
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
            AllSpendLabel.Text = "-";
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

        private void updateUsersInfoFromDB()
        {
            allUsers = DataBase.getAllUsers();
            allUsers.Sort(new Comparison<UserDB>(UserDB.compareByPhone));

            tree = new Tree(allUsers);

            for (int i = 0; i < currentUsers.Count; i++)
            {
                foreach (UserDB user in allUsers)
                {
                    if (currentUsers[i].id == user.id)
                    {
                        currentUsers[i] = user;
                        break;
                    }
                }
                
            }

            if (selectedUser != null)
            {
                selectedUser = tree.tree[selectedUser.id];
                fillSelectedUserData(selectedUser.id);
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

            calculateBonuses(saleId, userId, sum - bonus);
            updateUsersInfoFromDB();
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
            updateUsersInfoFromDB();

        }

        private void friendSendButton_Click(object sender, EventArgs e)
        {
            int id = f1FriendListComboBox.SelectedIndex;

            if (id == -1)
            {
                MessageBox.Show("Выберите друга");
                return;
            }

            User friend = tree.tree[selectedUser.id].children[id];

            if (friendSendCheckBox.Checked)
            {
                if(selectedUser.type == 0)
                {
                    MessageBox.Show("Пользователь не является агентом");
                    return;
                }

                if (friend.type == 0)
                {
                    MessageBox.Show("Друг пользователя не является агентом");
                    return;
                }

                if (selectedUser.agentBonus < friendSendSumBox.Value)
                {
                    MessageBox.Show("У пользоветеля недостаточно ТА бонусов");
                    return;
                }
            }
            else
            {
                if (selectedUser.bonus < friendSendSumBox.Value)
                {
                    MessageBox.Show("У пользоветеля недостаточно бонусов");
                    return;
                }
            }


            DataBase.changeUserBonus(-2, selectedUser.id, (int) -friendSendSumBox.Value, friendSendCheckBox.Checked);
            DataBase.changeUserBonus(-2, friend.id, (int) friendSendSumBox.Value, friendSendCheckBox.Checked);
            updateUsersInfoFromDB();
            f1FriendListComboBox.SelectedIndex = id;
        }

        private void changeSelectedUserType(int type)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Выберете пользователя");
            }
            else
            {
                DataBase.changeUserType(selectedUser.id, type);
                updateUsersInfoFromDB();
            }
        }

        private void makeUserbutton_Click(object sender, EventArgs e)
        {
            changeSelectedUserType(0);
        }

        private void makeTAbutton_Click(object sender, EventArgs e)
        {
            changeSelectedUserType(1);
        }

        private void makeSTAbutton_Click(object sender, EventArgs e)
        {
            changeSelectedUserType(2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            new Register(this).Show();
            Hide();
        }

        private void userModeButton_Click(object sender, EventArgs e)
        {
           foreach(Control c in adminElements)
           {
                c.Hide();
           }
        }

        private void adminModeButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in adminElements)
            {
                c.Show();
            }
        }

        private void spendMegaBonusButton_Click(object sender, EventArgs e)
        {
            int megaBonus = (int) spendMegaBonusSum.Value;

            if (megaBonus <= 0)
            {
                MessageBox.Show("Сумма списания должна быть больше 0");
                return;
            }

            DataBase.changeMegaBonus(-1, -megaBonus);

            MessageBox.Show($"Списано: {megaBonus}");
            setMegaBonusData();
        }

        private void sentMegaToUserButton_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Выберите пользователя");
                return;
            }

            if (megaBonusTACheckBox.Checked)
            {
                if (selectedUser.type == 0)
                {
                    MessageBox.Show("Пользователь не является агентом");
                    return;
                }
            }

            int sum = (int) sentMegaSum.Value;

            if (sum <= 0)
            {
                MessageBox.Show("Сумма перевода должна быть больше 0");
                return;
            }

            DataBase.changeMegaBonus(-2, -sum);
            DataBase.changeUserBonus(-2, selectedUser.id, sum, megaBonusTACheckBox.Checked);

            updateUsersInfoFromDB();
        }
    }
}
