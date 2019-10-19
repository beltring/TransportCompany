using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    class CatalogContext
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

        public static void Select(DataGridView dataGridView1)
        {
            openConection();
            SqlDataReader sqlReader = null;
            SqlCommand sqlCommand = new SqlCommand(@"SELECT Id,Name,Cost,Weight,Volume FROM Cargos", sqlConnection);

            try
            {
                sqlReader = sqlCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    dataGridView1.Rows.Add(new string[] {
                            Convert.ToString(sqlReader["Id"]),
                            Convert.ToString(sqlReader["Name"]),
                            Convert.ToString(sqlReader["Cost"]),
                            Convert.ToString(sqlReader["Weight"]),
                            Convert.ToString(sqlReader["Volume"]) });
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
        }
        public static string SelectAllDetailed(int id)
        {
            openConection();
            //SqlDataReader sqlReader = null;
            
            SqlCommand sqlCommand = new SqlCommand($@"SELECT * FROM Cargos WHERE Id = {id} ", sqlConnection);

            StringBuilder result = new StringBuilder();
            try
            {
                using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        result.Append(Convert.ToString("Название:" + sqlReader["Name"] + "\n" + "Стоимость:" + sqlReader["Cost"] + "\n" 
                            + "Вес:" + sqlReader["Weight"] + "\n" + "Объём:" + sqlReader["Volume"] + "\n" + "Тип кузова:" + 
                            sqlReader["TrailerType"] + "\n" + "Дата загрузки:" + sqlReader["UploadDate"] + "\n" + "Статус заказа:" + 
                            sqlReader["Status"] + "\n" + "Место загрузки:" + sqlReader["DownloadLocation"] + "\n" + "Место разгрузки:" + 
                            sqlReader["PlaceOfDischarge"] + "\n" + "Расстояние:" + sqlReader["Distance"]));
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
            return result.ToString();
        }
        
        public static void UpdateStatus(string status,int id)
        {
            try
            {
                openConection();
                SqlCommand sqlCommand = new SqlCommand(@"UPDATE [Cargos] SET [Status] = @status WHERE [Id] = @id", sqlConnection);
                sqlCommand.Parameters.AddWithValue("Status", status);
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
