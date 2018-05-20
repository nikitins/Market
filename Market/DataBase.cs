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
        private const string BONUS_MOVE_TABLE_NAME = "bonus_move"; 
        private const string MEGA_BONUS_TABLE_NAME = "mega_bonus"; 

        static SQLiteConnection getConnection()
        {
            return new SQLiteConnection($"Data Source={DATABASE_NAME}; Version=3;");
        }

        static DataBase()
        {

            runEmpty($"CREATE TABLE IF NOT EXISTS {MEGA_BONUS_TABLE_NAME} "
                   + "(id INTEGER PRIMARY KEY AUTOINCREMENT, "
                   + "sum int NOT NULL);");

            //runEmpty($"DROP TABLE IF EXISTS {ACCOUNTS_TABLE_NAME};");

            runEmpty($"CREATE TABLE IF NOT EXISTS {ACCOUNTS_TABLE_NAME} "
                   + "(id INTEGER PRIMARY KEY AUTOINCREMENT, "
                   + "name TEXT NOT NULL, "
                   + "password_hash TEXT NOT NULL, "
                   + "type INT NOT NULL);");

            //runEmpty($"DROP TABLE IF EXISTS {USERS_TABLE_NAME};");

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

           // runEmpty($"DROP TABLE IF EXISTS {BONUS_MOVE_TABLE_NAME};");
            runEmpty($"CREATE TABLE IF NOT EXISTS {BONUS_MOVE_TABLE_NAME} " +
                      "(id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                      "sale_id INTEGER, " +
                      "user_id INTEGER, " +
                      "sum INT NOT NULL, " +
                      "type INT NOT NULL, " +
                      $"FOREIGN KEY (user_id) REFERENCES {USERS_TABLE_NAME}(id), " +
                      $"FOREIGN KEY (sale_id) REFERENCES {SALES_TABLE_NAME} (id));");

            if (getUserCountByPhone("89271169536") == 0)
            {
                createUser("Вася", "Пупкин", "Валерьевич", "89271169536", -1, 1000, 1000, 2);
            }
            if (getUserCountByPhone("89374368945") == 0)
            {
                createUser("Маша", "Старожилова", "Иванова", "89374368945", 1, 1000, 1000, 0);
            }

            runEmpty($"UPDATE {USERS_TABLE_NAME} SET bonus=1000, agentBonus=1000;");

            if (runScalar($"SELECT count(*) from {MEGA_BONUS_TABLE_NAME};") == 0)
            {
                runEmpty($"INSERT INTO {MEGA_BONUS_TABLE_NAME} (sum) VALUES(0);");
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

        public static void changeUserBonus(int sale_id, int userId, int bonusDelta, bool agent = false)
        {
            int current = getUserBonus(userId, agent);
            setUserBonus(userId, current + bonusDelta, agent);
            createBonusMove(sale_id, userId, bonusDelta, agent);
        }

        public static void changeMegaBonus(int saleId, int bonusDelta)
        {
            int current = getMegaBonus();
            setMegaBonus(current + bonusDelta);
            createBonusMove(saleId, -1, bonusDelta, true);
        }

        public static void setUserBonus(int userId, int bonus, bool agent = false)
        {
            string bonusField = agent ? "agentBonus" : "bonus";
            runEmpty($"UPDATE {USERS_TABLE_NAME} SET {bonusField}={bonus} WHERE id={userId};");
        }

        public static void setMegaBonus(int bonus)
        {
            runEmpty($"UPDATE {MEGA_BONUS_TABLE_NAME} SET sum={bonus} WHERE id=1;");
        }

        public static int getUserBonus(int userId, bool agent = false)
        {
            string bonusField = agent ? "agentBonus" : "bonus";
            String text = $"SELECT {bonusField} FROM {USERS_TABLE_NAME} WHERE id={userId};";
            return runOneIntField(text);
        }

        public static int getMegaBonus()
        {
            String text = $"SELECT sum FROM {MEGA_BONUS_TABLE_NAME} WHERE id=1;";
            return runOneIntField(text);
        }
        
        public static int getSpendedMegaBonus()
        {
            String text = $"SELECT SUM(sum) FROM {BONUS_MOVE_TABLE_NAME} WHERE user_id=-1 AND sum < 0;";
            return runOneIntField(text) * -1;
        }

        public static void changeUserType(String phone, int type)
        {
            runEmpty($"UPDATE {USERS_TABLE_NAME} SET type='{type}' WHERE phone='{phone}';");
        }

        public static void changeUserType(int id, int type)
        {
            runEmpty($"UPDATE {USERS_TABLE_NAME} SET type='{type}' WHERE id='{id}';");
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

        public static List<Sale> getAllSales()
        {
            List<Sale> sales = new List<Sale>();
            String text = $"SELECT {SALES_TABLE_NAME}.id, {SALES_TABLE_NAME}.sum, {SALES_TABLE_NAME}.payed_bonus, {USERS_TABLE_NAME}.firstName, {USERS_TABLE_NAME}.lastName, " +
                $"{USERS_TABLE_NAME}.phone, {SALES_TABLE_NAME}.date from {SALES_TABLE_NAME} JOIN {USERS_TABLE_NAME} " +
                $"ON {SALES_TABLE_NAME}.user_id={USERS_TABLE_NAME}.id;";
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
                                Sale sale = new Sale(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4),
                                    reader.GetString(5), reader.GetDateTime(6));
                                sales.Add(sale);
                            }
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return sales;
        }

        public static int getAllSalesByUserId(int userId)
        {
            String text = $"SELECT SUM(sum) - SUM(payed_bonus) FROM {SALES_TABLE_NAME} WHERE user_id={userId};";
            return runOneIntField(text);
        }

        public static List<BonusMove> getBonusMoveBySaleId(int saleId)
        {
            List<BonusMove> bonusMoves = new List<BonusMove>();
            String text = $"SELECT {BONUS_MOVE_TABLE_NAME}.id, {BONUS_MOVE_TABLE_NAME}.sum, {BONUS_MOVE_TABLE_NAME}.type, {USERS_TABLE_NAME}.firstName, {USERS_TABLE_NAME}.lastName, " +
                $"{USERS_TABLE_NAME}.phone from {BONUS_MOVE_TABLE_NAME} LEFT JOIN {USERS_TABLE_NAME} " +
                $"ON {BONUS_MOVE_TABLE_NAME}.user_id={USERS_TABLE_NAME}.id WHERE {BONUS_MOVE_TABLE_NAME}.sale_id={saleId};";
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
                                string firstName = reader.IsDBNull(3) ? null : reader.GetString(3);
                                string lastName = reader.IsDBNull(4) ? null : reader.GetString(4);
                                string phone = reader.IsDBNull(5) ? null : reader.GetString(5);
                                BonusMove bonusMove = new BonusMove(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), firstName, lastName, phone);
                                bonusMoves.Add(bonusMove);
                            }
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return bonusMoves;
        }

        public static void createUser(string firstName, string lastName, string secondName, string phone, int parentId, int bonus, int agentBonus, int type)
        {
            runEmpty($"INSERT INTO {USERS_TABLE_NAME} (firstName, lastName, secondName, phone, parentId, bonus, agentBonus, type) " +
                $"VALUES ('{firstName}', '{lastName}', '{secondName}', '{phone}', {parentId}, {bonus}, {agentBonus}, {type});");
        }

        public static void createBonusMove(int sale_id, int user_id, int sum, bool agent = false)
        {
            int type = agent ? 1 : 0;
            runEmpty($"INSERT INTO {BONUS_MOVE_TABLE_NAME} (sale_id, user_id, sum, type) " +
                $"VALUES ({sale_id}, {user_id}, {sum}, {type});");
        }

        public static long createSale(int user_id, int sum, int bonus)
        {
            runEmpty($"INSERT INTO {SALES_TABLE_NAME} (user_id, sum, payed_bonus, date) " +
                $"VALUES ({user_id}, {sum}, {bonus}, CURRENT_TIMESTAMP);");

            string text = $"SELECT id FROM {SALES_TABLE_NAME} ORDER BY id DESC;";
            return runOneIntField(text);
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

        private static int runOneIntField(string text)
        {
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
                                if (reader.IsDBNull(0))
                                {
                                    return 0;
                                }
                                else
                                {
                                    return reader.GetInt32(0);
                                }
                            }
                        }
                    }
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
