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
    //Работа со списком грузов
    public partial class Catalog : Form
    {
        readonly UserForm userForm = null;
        readonly AdminForm adminForm = null;
        public Catalog()
        {
            InitializeComponent();
        }
        public Catalog(UserForm user)
        {
            InitializeComponent();
            this.userForm = user;
        }
        public Catalog(AdminForm admin)
        {
            InitializeComponent();
            this.adminForm = admin;
        }

        //Запись данных в таблицу
        private void Catalog_Load(object sender, EventArgs e)
        {
            CheckUserCatalog();
            CheckAdminCatalog();
            CargosDB.SelectAll(dataGridView1);
            
        }

        private void Catalog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(userForm != null)
            {
                userForm.Visible = true;
            }
            else if(adminForm != null)
            {
                adminForm.Visible = true;
            }
        }

        private void CheckUserCatalog()
        {
            if(userForm != null)
            {
                userForm.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }

        private void CheckAdminCatalog()
        {
            if (adminForm != null)
            {
                adminForm.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
            }
        }

        private void DetailedInformation(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);
            string information = CargosDB.SelectAllDetailed(id);
            MessageBox.Show(information,"Просмотр",MessageBoxButtons.OK);
        }

        private void StatusChange(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);
            CargosDB.UpdateStatus("В пути", id);
        }

        private void AddToFavourites(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);
            string result = UsersDB.SelectCargoId("kess") + " " + Convert.ToString(id);
            UsersDB.UpdateFavourites(result, userForm.Login);
            CargosDB.UpdateStatus("В пути", id);
        }

        private void ExitToUserPage(object sender, EventArgs e)
        {
            Close();
            userForm.Visible = true;
        }

        private void DeleteCargo(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);

        }

        private void ExitToAdminFrom(object sender, EventArgs e)
        {
            Close();
            adminForm.Visible = true;
        }
    }
}

