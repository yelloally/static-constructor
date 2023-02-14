using System;

class DBRepository
{
    private static string connectionString;

    static DBRepository()
    {
        ConfigurationManager configurationManager = new ConfigurationManager();

        connectionString = configurationManager.GetConnectionString();
    }

    public void GetData()
    {
        Console.WriteLine("Using: " + connectionString);
    }

    class ConfigurationManager
    {
        public string GetConnectionString()
        {
            return "local Db";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DBRepository dBRepository = new DBRepository();

            dBRepository.GetData();
        }
    }
}
