using Market.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class DataBase
    {
        private const string DATABASE_NAME = "filename.db";
        private const string ACCOUNTS_TABLE_NAME = "accounts"; 
        private const string USERS_TABLE_NAME = "users"; 
        private const string SALES_TABLE_NAME = "sales"; 

        static SQLiteConnection getConnection()
        {
            return new SQLiteConnection($"Data Source={DATABASE_NAME}; Version=3;");
        }

        static DataBase()
        {
            runEmpty($"DROP TABLE IF EXISTS {ACCOUNTS_TABLE_NAME};");

            runEmpty($"CREATE TABLE IF NOT EXISTS {ACCOUNTS_TABLE_NAME} "
                   + "(id INTEGER PRIMARY KEY AUTOINCREMENT, "
                   + "name TEXT NOT NULL, "
                   + "password_hash TEXT NOT NULL, "
                   + "type INT NOT NULL);");

            runEmpty($"DROP TABLE IF EXISTS {USERS_TABLE_NAME};");

            runEmpty($"CREATE TABLE IF NOT EXISTS {USERS_TABLE_NAME} "
                   + "(id INTEGER PRIMARY KEY AUTOINCREMENT, "
                   + "firstName TEXT NOT NULL, "
                   + "lastName TEXT NOT NULL, "
                   + "secondName TEXT, "
                   + "phone TEXT NOT NULL, "
                   + "parentId INTEGER NOT NULL, "
                   + "bonus INTEGER NOT NULL, "
                   + "agentBonus INTEGER NOT NULL, "
                   + "type INTEGER NOT NULL);"); //0 - user, 1 - agent

            runEmpty($"CREATE TABLE IF NOT EXISTS {SALES_TABLE_NAME} " +
                      "(id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                      "user_id INTEGER, " +
                      "sum INT NOT NULL, " +
                      "payed_bonus INT NOT NULL, " +
                      "date DATETIME NOT NULL, " +
                      $"FOREIGN KEY (user_id) REFERENCES {USERS_TABLE_NAME}(id));");

            if (getUserCountByPhone("123") == 0)
            {
                createUser("Вася", "Пупкин", "Валерьевич", "89271169536", -1, 0, 0, 0);
            }
            if (getUserCountByPhone("456") == 0)
            {
                createUser("Маша", "Старожилова", "Иванова", "89374368945", 1, 0, 0, 0);
            }


            if (runScalar($"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='root';") == 0)
            {
                runEmpty($"INSERT INTO {ACCOUNTS_TABLE_NAME} (name, password_hash, type) VALUES('root', '{getHash("root1234")}', 1);");
            }
            if (runScalar($"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='admin';") == 0)
            {
                runEmpty($"INSERT INTO {ACCOUNTS_TABLE_NAME} (name, password_hash, type) VALUES('admin', '{getHash("admin1234")}', 0);");
            }
            if (runScalar($"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='1';") == 0)
            {
                runEmpty($"INSERT INTO {ACCOUNTS_TABLE_NAME} (name, password_hash, type) VALUES('1', '{getHash("1")}', 1);");
            }
            if (runScalar($"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='2';") == 0)
            {
                runEmpty($"INSERT INTO {ACCOUNTS_TABLE_NAME} (name, password_hash, type) VALUES('2', '{getHash("2")}', 0);");
            }
        }

       public static bool checkAccountPassword(String userName, String password)
        {
            String text = $"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='{userName}' AND password_hash='{getHash(password)}';";
            long count = runScalar(text);
            return count > 0;
        }

        public static void changeAccountPassword(String name, String oldPassword, String newPassword)
        {
            runEmpty($"UPDATE {ACCOUNTS_TABLE_NAME} SET password_hash='{getHash(newPassword)}' WHERE name='{name}' AND password_hash='{getHash(oldPassword)}';");
        }

        public static void changeUserType(String phone, int type)
        {
            runEmpty($"UPDATE {USERS_TABLE_NAME} SET type='{type}' WHERE phone='{phone}';");
        }

        public static Account getAccount(String userName)
        {
            String text = $"SELECT id, name, type from {ACCOUNTS_TABLE_NAME} WHERE name='{userName}';";
            using (SQLiteConnection conn = getConnection())
            {
                conn.Open();
                SQLiteCommand cmd = createComand(text, conn);
                try
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                return new Account(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                            }
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
        }

        public static UserDB getUserByPhone(string phone)
        {
            String text = $"SELECT id, firstName, lastName, secondName, phone, parentId, bonus, agentBonus, type from {USERS_TABLE_NAME} WHERE phone='{phone}';";
            using (SQLiteConnection conn = getConnection())
            {
                conn.Open();
                SQLiteCommand cmd = createComand(text, conn);
                try
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserDB user = new UserDB(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                                    reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8));
                                return user;
                            }
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
        }

        public static List<UserDB> getAllUsers()
        {
            List<UserDB> users = new List<UserDB>();
            String text = $"SELECT id, firstName, lastName, secondName, phone, parentId, bonus, agentBonus, type from {USERS_TABLE_NAME};";
            using (SQLiteConnection conn = getConnection())
            {
                conn.Open();
                SQLiteCommand cmd = createComand(text, conn);
                try
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserDB user = new UserDB(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                                    reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8));
                                users.Add(user);
                            }
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return users;
        } 

        public static void createUser(string firstName, string lastName, string secondName, string phone, int parentId, int bonus, int agentBonus, int type)
        {
            runEmpty($"INSERT INTO {USERS_TABLE_NAME} (firstName, lastName, secondName, phone, parentId, bonus, agentBonus, type) " +
                $"VALUES ('{firstName}', '{lastName}', '{secondName}', '{phone}', {parentId}, {bonus}, {agentBonus}, {type});");
        }

        public static long getUserCountByPhone(string phone)
        {
            return runScalar($"SELECT COUNT(*) FROM {USERS_TABLE_NAME} WHERE phone='{phone}';");
        }

        private static void runEmpty(String text)
        {
            using (SQLiteConnection conn = getConnection())
            {
                conn.Open();
                SQLiteCommand cmd = createComand(text, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        private static long runScalar(String text)
        {
            using (SQLiteConnection conn = getConnection())
            {
                conn.Open();
                SQLiteCommand cmd = createComand(text, conn);
                try
                {
                    long ans = (long) cmd.ExecuteScalar();
                    return ans;
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return -1;
        }

        private static SQLiteCommand createComand(String text, SQLiteConnection conn)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = text;
            return cmd;
        }

        private static String getHash(String s)
        {
            return s.GetHashCode().ToString();
        }
    }
}
