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
        public Register(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            mainForm.Show();
            Hide();
        }
    }
}
