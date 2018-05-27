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
    public partial class Register : Form
    {
        Form mainForm;
        AllForm allForm;
        List<UserDB> users;

        public Register(Main mainForm)
        {
            this.mainForm = mainForm;
            init();
        }

        public Register(AllForm allForm)
        {
            this.allForm = allForm;
            init();
        }

        private void init()
        {
            InitializeComponent();
            users = new List<UserDB>();
            foreach (UserDB user in DataBase.getAllUsers())
            {
                if (user.id != 1)
                {
                    users.Add(user);
                }
            }
            users.Sort((x, y) => x.firstName.Equals(y.firstName) ?
                        string.Compare(x.lastName, y.lastName) :
                        string.Compare(x.firstName, y.firstName));
            for (int i = 0; i < users.Count; i++)
            {
                inviterTextBox.Items.Add(users[i].ToString());
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            allForm.Show();
            Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = "";
            string secondName = seconNameTextBox.Text;
            string phone = phoneTextBox.Text;

            if (firstName.Length == 0)
            {
                MessageBox.Show("Имя не может быть пустым");
                return;
            }

            if (secondName.Length == 0)
            {
                MessageBox.Show("Отчество не может быть пустым");
                return;
            }

            if (phone.Length == 0)
            {
                MessageBox.Show("Номер телефона не может быть пустой");
                return;
            }

            if (phone.Length != 11 || !phone.StartsWith("89"))
            {
                MessageBox.Show("Номер телефона должен быть указан в формате '89123456789'");
                return;
            }

            if (DataBase.getUserCountByPhone(phone) > 0)
            {
                MessageBox.Show("Пользователь с таким телефоном уже существует");
                return;
            }

            int parantId = 2;
            if (inviterTextBox.SelectedIndex != -1)
            {
                parantId = users[inviterTextBox.SelectedIndex].id;
            }

            DataBase.createUser(firstName, lastName, secondName, phone, parantId, 0, 0, 0);
            UserDB user = new UserDB(-1, firstName, lastName, secondName, phone, parantId, 0, 0, 0);

            MessageBox.Show($"Пользователь {user.ToString()} успешно зарегистрирован");
            allForm.updateUsersInfoFromDB();
            allForm.Show();
            Hide();
        }
    }
}
