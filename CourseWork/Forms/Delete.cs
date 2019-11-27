using CourseWork.Context;
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
        public Delete()
        {
            InitializeComponent();
        }

        //Запись данных в таблицу
        private void Delete_Load(object sender, EventArgs e)
        {
            CargosDB.Select(dataGridView1);
        }

        //Удаление записи из БД
        private void CargoDelete(object sender, EventArgs e)
        {
            CatalogContext.openConection();
            if (MessageBox.Show("Удалить груз?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int line = dataGridView1.CurrentRow.Index;
                int Id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value.ToString());

                SqlCommand command = new SqlCommand(@"DELETE FROM Cargos WHERE Id = @Id", CatalogContext.sqlConnection);
                command.Parameters.AddWithValue("Id", Id);
                command.ExecuteNonQuery();

                MessageBox.Show("Книга успешно удалена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CatalogContext.closeConection();
            this.Close();
        }
    }
}
