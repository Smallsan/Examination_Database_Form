using MySql.Data.MySqlClient;
using System;

namespace ExaminationApplication
{
    public class DatabaseHandler
    {
        public static MySqlConnection connection = new MySqlConnection("Server=localhost;Database=examination;Uid=root;Pwd='';");

        public static void connect_database()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection Established");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void disconnect_database()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
