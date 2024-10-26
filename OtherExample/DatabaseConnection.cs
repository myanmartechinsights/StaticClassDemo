

namespace DatabaseConnectionExample
{
    /// <summary>
    /// Singleton pattern
    /// </summary>
    public class DatabaseConnection
    {
        private static DatabaseConnection instance = null;

        private DatabaseConnection() { }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }

        public void Connect()
        {
            Console.WriteLine("Database connected.");
        }
    }

}
