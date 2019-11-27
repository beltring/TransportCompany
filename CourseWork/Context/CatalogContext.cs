using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public class CatalogContext
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

        public static void Select(DataGridView dataGridView1)
        {
            openConection();
            SqlCommand sqlCommand = new SqlCommand(@"SELECT Id,Name,Cost,Weight,Volume FROM Cargos", sqlConnection);

            try
            {
                using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                {
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

        public static void SelectFavourites(DataGridView dataGridView1,int[] id)
        {
            dataGridView1.Update();
            foreach(int element in id)
            {
                openConection();
                SqlCommand sqlCommand = new SqlCommand($@"SELECT Id,Name,Cost,Weight,Volume FROM Cargos WHERE Id = {element}", sqlConnection);

                try
                {
                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
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

        public static bool AddCargo(Cargo cargo)
        {
            try
            {
                openConection();
                DataValidation dataValidation = new DataValidation();

                string name = cargo.Name;
                int cost = cargo.Cost;
                int weight = cargo.Weight;
                int volume = cargo.Volume;
                string uploadDate = cargo.UploadDate;
                string trailerType = cargo.TrailerType;
                string status = cargo.Status;
                string downloadLocation = cargo.DownloadLocation;
                string placeOfDischarge = cargo.PlaceOfDischarge;
                int distance = cargo.Distance;

                if (dataValidation.CheckEmptyFields(name, uploadDate, trailerType, status, downloadLocation, placeOfDischarge) &&
                    dataValidation.CheckCost(cost) && dataValidation.CheckDistance(distance) && dataValidation.CheckVolume(volume) &&
                    dataValidation.CheckWeight(weight)) // проверка данных
                {
                    SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO Cargos (
                            Name, Cost, Weight, Volume, TrailerType, UploadDate, Status, DownloadLocation, PlaceOfDischarge,Distance)
                            VALUES(@name, @cost, @weight, @volume, @trailerType, @uploadDate, @status,@downloadLocation,@placeOfDischarge,
                            @distance)",
                                CatalogContext.sqlConnection);
                    sqlCommand.Parameters.AddWithValue("Name", name);
                    sqlCommand.Parameters.AddWithValue("Cost", cost);
                    sqlCommand.Parameters.AddWithValue("Weight", weight);
                    sqlCommand.Parameters.AddWithValue("Volume", volume);
                    sqlCommand.Parameters.AddWithValue("TrailerType", trailerType);
                    sqlCommand.Parameters.AddWithValue("UploadDate", uploadDate);
                    sqlCommand.Parameters.AddWithValue("Status", status);
                    sqlCommand.Parameters.AddWithValue("DownloadLocation", downloadLocation);
                    sqlCommand.Parameters.AddWithValue("PlaceOfDischarge", placeOfDischarge);
                    sqlCommand.Parameters.AddWithValue("Distance", distance);

                    sqlCommand.ExecuteNonQuery();
                    closeConection();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                closeConection();
            }
                  
        }

        public static bool DeleteCargo(int id) {
            try // обработчик ошибок
            {
                openConection();

                if (id > 0)
                {
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM [Cargos] WHERE [Id] = @id", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("Id", id);
                    sqlCommand.ExecuteNonQuery();
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) // вызов при обнаружении ошибки
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally {
                closeConection();
            }
        }
    }
}
