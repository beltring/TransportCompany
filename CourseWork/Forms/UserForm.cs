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
    public partial class UserForm : Form
    {
        readonly HomeForm homeForm;
        private string login;

        public string Login { get => login; set => login = value; }

        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(HomeForm form,string login)
        {
            this.homeForm = form;
            this.login = login;
            InitializeComponent();
        }

        private void LoadFavourites(object sender, EventArgs e)
        {
            FavouritesForm favourites = new FavouritesForm(this);
            favourites.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
            homeForm.Visible = true;
        }

        private void LoadCargoCatalog(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog(this);
            catalog.Show();
            //this.Visible = false;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            homeForm.Visible = false;
        }

        private void UserForm_Closed(object sender, FormClosedEventArgs e)
        {
            homeForm.Visible = true;
        }
    }
}
