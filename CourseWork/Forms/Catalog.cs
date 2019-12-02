using CourseWork.Context;
using System;
using System.Windows.Forms;

namespace CourseWork
{
    //Работа со списком грузов
    public partial class Catalog : Form
    {
        readonly UserForm userForm = null;
        readonly HomeForm homeForm;
        public Catalog()
        {
            InitializeComponent();
        }
        public Catalog(UserForm user)
        {
            InitializeComponent();
            this.userForm = user;
        }

        public Catalog(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        //Запись данных в таблицу
        private void Catalog_Load(object sender, EventArgs e)
        {
            if (userForm != null)
            {
                userForm.Visible = false;
            }
            else
            {
                CheckGuestCatalog();
                homeForm.Visible = false;
            }
            
            CargosDB.Select(informationGridView);
        }

        private void Catalog_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckRole();
        }

        private void DetailedInformation(object sender, EventArgs e)
        {
            int line = informationGridView.CurrentRow.Index;
            int id = Convert.ToInt32(informationGridView.Rows[line].Cells[0].Value);
            string information = CargosDB.SelectAllDetailed(id);
            MessageBox.Show(information,"Просмотр",MessageBoxButtons.OK);
        }

        private void StatusChange(object sender, EventArgs e)
        {
            int line = informationGridView.CurrentRow.Index;
            int id = Convert.ToInt32(informationGridView.Rows[line].Cells[0].Value);
            CargosDB.UpdateStatus("В пути", id);
        }

        private void AddToFavourites(object sender, EventArgs e)
        {
            int line = informationGridView.CurrentRow.Index;
            int id = Convert.ToInt32(informationGridView.Rows[line].Cells[0].Value);
            string result = UsersDB.SelectCargoId(userForm.Login) + " " + Convert.ToString(id);
            UsersDB.UpdateFavourites(result, userForm.Login);
            //CargosDB.UpdateStatus("В пути", id);
        }

        private void ExitToUserPage(object sender, EventArgs e)
        {
            Close();
            CheckRole();
        }

        private void CheckGuestCatalog()
        {
            if (userForm == null)
            {
                addFavouritesButton.Visible = false;
                detailedInfoButton.Visible = false;
                takeOrderButton.Visible = false;
                exitButton.Visible = true;
                exitButton.Text = "Вернуться";
            }
        }

        private void CheckRole()
        {
            if (userForm != null)
            {
                userForm.Visible = true;
            }
            else
            {
                homeForm.Visible = true;
            }
        }
    }
}

