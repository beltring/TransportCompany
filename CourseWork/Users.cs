using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Users
    {
        private SqlConnection sqlConnection;



        public async void AddUser(string login, string password,string cargoId = null)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\study\BNTU\5 sem\Тестирование\курсач\прога\CourseWork\CourseWork\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Users] (Login, Password)VALUES(@Login, @Password)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("Login", login);
            sqlCommand.Parameters.AddWithValue("Password", password);

            await sqlCommand.ExecuteNonQueryAsync();
        }


        private async void Connect()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\study\BNTU\5 sem\Тестирование\курсач\прога\CourseWork\CourseWork\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }
    }
}
