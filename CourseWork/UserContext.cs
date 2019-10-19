using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    class UserContext
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
            if (sqlConnection != null)
                sqlConnection.Close();
        }

        public static void UpdateFavourites(int id,string login)
        {
            try
            {
                openConection();
                SqlCommand sqlCommand = new SqlCommand(@"UPDATE [Users] SET [CargoId] = @id WHERE [Login] = @login", sqlConnection);
                sqlCommand.Parameters.AddWithValue("Login", login);
                sqlCommand.Parameters.AddWithValue("Id", id);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConection();
            }
        }
    }
}
