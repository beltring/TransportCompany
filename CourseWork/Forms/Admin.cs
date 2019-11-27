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
    public partial class Admin : Form
    {
        readonly HomeForm homeForm;

        public Admin()
        {
            InitializeComponent();
        }

        public Admin(HomeForm homeForm)
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
            Catalog catalog = new Catalog(this);
            catalog.Show();
        }

        private void ViewTheListOfCargos(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
