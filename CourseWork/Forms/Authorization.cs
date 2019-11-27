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
                UserForm user = new UserForm(homeForm, textBox1.Text);
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
