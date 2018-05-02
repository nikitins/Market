﻿using Market.Models;
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
        public Account account = null;

        public Main(Account account)
        {
            this.account = account;
            InitializeComponent();
            if(!account.isRoot)
            {
                common.Hide();
                properties.Hide();
            }
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

        private void changePassword_Click(object sender, EventArgs e)
        {
            new Forms.ChangePassword(this).Show();
            Hide();
        }

        private void userListButton_Click(object sender, EventArgs e)
        {
            new Forms.UserList(this).Show();
            Hide();
        }

        private void common_Click(object sender, EventArgs e)
        {

        }

        private void addAgent_Click(object sender, EventArgs e)
        {

        }

        private void properties_Click(object sender, EventArgs e)
        {

        }

        private void sale_Click(object sender, EventArgs e)
        {

        }
    }
}
