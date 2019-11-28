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
            CargosDB.SelectAll(dataGridView1);
        }

        //Удаление записи из БД
        private void CargoDelete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int line = dataGridView1.CurrentRow.Index;
                int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value.ToString());

                CargosDB.DeleteCargo(id);

                MessageBox.Show("Запись удалена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
