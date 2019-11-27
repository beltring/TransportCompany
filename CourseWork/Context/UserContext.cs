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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=d:\study\BNTU\5 sem\Тестирование\курсач\прога\CourseWork\CourseWork\Context\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        public static void closeConection()
        {
            if (sqlConnection != null)
                sqlConnection.Close();
        }

        public static void UpdateFavourites(string cargoId, string login)
        {
            try
            {
                openConection();
                SqlCommand sqlCommand = new SqlCommand(@"UPDATE [Users] SET [CargoId] = @cargoId WHERE [Login] = @Login", sqlConnection);
                sqlCommand.Parameters.AddWithValue("Login", login);
                sqlCommand.Parameters.AddWithValue("CargoId", cargoId);
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
        public static string SelectCargoId(string userId)
        {
            string result = null;
            openConection();
            SqlCommand sqlCommand = new SqlCommand($@"SELECT * FROM [Users] WHERE [Login] = '{userId}'", sqlConnection);

            try
            {
                using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        result = Convert.ToString(sqlReader["CargoId"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConection();
            }
            return result;
        }
    }
}
