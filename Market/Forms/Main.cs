using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Main : Form
    {
        public Main(bool isRoot)
        {
            this.isRoot = isRoot;
            InitializeComponent();
        }


        private void logout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void history_Click(object sender, EventArgs e)
        {

        }

        private bool isRoot = false;

        private void registration_Click(object sender, EventArgs e)
        {
            new Forms.Register(this).Show();
            Hide();
        }
    }
}
