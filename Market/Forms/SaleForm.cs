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
    public partial class SaleForm : Form
    {
        Main mainForm;
        List<UserDB> users;
        public SaleForm(Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            users = DataBase.getAllUsers();
            users.Sort((x, y) => x.firstName.Equals(y.firstName) ?
                        string.Compare(x.lastName, y.lastName) :
                        string.Compare(x.firstName, y.firstName));
            for (int i = 0; i < users.Count; i++)
            {
                userComboBox.Items.Add($"{users[i].ToString()} - бонус: {users[i].bonus}");
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (userComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберете пользователя");
                return;
            }

            int userId = users[userComboBox.SelectedIndex].id;
            int sum = (int)sumBox.Value;
            int bonus = (int)bonusBox.Value;

            int saleId = (int) DataBase.createSale(userId, sum, bonus);

            if (bonus > 0)
            {
                DataBase.changeUserBonus(saleId, userId, -bonus, 4);
            }

            calculateBonuses(saleId, userId, sum);
            MessageBox.Show("Покупка зарегистрирована");
            mainForm.Show();
            Hide();
        }

        private void calculateBonuses(int saleId, int userId, int sum)
        {


            Tree tree = new Tree(DataBase.getAllUsers());

            int sum5 = sum / 20;
            
            // 5% cashback
            DataBase.changeUserBonus(saleId, userId, sum5, 3);

            List<User> parents = tree.getParents(userId);

            for (int i = 2; i < Math.Min(4, parents.Count); i++)
            {
                DataBase.changeUserBonus(saleId, parents[i].id, sum5, 3);
            }

            bool megaPay = false;

            if (parents.Count >= 2)
            {
                if (parents[1].type != 0)
                {
                    DataBase.changeUserBonus(saleId, parents[1].id, sum5, 3, true);
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
                    DataBase.changeUserBonus(saleId, parents[agentId].id, sum5, 3, true);
                    megaPay = true;
                } else
                {
                    if (parents[agentId].type == 2)
                    {
                        DataBase.changeUserBonus(saleId, parents[agentId].id, sum5, 3, true);
                        megaPay = true;
                    }
                }
            }

            if (!megaPay)
            {
                DataBase.changeMegaBonus(saleId, sum5, 3);
            }
        }

        private void sumChanged(object sender, EventArgs e)
        {
            if (userComboBox.SelectedIndex != -1)
            {
                bonusBox.Maximum = Math.Min(users[userComboBox.SelectedIndex].bonus, sumBox.Value);
            }
            else
            {
                bonusBox.Maximum = sumBox.Value;
            }
            bonusBox.Refresh();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Hide();
        }

        private void selectIndexChanged(object sender, EventArgs e)
        {
            if (userComboBox.SelectedIndex != -1)
            {
                bonusBox.Maximum = Math.Min(users[userComboBox.SelectedIndex].bonus, sumBox.Value);
                bonusBox.Refresh();
            }
        }
    }
}
