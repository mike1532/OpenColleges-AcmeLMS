using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_OC.Data_Access_Layer;
using System.Data.SqlClient;



namespace LMS_OC.Presentation_Layer

{
    public partial class frmSearchBooks : Form
    {
        public frmSearchBooks()
        {
            InitializeComponent();
        }
                
        //RB settings
        private void rbTitle_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbAuthor.Visible = false;
            btnSearch.Visible = true;
        }

        private void rbAuthor_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbAuthor.Visible = true;
            cbAuthor.SelectedIndex = -1;
            cbAuthor.Top = txtSearch.Top;
            cbAuthor.Left = txtSearch.Left;
            btnSearch.Visible = true;
        }

        //Load author into combo box
        private void frmSearchBooks_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Author";
            SqlConnection connection = ConnectionManager.DBConnection();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lbAuthor.Items.Add(reader["authorID"].ToString());
                    cbAuthor.Items.Add(reader["authorName"].ToString());
                }
                if (reader != null)
                    reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful " + ex);
            }
        }


        //Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close form
            Close();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            //GOTO reserve form
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //When clicked button disappears and results box appears
            btnSearch.Visible = false;
            gbResults.Visible = true;

            if (rbTitle.Checked == true)
            {

            }
        }

       
    }
}
