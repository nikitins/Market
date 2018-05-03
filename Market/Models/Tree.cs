using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Market.Models
{
    class Tree
    {
        User root;
        Dictionary<int, User> tree = new Dictionary<int, User>();

        public Tree(List<UserDB> users)
        {
            Dictionary<int, UserDB> usersMap = new Dictionary<int, UserDB>();
            foreach (UserDB user in users)
            {
                usersMap[user.id] = user;
            }

            foreach (UserDB user in users) {
                addUser(user, usersMap);
            }
        }

        public TreeNode toTreeNode()
        {
            return toTreeNode(root);
        }

        private TreeNode toTreeNode(User user)
        {
            TreeNode[] children = new TreeNode[user.children.Count];

            for (int i = 0; i < user.children.Count; i++)
            {
                children[i] = toTreeNode(user.children[i]);
            }

            string title = $"{user.ToString()} - бонус: {user.bonus}";
            if(user.type != 0)
            {
                title += $", бонус ТА: {user.agentBonus}";
            }
            TreeNode node = new TreeNode(title, children);
            if (user.type == 1)
            {
                node.NodeFont = new Font(new TreeView().Font, FontStyle.Bold);
            }
            return node;
        }

        private User addUser(UserDB userDB, Dictionary<int, UserDB> users)
        {
            if (tree.ContainsKey(userDB.id))
            {
                return tree[userDB.id];
            }

            User parent = null;
            if (users.ContainsKey(userDB.parentId))
            {
                parent = addUser(users[userDB.parentId], users);
            }

            User user = new User(userDB, parent);
            if(parent != null)
            {
                parent.addChild(user);
            } else
            {
                root = user;
            }

            tree.Add(user.id, user);
            return user;
        }

    }
}
