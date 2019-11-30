using System;
using System.Linq;
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
        }
        public Authorization()
        {
            InitializeComponent();
        }

        //Авторизация пользователя и администратора
        private void UserAuthorization(object sender, EventArgs e)
        {
            DataValidation dv = new DataValidation();
            if (dv.CheckAuth(loginTextBox.Text, passwordTextBox.Text))
            {
                bool isUser = IsUser(loginTextBox.Text, passwordTextBox.Text);
                bool isAdmin = IsAdmin(loginTextBox.Text, passwordTextBox.Text);

                if (isAdmin)
                {
                    AdminForm admin = new AdminForm(homeForm);
                    admin.Show();
                    Close();
                    homeForm.Visible = false;
                }
                else if (isUser)
                {
                    UserForm user = new UserForm(homeForm, loginTextBox.Text);
                    user.Show();
                    Close();
                    homeForm.Visible = false;
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены неверно! Попробуйте ещё раз!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginTextBox.Clear();
                    passwordTextBox.Clear();
                }
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
            using (TransportCompanyContext db = new TransportCompanyContext())
            {
                bool result = false;

                try
                {
                    var users = db.Users.ToList();
                    foreach (var user in users)
                    {
                        if (user.Login == login && user.Password == password)
                        {
                            result = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                return result;
            }

        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm.Visible = true;
        }
    }
}
