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
    public partial class DeleteCargoForm : Form
    {
        readonly AdminForm adminForm;
        public DeleteCargoForm()
        {
            InitializeComponent();
        }

        public DeleteCargoForm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        //Запись данных в таблицу
        private void DeleteCargoForm_Load(object sender, EventArgs e)
        {
            CargosDB.SelectAllInfo(informationGridView);
            adminForm.Visible = false;
        }
        private void DeleteCargoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminForm.Visible = true;
        }

        private void DeleteCargoButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int line = informationGridView.CurrentRow.Index;
                int id = Convert.ToInt32(informationGridView.Rows[line].Cells[0].Value.ToString());

                CargosDB.DeleteCargo(id);

                MessageBox.Show("Запись удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            adminForm.Visible = true;
            this.Close();
        }
    }
}
