using CourseWork.Context;
using CourseWork.Util;
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
        private Cargo cargo;
        private int id;
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            CargosDB.SelectAllInfo(informationGridView);
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminForm.Visible = true;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            adminForm.Visible = false;
        }

        private void SelectCargoButton_Click(object sender, EventArgs e)
        {
            int line = informationGridView.CurrentRow.Index;
            id = Convert.ToInt32(informationGridView.Rows[line].Cells[0].Value);
            cargo = CargosDB.SelectById(id);
            OpenFields();
            FillFields();
        }

        private void EditCargoButton_Click(object sender, EventArgs e)
        {  
            if (EditFiledsCargo() && CargosDB.EditCargo(id,cargo))
            {
                MessageBox.Show("Груз изменён.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
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

        private void FillFields()
        {
            nameTextBox.Text = cargo.Name;
            costTextBox.Text = cargo.Cost.ToString();
            weightTextBox.Text = cargo.Weight.ToString();
            volumeTextBox.Text = cargo.Volume.ToString();
            uploadDateTextBox.Text = cargo.UploadDate.ToString();
            trailerTypeComboBox.Text = cargo.TrailerType;
            statusComboBox.Text = cargo.Status;
            loadLocationTextBox.Text = cargo.DownloadLocation;
            placeOfDischargeTextBox.Text = cargo.PlaceOfDischarge;
            distanceTextBox.Text = cargo.Distance.ToString();
        }

        private bool EditFiledsCargo()
        {
            try
            {
                cargo.Name = nameTextBox.Text;
                cargo.Cost = Convert.ToDouble(costTextBox.Text);
                cargo.Weight = Convert.ToDouble(weightTextBox.Text);
                cargo.Volume = Convert.ToDouble(volumeTextBox.Text);
                cargo.UploadDate = DateTime.Parse(uploadDateTextBox.Text);
                cargo.TrailerType = trailerTypeComboBox.SelectedItem.ToString();
                cargo.Status = statusComboBox.SelectedItem.ToString();
                cargo.DownloadLocation = loadLocationTextBox.Text;
                cargo.PlaceOfDischarge = placeOfDischargeTextBox.Text;
                cargo.Distance = Convert.ToInt32(distanceTextBox.Text);

                return true;
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                return false;
            }
            
        }
    }
}
