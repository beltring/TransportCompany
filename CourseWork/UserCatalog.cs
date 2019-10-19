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
    public partial class UserCatalog : Form
    {
        readonly User user;
        public UserCatalog()
        {
            InitializeComponent();
        }
        public UserCatalog(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void UserCatalog_Load(object sender, EventArgs e)
        {
            user.Visible = false;
            CatalogContext.Select(dataGridView1);
        }

        private void UserCatalog_FormClosed(object sender, FormClosedEventArgs e)
        {
            user.Visible = true;
        }
    }
}
