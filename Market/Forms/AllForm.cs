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
    public partial class AllForm : Form
    {
        private Account account;
        private List<UserDB> allUsers = new List<UserDB>();
        private Tree tree;
        private List<UserDB> currentUsers = new List<UserDB>();
        private User selectedUser = null;

        public AllForm(Account account)
        {
            this.account = account;
            InitializeComponent();

            allUsers = DataBase.getAllUsers();
            allUsers.Sort(new Comparison<UserDB>(UserDB.compareByPhone));

            tree = new Tree(allUsers);

            fillUsersList("");
        }

        private void AllForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void phoneTextChanged(object sender, EventArgs e)
        {
            string text = phoneTextBox.Text;
            if (text.Length > 0 && text[0] == '9')
            {
                text = "8" + text;
            }


            fillUsersList(text);
            if (currentUsers.Count == 1)
            {
                fillSelectedUserData(currentUsers[0].id);
            } else
            {
                clearSelectedUserData();
            }
        }

        private void usersSelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersListBox.SelectedIndex != -1)
            {
                fillSelectedUserData(currentUsers[usersListBox.SelectedIndex].id);
            } else if (currentUsers.Count != 1)
            {
                clearSelectedUserData();
            }
        }

        private void fillSelectedUserData(int id)
        {
            selectedUser = tree.tree[id];
            bonusesLabel.Text = selectedUser.bonus.ToString();
            nameLabel.Text = $"{selectedUser.firstName} {selectedUser.secondName}";

            f1FriendListComboBox.Items.Clear();
            foreach (User child in selectedUser.children)
            {
                f1FriendListComboBox.Items.Add(userToString(child));
            }
            
        }

        private void clearSelectedUserData()
        {
            bonusesLabel.Text = "-";
            AllSpendLabel.Text = "-";
            nameLabel.Text = "-";
            selectedUser = null;
            f1FriendListComboBox.Items.Clear();
            f1FriendListComboBox.Text = "";
        }


        private void fillUsersList(string text)
        {
            usersListBox.Items.Clear();
            currentUsers.Clear();

            foreach (UserDB user in allUsers)
            {
                if (user.phone.StartsWith(text))
                {
                    currentUsers.Add(user);
                    usersListBox.Items.Add(userToString(user));
                }
            }
        }

        private string userToString(UserDB user)
        {
            return userDataToString(user.phone, user.firstName, user.secondName);
        }

        private string userToString(User user)
        {
            return userDataToString(user.phone, user.firstName, user.secondName);
        }

        private string userDataToString(string phone, string firstName, string secondName)
        {
            return $"{phone} - {firstName} {secondName}";
        }
    }
}
