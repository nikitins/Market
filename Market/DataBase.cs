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
        static SQLiteConnection getConnection()
        {
            return new SQLiteConnection("Data Source=filename.db; Version=3;");
        }

        static DataBase()
        {
            using (SQLiteConnection conn = getConnection())
            {
                runEmpty("CREATE TABLE IF NOT EXISTS accounts("
             + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
             + "name TEXT NOT NULL, "
             + "password_hash TEXT NOT NULL, "
             + "isRoot BOOLEAN NOT NULL;");
            }

            //DataSet data = new System.Data.DataSet();
            //data.Reset();
            //SQLiteDataAdapter ad = new SQLiteDataAdapter(createComand("SELECT * from accounts WHERE name='root';"));
            //ad.Fill(data);

        }

       public static bool checkUserExists(String userName, String password)
        {

            return true;

        }

        private static void runEmpty(String text)
        {
            using (SQLiteConnection conn = getConnection())
            {
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

        private static SQLiteCommand createComand(String text, SQLiteConnection conn)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = text;
            return cmd;
        }
    }
}
