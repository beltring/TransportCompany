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
        readonly User userForm = null;
        public Catalog()
        {
            InitializeComponent();
        }
        public Catalog(User user)
        {
            this.userForm = user;
            InitializeComponent();
        }

        //Запись данных в таблицу
        private void Catalog_Load(object sender, EventArgs e)
        {
            CheckUserCatalog();
            CatalogContext.Select(dataGridView1);
            
        }

        private void Catalog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(userForm != null)
            {
                userForm.Visible = true;
            }
        }

        private void CheckUserCatalog()
        {
            if(userForm != null)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }

        private void DetailedInformation(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);
            string information = CatalogContext.SelectAllDetailed(id);
            MessageBox.Show(information,"Просмотр",MessageBoxButtons.OK);
        }

        private void StatusChange(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);
            CatalogContext.UpdateStatus("В пути", id);
        }

        private void AddToFavourites(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);
            UserContext.UpdateFavourites(id, userForm.Login);
            CatalogContext.UpdateStatus("В пути", id);
        }

        private void ExitUserPage(object sender, EventArgs e)
        {
            Close();
            userForm.Visible = true;
        }
    }
}

