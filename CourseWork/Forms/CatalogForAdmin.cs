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

namespace CourseWork.Forms
{
    public partial class CatalogForAdmin : Form
    {
        readonly AdminForm adminForm;
        public CatalogForAdmin()
        {
            InitializeComponent();
        }
        public CatalogForAdmin(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            CargosDB.SelectAllInfo(informationGridView);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            adminForm.Visible = true;
            Close();
        }

        private void CatalogForAdmin_Load(object sender, EventArgs e)
        {
            adminForm.Visible = false;
        }

        private void CatalogForAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminForm.Visible = true;
        }
    }
}
