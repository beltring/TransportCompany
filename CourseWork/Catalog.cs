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
    //Работа со списком грузов
    public partial class Catalog : Form
    {
        SqlConnection sqlConnection;
        public Catalog()
        {
            InitializeComponent();
        }

        //Запись данных в таблицу
        private async void Catalog_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Constants.connectionString);
            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;
            SqlCommand sqlCommand = new SqlCommand(@"SELECT * FROM Cargos", sqlConnection);
            try
            {
                sqlReader = sqlCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    dataGridView1.Rows.Add(new string[] {
                            Convert.ToString(sqlReader["Name"]),
                            Convert.ToString(sqlReader["Cost"]),
                            Convert.ToString(sqlReader["Weight"]),
                            Convert.ToString(sqlReader["Volume"]),
                            Convert.ToString(sqlReader["TrailerType"]),
                            Convert.ToString(sqlReader["UploadDate"]),
                            Convert.ToString(sqlReader["Status"])});
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnection.Close();
        }

    }
}

