using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor_2
{
    class DbRepository
    {
        private static string connectionString="Local DB";

        static DbRepository()
        {
            ConfigManager configManager = new ConfigManager();

            connectionString = configManager.GetConnString();
        }

        public void GetData()
        {
            Console.WriteLine("Using: " + connectionString);
        }
    }

    class ConfigManager
    {
        public string GetConnString()
        {
            return "Local DB";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DbRepository dbRepository = new DbRepository();

            dbRepository.GetData();
        }
    }
}
