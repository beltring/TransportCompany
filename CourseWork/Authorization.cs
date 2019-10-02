using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Authorization : Form
    {
        Form1 f;
        public Authorization(Form1 form)
        {
            f = form;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Поля логин и пароль должны быть заполнены");
            }
            else if(textBox1.Text.Length < 4 || textBox1.Text.Length > 25)
            {
                MessageBox.Show("Логин должен содержать от 4 до 25 символов");
            }
            else if(textBox2.Text.Length < 6 || textBox2.Text.Length > 25)
            {
                MessageBox.Show("Пароль должен содержать от 6 до 25 символов");
            }

            if(textBox1.Text == "admin" && textBox2.Text == "admin99")
            {
                f.OnVisible(true);
            }
        }
    }
}
