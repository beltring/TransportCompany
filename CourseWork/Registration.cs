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
        SqlConnection sqlConnection;
        readonly Form1 form;

        public Registration(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        //Регистрация пользователя и занесение данных в БД
        private async void RegistrationOfUsers(object sender, EventArgs e)
        {
            if (DataValidation.CheckEmptyFields(textBox1.Text, textBox2.Text, textBox3.Text))
            {
                if (DataValidation.CheckLenghtLogin(textBox1.Text))
                {
                    if (DataValidation.CheckLenghtPassword(textBox2.Text))
                    {
                        if (DataValidation.CheckPasswordMatch(textBox2.Text, textBox3.Text))
                        {
                            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Users] (Login, Password)VALUES(@Login, @Password)", sqlConnection);

                            sqlCommand.Parameters.AddWithValue("Login", textBox1.Text);
                            sqlCommand.Parameters.AddWithValue("Password", textBox2.Text);

                            await sqlCommand.ExecuteNonQueryAsync();

                            MessageBox.Show("Регистрация прошла успешно");
                            form.OnVisible(true);
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
        }

        private async void Registration_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Constants.connectionString);
            await sqlConnection.OpenAsync();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.OnVisible(true);
        }
    }
}
