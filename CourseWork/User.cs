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
    public partial class User : Form
    {
        readonly HomeForm homeForm;
        private string login;

        public string Login { get => login; set => login = value; }

        public User()
        {
            InitializeComponent();
        }
        public User(HomeForm form,string login)
        {
            this.homeForm = form;
            this.login = login;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
            homeForm.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog(this);
            catalog.Show();
            this.Visible = false;
        }

        private void User_Load(object sender, EventArgs e)
        {
            homeForm.Visible = false;
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm.Visible = true;
        }
    }
}
