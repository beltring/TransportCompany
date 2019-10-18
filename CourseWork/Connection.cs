using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Connection
    {
        public static SqlConnection sqlConnection;

        public static void openConection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\study\BNTU\5 sem\Тестирование\курсач\прога\CourseWork\CourseWork\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        public static void closeConection()
        {
            if (Connection.sqlConnection != null)
                Connection.sqlConnection.Close();
        }
    }
}
