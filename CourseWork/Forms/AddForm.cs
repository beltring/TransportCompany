using CourseWork.Context;
using CourseWork.Util;
using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddForm : Form
    {
        readonly AdminForm admin;
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(AdminForm admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        //Добавление записи в БД
        private void CargoAdd_Click(object sender, EventArgs e)
        {
            Cargo cargo;

            try {
                cargo = Initializer.InitCargoWithAddForm(this);

                if (!CargosDB.CheckCargoInDB(cargo))
                {
                    if (CargosDB.AddCargo(cargo))
                    {
                        MessageBox.Show("Груз успешно добавлен.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность ввода данных", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Груз с таким наименованием уже существует", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
