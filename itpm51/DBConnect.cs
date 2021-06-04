using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TimeTableM
{
    class DBConnect
    {
        public static MySqlConnection ConnectDB()
        {
            try
            {
                string server = "localhost";
                string database = "itpmproject";
                string uid = "root";
                string password = "";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
