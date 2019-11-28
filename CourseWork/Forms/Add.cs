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
        private void CargoAdd(object sender, EventArgs e)
        {
            Cargo cargo;

            try {
                DataValidation dv = new DataValidation();
                string name = textBox1.Text;
                double cost = Convert.ToDouble(textBox2.Text);
                double weight = Convert.ToDouble(textBox3.Text);
                double volume = Convert.ToDouble(textBox4.Text);
                string uploadDate = textBox5.Text;
                string trailerType = comboBox1.SelectedItem.ToString();
                string status = comboBox2.SelectedItem.ToString();
                string downloadLocation = textBox6.Text;
                string placeOfDischarge = textBox7.Text;
                int distance = Convert.ToInt32(textBox8.Text);

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

                if (CargosDB.AddCargo(cargo))
                {
                    //CatalogContext.closeConection();
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
            catch {
                MessageBox.Show("Не все поля заполнены", "Ошибка",
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
    }
}
