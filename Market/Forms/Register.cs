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
        List<UserDB> users;

        public Register(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            users = DataBase.getAllUsers();
            for (int i = 0; i < users.Count; i++) {
                inviterTextBox.Items.Add(users[i].phone + " - " + users[i].firstName + " " + users[i].lastName);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string secondName = seconNameTextBox.Text;
            string phone = phoneTextBox.Text;

            if (firstName.Length == 0)
            {
                MessageBox.Show("Имя не может быть пустым");
                return;
            }

            if (lastName.Length == 0)
            {
                MessageBox.Show("Фамилия не может быть пустой");
                return;
            }


            if (phone.Length == 0)
            {
                MessageBox.Show("Номер телефона не может быть пустой");
                return;
            }

    //        if (phone.Length != 11 || !phone.StartsWith("89"))
    //        {
    //            MessageBox.Show("Номер телефона должен быть указан в формате '89123456789'");
    //            return;
    //        }

            if (DataBase.getUserCountByPhone(phone) > 0)
            {
                MessageBox.Show("Пользователь с таким телефоном уже существует");
                return;
            }

            int parantId = 0;
            if (inviterTextBox.SelectedIndex != -1)
            {
                parantId = users[inviterTextBox.SelectedIndex].id;
            }

            DataBase.createUser(firstName, lastName, secondName, phone, parantId, 0, 0);

            MessageBox.Show($"Пользователь {phone} - {firstName} {lastName} зарегистрирован");
            mainForm.Show();
            Hide();
        }
    }
}
