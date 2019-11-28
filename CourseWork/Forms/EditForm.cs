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
    public partial class EditForm : Form
    {
        readonly AdminForm adminForm;
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            CargosDB.SelectAll(informationGridView);
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminForm.Visible = true;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            adminForm.Visible = false;
        }

        private void OpenFields()
        {
            nameTextBox.ReadOnly = false;
            costTextBox.ReadOnly = false;
            weightTextBox.ReadOnly = false;
            volumeTextBox.ReadOnly = false;
            uploadDateTextBox.ReadOnly = false;
            loadLocationTextBox.ReadOnly = false;
            placeOfDischargeTextBox.ReadOnly = false;
            distanceTextBox.ReadOnly = false;
            editCargoButton.Enabled = true;
        }

        private void SelectCargoButton_Click(object sender, EventArgs e)
        {
            int line = informationGridView.CurrentRow.Index;
            int id = Convert.ToInt32(informationGridView.Rows[line].Cells[0].Value);
            Cargo cargo = CargosDB.SelectById(id);
        }
    }
}
