using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Backup
    {
        static String folder = $"C:\\marketBackups\\";
    
        public static void backup()
        {
            try
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                String date = DateTime.Now.ToString().Replace(' ', '_').Replace('.', '_').Replace(':', '-');
                String fileName = $"backup_{date}.db";
                string path = folder + fileName;
                File.Copy("filename.db", path, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
