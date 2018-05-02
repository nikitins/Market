using Market.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = loginTextBox.Text;
            String password = passwordTextBow.Text;
            bool exists = DataBase.checkAccountPassword(name, password);

            if (exists)
            {
                Account account = DataBase.getAccount(name);
                new Main(account).Show();
                Hide();
            }
            else
            {
                MessageBox.Show(
                   "Имя пользователя или пароль неверные",
                   "Ошибка авторизации");
                   //MessageBoxButtons.OK,
                   //MessageBoxIcon.Information,
                   //MessageBoxDefaultButton.Button1,
                   //MessageBoxOptions.DefaultDesktopOnly);
            }
        }

    }
}
