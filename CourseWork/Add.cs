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
            string name = textBox1.Text;
            int cost = Convert.ToInt32(textBox2.Text);
            int weight = Convert.ToInt32(textBox3.Text);
            int volume = Convert.ToInt32(textBox4.Text);
            string uploadDate = textBox5.Text;
            string trailerType = comboBox1.SelectedItem.ToString();
            string status = comboBox2.SelectedItem.ToString();

            if(DataValidation.CheckEmptyFields(name,uploadDate,trailerType,status) && 
                DataValidation.CheckNegativeNumber(cost, weight, volume))
            {
                SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO Cargos (
                            Name, Cost, Weight, Volume, TrailerType, UploadDate, Status)
                            VALUES(@name, @cost, @weight, @volume, @trailerType, @uploadDate, @status)",
                            Connection.sqlConnection);
                sqlCommand.Parameters.AddWithValue("Name", name);
                sqlCommand.Parameters.AddWithValue("Cost", cost);
                sqlCommand.Parameters.AddWithValue("Weight", weight);
                sqlCommand.Parameters.AddWithValue("Volume", volume);
                sqlCommand.Parameters.AddWithValue("TrailerType", trailerType);
                sqlCommand.Parameters.AddWithValue("UploadDate", uploadDate);
                sqlCommand.Parameters.AddWithValue("Status", status);
                sqlCommand.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            Connection.closeConection();
            MessageBox.Show("Груз успешно добавлен.");
            this.Close();

        }
    }
}
