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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form autorization = new Authorization(this);
            autorization.Show();
            this.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form form = new Registration(this);
            form.Show();
            this.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }
    }
}
