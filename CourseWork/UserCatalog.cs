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
        public UserCatalog()
        {
            InitializeComponent();
        }

        private void UserCatalog_Load(object sender, EventArgs e)
        {
            Connection.openConection();
            SqlDataReader sqlReader = null;
            SqlCommand sqlCommand = new SqlCommand(@"SELECT * FROM Cargos", Connection.sqlConnection);
            try
            {
                sqlReader = sqlCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    dataGridView1.Rows.Add(new string[] {
                            Convert.ToString(sqlReader["Name"]),
                            Convert.ToString(sqlReader["Cost"]),
                            Convert.ToString(sqlReader["Weight"]),
                            Convert.ToString(sqlReader["Volume"]),
                            Convert.ToString(sqlReader["TrailerType"]),
                            Convert.ToString(sqlReader["UploadDate"]),
                            Convert.ToString(sqlReader["Status"])});
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.closeConection();
            }
        }
    }
}
