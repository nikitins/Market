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
            this.treeView.Nodes.Add(tree);
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
            DataBase.changeUserType(selectedPhone, 1);

            treeView.SelectedNode.NodeFont = new Font(treeView.Font, FontStyle.Bold);
                  TreeNode tree = new Tree(DataBase.getAllUsers()).toTreeNode();
                 treeView.Nodes.Clear();
                treeView.Nodes.Add(tree);
            //treeView.Refresh();
        }
    }
}
