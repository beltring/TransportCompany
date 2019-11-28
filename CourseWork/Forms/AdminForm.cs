using CourseWork.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AdminForm : Form
    {
        readonly HomeForm homeForm;

        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        private void ExitToHomeForm(object sender, EventArgs e)
        {
            homeForm.Visible = true;
            this.Close();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm.Visible = true;
        }

        private void AddCargo(object sender, EventArgs e)
        {
            Add addForm = new Add(this);
            addForm.Show();
        }

        private void DeleteCargo(object sender, EventArgs e)
        {
            DeleteCargoForm deleteForm = new DeleteCargoForm(this);
            deleteForm.ShowDialog();
        }

        private void ViewTheListOfCargos(object sender, EventArgs e)
        {
            CatalogForAdmin catalog = new CatalogForAdmin(this);
            catalog.Show();
        }

        private void EditCargo(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            editForm.Show();
        }

        private void EditStatusButton_Click(object sender, EventArgs e)
        {
            EditCargo(sender, e);
        }
    }
}
