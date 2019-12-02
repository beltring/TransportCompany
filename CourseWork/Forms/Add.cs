using CourseWork.Context;
using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Add : Form
    {
        readonly AdminForm admin;
        public Add()
        {
            InitializeComponent();
        }
        public Add(AdminForm admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        //Добавление записи в БД
        private void CargoAdd_Click(object sender, EventArgs e)
        {
            Cargo cargo;

            try {
                string name = nameTextBox.Text;
                double cost = Convert.ToDouble(costTextBox.Text);
                double weight = Convert.ToDouble(weightTextBox.Text);
                double volume = Convert.ToDouble(volumeTextBox.Text);
                string uploadDate = uploadDateTextBox.Text;
                string trailerType = trailerTypeComboBox.SelectedItem.ToString();
                string status = statusComboBox.SelectedItem.ToString();
                string downloadLocation = loadLocationTextBox.Text;
                string placeOfDischarge = placeOfDischargeTextBox.Text;
                int distance = Convert.ToInt32(distanceTextBox.Text);

                cargo = new Cargo
                {
                    Name = name,
                    Cost = cost,
                    Weight = weight,
                    Volume = volume,
                    UploadDate = DateTime.Parse(uploadDate),
                    TrailerType = trailerType,
                    Status = status,
                    DownloadLocation = downloadLocation,
                    PlaceOfDischarge = placeOfDischarge,
                    Distance = distance
                };

                if (!CargosDB.CheckCargoInDB(cargo))
                {
                    if (CargosDB.AddCargo(cargo))
                    {
                        MessageBox.Show("Груз успешно добавлен.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность ввода данных", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    MessageBox.Show("Груз с таким наименованием уже существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            catch {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            admin.Visible = false;
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            admin.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            admin.Visible = true;
            Close();
        }
    }
}
