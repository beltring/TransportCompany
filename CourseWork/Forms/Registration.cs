using CourseWork.Context;
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
                            if (!UsersDB.CheckUserInDB(textBox1.Text))
                            {
                                UsersDB.AddUser(textBox1.Text, textBox2.Text);
                                MessageBox.Show("Регистрация прошла успешно");
                                form.Visible = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Пользователь с таким логином уже существует. Введите другой логин","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пароли не совпадают","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox2.Clear();
                            textBox3.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароль содержит недоступное количество символов", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Логин содержит недоступное количество символов", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Одно из полей пустое", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Visible = true;
        }
    }
}
