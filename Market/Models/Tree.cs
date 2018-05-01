using System.Collections.Generic;

namespace Market.Models
{
    class Tree
    {
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
            }

            tree.Add(user.id, user);
            return user;
        }

    }
}
