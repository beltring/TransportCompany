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
    public partial class Favourites : Form
    {
        readonly User userForm;
        public Favourites()
        {
            InitializeComponent();
        }

        public Favourites(User userForm)
        {
            this.userForm = userForm;
            InitializeComponent();
        }

        private void Favourites_Load(object sender, EventArgs e)
        {
            string resultId = UserContext.SelectCargoId(userForm.Login);

            int[] id = resultId.Split(' ').
                        Where(x => !string.IsNullOrWhiteSpace(x)).
                        Select(x => int.Parse(x)).ToArray();

            CatalogContext.SelectFavourites(dataGridView1, id);

        }

        private void DetailedInformation(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);
            string information = CatalogContext.SelectAllDetailed(id);
            MessageBox.Show(information, "Просмотр", MessageBoxButtons.OK);
        }

        private void ExitUserPage(object sender, EventArgs e)
        {
            Close();
            userForm.Visible = true;
        }

        private void DeleteFavouritesCargo(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[line].Cells[0].Value);
            UserContext.UpdateFavourites(0, userForm.Login);
        }

        private void Favourites_FormClosed(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }
    }
}
