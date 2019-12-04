using CourseWork.Context;
using System;
using System.Windows.Forms;

namespace CourseWork
{
    //Работа со списком грузов
    public partial class Catalog : Form
    {
        private UserForm userForm = null;
        private HomeForm homeForm;
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
            int id = GetIdInformationGridView(); 
            string information = CargosDB.SelectAllDetailed(id);
            MessageBox.Show(information,"Подробная информация",MessageBoxButtons.OK);
        }

        private void StatusChange(object sender, EventArgs e)
        {
            int id = GetIdInformationGridView();
            CargosDB.UpdateStatus("В пути", id);
        }

        private void AddToFavourites(object sender, EventArgs e)
        {
            int id = GetIdInformationGridView();
            string result = UsersDB.SelectCargoId(userForm.Login) + " " + Convert.ToString(id);
            UsersDB.UpdateFavourites(result, userForm.Login);
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

        private int GetIdInformationGridView()
        {
            int line = informationGridView.CurrentRow.Index;
            int id = Convert.ToInt32(informationGridView.Rows[line].Cells[0].Value);
            return id;
        }
    }
}

