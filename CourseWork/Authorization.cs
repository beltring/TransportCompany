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
        readonly HomeForm homeForm;
        public Authorization(HomeForm form)
        {
            this.homeForm = form;
            InitializeComponent();
            //Connection.openConection();
        }
        public Authorization()
        {
            InitializeComponent();
            CatalogContext.openConection();
        }

        //Авторизация пользователя и администратора
        private void UserAuthorization(object sender, EventArgs e)
        {
            bool isUser = IsUser(textBox1.Text, textBox2.Text);
            bool isAdmin = IsAdmin(textBox1.Text, textBox2.Text);

            if (isAdmin)
            {
                Admin admin = new Admin(new HomeForm());
                admin.Show();
                Visible = false;
            }
            else if (isUser)
            {
                User user = new User(homeForm, textBox1.Text);
                user.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно! Попробуйте ещё раз!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        //Проверка авторизации адинистратора
        public bool IsAdmin(string login, string password)
        {
            bool result = false;
            if(login.Equals("admin") && password.Equals("admin99"))
            {
                result = true;
            }

            return result;
        }

        //Проверка авторизации пользователя
        public bool IsUser(string login,string password)
        {
            CatalogContext.openConection();
            SqlDataReader sqlReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT Login, Password FROM Users", CatalogContext.sqlConnection);
            bool result = false;

            try
            {
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    if (Convert.ToString(sqlReader["Login"]) == login && Convert.ToString(sqlReader["Password"]) == password)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
                CatalogContext.closeConection();
            }
            
            return result;
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm.Visible = true;
        }
    }
}
