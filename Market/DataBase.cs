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

        static SQLiteConnection getConnection()
        {
            return new SQLiteConnection($"Data Source={DATABASE_NAME}; Version=3;");
        }

        static DataBase()
        {
            runEmpty($"CREATE TABLE IF NOT EXISTS {ACCOUNTS_TABLE_NAME}"
                   + " (id INTEGER PRIMARY KEY AUTOINCREMENT, "
                   + "name TEXT NOT NULL, "
                   + "password_hash TEXT NOT NULL, "
                   + "isRoot BOOLEAN NOT NULL);");

            runEmpty($"CREATE TABLE IF NOT EXISTS {ACCOUNTS_TABLE_NAME}"
                   + " (id INTEGER PRIMARY KEY AUTOINCREMENT, "
                   + "firstName TEXT NOT NULL, "
                   + "lastName TEXT NOT NULL, "
                   + "secondName TEXT, "
                   + "phone TEXT NOT NULL, "
                   + "parentId INTEGER NOT NULL, "
                   + "bonus INTEGER NOT NULL, "
                   + "isAgent BOOLEAN NOT NULL);");



            if (runScalar($"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='root';") == 0)
            {
                runEmpty($"INSERT INTO {ACCOUNTS_TABLE_NAME} (name, password_hash, isRoot) VALUES('root', '{getHash("root1234")}', 1);");
            }
            if (runScalar($"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='admin';") == 0)
            {
                runEmpty($"INSERT INTO {ACCOUNTS_TABLE_NAME} (name, password_hash, isRoot) VALUES('admin', '{getHash("admin1234")}', 0);");
            }
            if (runScalar($"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='1';") == 0)
            {
                runEmpty($"INSERT INTO {ACCOUNTS_TABLE_NAME} (name, password_hash, isRoot) VALUES('1', '{getHash("1")}', 1);");
            }
            if (runScalar($"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='2';") == 0)
            {
                runEmpty($"INSERT INTO {ACCOUNTS_TABLE_NAME} (name, password_hash, isRoot) VALUES('2', '{getHash("2")}', 0);");
            }
        }

       public static bool checkUserExists(String userName, String password)
        {
            String text = $"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='{userName}' AND password_hash='{getHash(password)}';";
            long count = runScalar(text);
            return count > 0;
        }

        public static bool checkIsRoot(String userName)
        {
            String text = $"SELECT isRoot from {ACCOUNTS_TABLE_NAME} WHERE name='{userName}';";
            using (SQLiteConnection conn = getConnection())
            {
                conn.Open();
                SQLiteCommand cmd = createComand(text, conn);
                try
                {
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return reader.GetBoolean(0);
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return false;
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
        
        private static SQLiteDataReader runReader(String text)
        {
            using (SQLiteConnection conn = getConnection())
            {
                conn.Open();
                SQLiteCommand cmd = createComand(text, conn);
                try
                {
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
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
