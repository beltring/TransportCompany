using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    // Регистрация пользователей
    public partial class Registration : Form
    {
        readonly HomeForm form;

        public Registration(HomeForm form)
        {
            this.form = form;
            InitializeComponent();
        }
        public Registration()
        {
            InitializeComponent();
        }

        //Регистрация пользователя и занесение данных в БД
        public void RegistrationOfUsers(object sender, EventArgs e)
        {
            DataValidation dv = new DataValidation();
            if (dv.CheckEmptyFields(textBox1.Text, textBox2.Text, textBox3.Text))
            {
                if (dv.CheckLenghtLogin(textBox1.Text))
                {
                    if (dv.CheckLenghtPassword(textBox2.Text))
                    {
                        if (dv.CheckPasswordMatch(textBox2.Text, textBox3.Text))
                        {
                            using (TransportCompanyContext db = new TransportCompanyContext())
                            {
                                User newUser = new User { Login = textBox1.Text, Password = textBox2.Text };
                                db.Users.Add(newUser);
                                db.SaveChanges();

                                MessageBox.Show("Регистрация прошла успешно");
                                form.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пароли не совпадают");
                            textBox2.Clear();
                            textBox3.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароль содержит недоступное количество символов");
                        textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Логин содержит недоступное количество символов");
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Одно из полей пустое");
            }
            this.Close();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Visible = true;
        }
    }
}
