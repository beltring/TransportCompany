using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        //Добавление записи в БД
        private void CargoAdd(object sender, EventArgs e)
        {
            DataValidation dv = new DataValidation();
            string name = textBox1.Text;
            int cost = Convert.ToInt32(textBox2.Text);
            int weight = Convert.ToInt32(textBox3.Text);
            int volume = Convert.ToInt32(textBox4.Text);
            string uploadDate = textBox5.Text;
            string trailerType = comboBox1.SelectedItem.ToString();
            string status = comboBox2.SelectedItem.ToString();
            string downloadLocation = "Minsk";
            string placeOfDischarge = "Gomel";
            int distance = 382;

            if(dv.CheckEmptyFields(name,uploadDate,trailerType,status) &&
                dv.CheckNegativeNumber(cost, weight, volume))
            {
                CatalogContext.openConection();
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
                CatalogContext.closeConection();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            CatalogContext.closeConection();
            MessageBox.Show("Груз успешно добавлен.");
            this.Close();

        }
    }
}
