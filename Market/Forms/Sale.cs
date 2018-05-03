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
    public partial class Sale : Form
    {
        Main mainForm;
        List<UserDB> users;
        public Sale(Main mainForm)
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
