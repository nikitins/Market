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

            if (runScalar($"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='root';") == 0)
            {
                runEmpty($"INSERT INTO {ACCOUNTS_TABLE_NAME} (name, password_hash, isRoot) VALUES('root', '{getHash("root1234")}', 1);");
            }
            if (runScalar($"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='admin';") == 0)
            {
                runEmpty($"INSERT INTO {ACCOUNTS_TABLE_NAME} (name, password_hash, isRoot) VALUES('admin', '{getHash("admin1234")}', 0);");
            }
        }

       public static bool checkUserExists(String userName, String password)
        {
            String text = $"SELECT count(*) from {ACCOUNTS_TABLE_NAME} WHERE name='{userName}' AND password_hash='{getHash(password)}';";
            long count = runScalar(text);
            return count > 0;
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
