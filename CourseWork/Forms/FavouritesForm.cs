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
    public partial class FavouritesForm : Form
    {
        readonly UserForm userForm;
        public FavouritesForm()
        {
            InitializeComponent();
        }

        public FavouritesForm(UserForm userForm)
        {
            this.userForm = userForm;
            InitializeComponent();
        }

        private void Favourites_Load(object sender, EventArgs e)
        {
            string resultId = UsersDB.SelectCargoId(userForm.Login);
            if(resultId != null && resultId != " ")
            {
                userForm.Visible = false;
                int[] id = resultId.Split(' ').
                        Where(x => !string.IsNullOrWhiteSpace(x)).
                        Select(x => int.Parse(x)).ToArray();
                CargosDB.SelectFavourites(dataGridView1, id);
            }
            else
            {
                MessageBox.Show("Добавьте груз в избранное", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                this.Close();
            }
        }

        private void DetailedInformation(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);
            string information = CargosDB.SelectAllDetailed(id);
            MessageBox.Show(information, "Просмотр", MessageBoxButtons.OK);
        }

        private void DeleteFavouritesCargo(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);
            string cargoId = UsersDB.SelectCargoId(userForm.Login);
            int n = cargoId.IndexOf(id.ToString());
            cargoId = cargoId.Remove(n, id.ToString().Length);
            UsersDB.UpdateFavourites(cargoId, userForm.Login);
        }

        private void ExitUserPage(object sender, EventArgs e)
        {
            Close();
            userForm.Visible = true;
        }

        private void Favourites_FormClosed(object sender, FormClosedEventArgs e)
        {
            userForm.Visible = true;
        }
    }
}
