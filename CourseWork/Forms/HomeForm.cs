using CourseWork.Context;
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

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Authorization(object sender, EventArgs e)
        {
            Form autorization = new Authorization(this);
            autorization.Show();
            this.Visible = false;
        }

        private void Registration(object sender, EventArgs e)
        {
            Form form = new Registration(this);
            form.Show();
            this.Visible = false;
        }

        private void LogInAsAdministrator(object sender, EventArgs e)
        {
            Authorization(sender,e);
        }
    }
}
