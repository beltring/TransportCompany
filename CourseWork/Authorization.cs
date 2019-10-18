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
    //Класс для авторизации в программе
    public partial class Authorization : Form
    {
        readonly Form1 form;
        public Authorization(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }
        public Authorization()
        {
            InitializeComponent();
        }

        //Авторизация пользователя и администратора
        private void UserAuthorization(object sender, EventArgs e)
        {
            bool isUser = IsUser(textBox1.Text, textBox2.Text);
            bool isAdmin = IsAdmin(textBox1.Text, textBox2.Text);

            if (isAdmin)
            {
                Admin admin = new Admin();
                admin.Show();
            }
            else if (isUser)
            {
                User user = new User();
                user.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно! Попробуйте ещё раз!");
                textBox1.Clear();
                textBox2.Clear();
            }
            this.Close();
        }

        //Проверка авторизации адинистратора
        public bool IsAdmin(string login, string password)
        {
            if(login.Equals("admin") && password.Equals("admin99"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Проверка авторизации пользователя
        public bool IsUser(string login,string password)
        {
            Connection.openConection();
            SqlDataReader sqlReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT Login, Password FROM Users", Connection.sqlConnection);
            try
            {
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    if (Convert.ToString(sqlReader["Login"]) == login && Convert.ToString(sqlReader["Password"]) == password)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                Connection.closeConection();

                if (sqlReader != null)
                    sqlReader.Close();
            }
            
            return false;
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.OnVisible(true);
        }
    }
}
