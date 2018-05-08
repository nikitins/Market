using Market.Models;
using System.Drawing;
using System.Windows.Forms;

namespace Market.Forms
{
    public partial class UserList : Form
    {
        Main mainForm;
        public UserList(Main mainForm) 
        {
            this.mainForm = mainForm;
            InitializeComponent();

            TreeNode tree = new Tree(DataBase.getAllUsers()).toTreeNode();
            treeView.Nodes.Add(tree);
        }

        private void cancel_Click(object sender, System.EventArgs e)
        {
            mainForm.Show();
            Hide();
        }

        private void makeAgent_Click(object sender, System.EventArgs e)
        {
            if (treeView.SelectedNode == null)
            {
                MessageBox.Show("Выберете пользователя");
                return;
            }

            string selectedPhone = treeView.SelectedNode.Text.Replace("-", "").Split(new char[]{' '})[3];
            UserDB user = DataBase.getUserByPhone(selectedPhone);
            if (user.type != 0)
            {
                MessageBox.Show("Пользователь уже является агентом");
                return;
            }

            DataBase.changeUserType(selectedPhone, 1);

            treeView.SelectedNode.NodeFont = new Font(treeView.Font, FontStyle.Bold);

            // resize node pixel size after making bold
            treeView.SelectedNode.Text = $"{treeView.SelectedNode.Text.TrimEnd()}, бонус ТА: {user.agentBonus}";
        }
    }
}
