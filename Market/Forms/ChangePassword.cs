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
    public partial class ChangePassword : Form
    {
        public Main mainForm;
        public ChangePassword(Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPasswordTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            string repatPassword = repeatPasswordTextBox.Text;

            if (!DataBase.checkAccountPassword(mainForm.account.name, oldPassword))
            {
                MessageBox.Show("Некорректный старый пароль");
                return;
            }

            if (!newPassword.Equals(repatPassword))
            {
                MessageBox.Show("Поля 'Новый пароль' и 'Повтор нового пароля' не совпадают");
                return;
            }

            DataBase.changeAccountPassword(mainForm.account.name, oldPassword, newPassword);

            MessageBox.Show("Пароль успешно изменен");
            mainForm.Show();
            Hide();
        }
    }
}
