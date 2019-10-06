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
    public partial class Form1 : Form
    {
        public Form1()
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
            OnVisible(false);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form form = new Registration(this);
            form.Show();
            OnVisible(false);
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        public void OnVisible(bool check)
        {
            if(check == true) {
                this.Visible = true;
            }
            else
            {
                this.Visible = false;
            }
        }
    }
}
