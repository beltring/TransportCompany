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
    public partial class Add : Form
    {
        readonly Admin admin;
        public Add()
        {
            InitializeComponent();
        }
        public Add(Admin admin)
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
                int cost = Convert.ToInt32(textBox2.Text);
                int weight = Convert.ToInt32(textBox3.Text);
                int volume = Convert.ToInt32(textBox4.Text);
                string uploadDate = textBox5.Text;
                string trailerType = comboBox1.SelectedItem.ToString();
                string status = comboBox2.SelectedItem.ToString();
                string downloadLocation = textBox6.Text;
                string placeOfDischarge = textBox7.Text;
                int distance = Convert.ToInt32(textBox8.Text);

                cargo = new Cargo(name, cost, weight, volume, uploadDate, trailerType, status, downloadLocation, placeOfDischarge, distance);

                if (CatalogContext.AddCargo(cargo))
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
