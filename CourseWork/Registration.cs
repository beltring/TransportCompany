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
    public partial class Registration : Form
    {
        SqlConnection sqlConnection;
        public Registration()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                MessageBox.Show("Одно из полей пустое");
            }
            else if(textBox2.Text.Length < 6 || textBox2.Text.Length > 25)
            {
                MessageBox.Show("Пароль содержит недоступное количество символов");
                textBox2.Clear();
            }
            else if(textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                textBox2.Clear();
                textBox3.Clear();
            }
            else if(textBox1.Text.Length < 4 || textBox1.Text.Length > 25)
            {
                MessageBox.Show("Логин содержит недоступное количество символов");
                textBox1.Clear();
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Users] (Login, Password)VALUES(@Login, @Password)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("Login", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("Password", textBox2.Text);

                await sqlCommand.ExecuteNonQueryAsync();

                MessageBox.Show("Регистрация прошла успешно");
            }
        }

        private async void Registration_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\study\BNTU\5 sem\Тестирование\курсач\прога\CourseWork\CourseWork\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
            

        }
    }
}
