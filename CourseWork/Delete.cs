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
    public partial class Delete : Form
    {
        SqlConnection sqlConnection;
        public Delete()
        {
            InitializeComponent();
        }

        //Запись данных в таблицу
        private async void Delete_Load(object sender, EventArgs e)
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
                            Convert.ToString(sqlReader["Id"]),
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

        //Удаление записи из БД
        private void CargoDelete(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (MessageBox.Show("Удалить груз?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int line = dataGridView1.CurrentRow.Index;
                int Id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value.ToString());

                SqlCommand command = new SqlCommand(@"DELETE FROM Cargos WHERE Id = @Id", sqlConnection);
                command.Parameters.AddWithValue("Id", Id);
                command.ExecuteNonQuery();

                MessageBox.Show("Книга успешно удалена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlConnection.Close();
            this.Close();
        }
    }
}
