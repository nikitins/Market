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
            String name = this.loginTextBox.Text;
            String password = this.passwordTextBow.Text;
            bool exists = DataBase.checkUserExists(name, password);

            if (exists)
            {
                new Main(DataBase.checkIsRoot(name)).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                   "Имя пользователя или пароль неверные",
                   "Ошибка авторизации",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
            }
        }

    }
}
