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
using LMS_OC.Business_Logic_Layer;
using System.Data.SqlClient;

namespace LMS_OC.Presentation_Layer
{
    public partial class frmBookReturn : Form
    {
        public frmBookReturn()
        {
            InitializeComponent();
        }

        //events
        private void frmBookReturn_Load(object sender, EventArgs e)
        {
            txtLibrarianID.Text = System.Environment.GetEnvironmentVariable("librarianID");
        }
        private void txtBookID_Leave(object sender, EventArgs e)
        {
            if (CheckBookID() == true)
                DisplayBookName();
        }
        private void txtStudentID_Leave(object sender, EventArgs e)
        {
            if (CheckStudentID() == true)
                DisplayStudentName();
        }

        //buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtBookTitle.Clear();
            txtDateofIssue.Clear();
            txtStudentName.Clear();
            txtStudentID.Clear();
            dateTimePickerReturnDate.Value = DateTime.Now;
        }

        //methods
        public void DisplayBookName()
        {
            //after the user enters the book id, the name will be displayed underneath.            
            string selectQuery = "SELECT Book.bookID, Book.title FROM Book WHERE bookID = '" + txtBookID.Text + "'";
            SqlConnection connection = ConnectionManager.DBConnection();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtBookTitle.Text = reader["title"].ToString();
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
        public void DisplayStudentName()
        {
            //after the user enters the student id, the name will be displayed underneath.            
            string selectQuery = "SELECT Student.studentID, Student.firstName, Student.lastName FROM " +
                "Student WHERE studentID = '" + txtStudentID.Text + "'";
            SqlConnection connection = ConnectionManager.DBConnection();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtStudentName.Text = reader["firstName"].ToString() + " " + reader["lastName"].ToString();
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
        public bool CheckBookID()
        {
            if (String.IsNullOrEmpty(txtBookID.Text))
            {
                MessageBox.Show("Please enter the Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookID.Focus();
                return false;
            }
            if (!int.TryParse(txtBookID.Text, out int parsedValue))
            {
                MessageBox.Show("Book ID must be of numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookID.Focus();
                return false;
            }
            return true;
        }
        public bool CheckStudentID()
        {
            if (String.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please enter Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentID.Focus();
                return false;
            }
            if (!int.TryParse(txtStudentID.Text, out int parsedValue))
            {
                MessageBox.Show("Student ID must be of numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookID.Focus();
                return false;
            }
            return true;
        }

        
    }
}
