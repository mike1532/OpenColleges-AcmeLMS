using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_OC.Business_Logic_Layer;
using LMS_OC.Data_Access_Layer;
using System.Data.SqlClient;

namespace LMS_OC.Presentation_Layer
{
    public partial class frmBorrowBook : Form
    {
        public frmBorrowBook()
        {
            InitializeComponent();
        }

        

        //events
        private void frmBorrowBook_Load(object sender, EventArgs e)
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
        private void dateTimePickerDateOfIssue_Leave(object sender, EventArgs e)
        {
            SetReturnDate();
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
        public void SetReturnDate()
        {
            txtReturnDate.Text = dateTimePickerDateOfIssue.Value.AddDays(7).ToString("ddd d MMM yyyy"); 
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

        //buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtBookTitle.Clear();
            txtReturnDate.Clear();
            txtStudentName.Clear();
            txtStudentID.Clear();
            dateTimePickerDateOfIssue.Value = DateTime.Now;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtReturnDate.Text))
            {
                MessageBox.Show("Return date not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {               

                string addQuery = "sp_BookIssue_BorrowBook";
                string update = "UPDATE Book SET noOfAvailableBooks = noOfAvailableBooks - 1, noOfBorrowedBooks = noOfBorrowedBooks + 1 WHERE bookID = '" + txtBookID.Text + "'";
                SqlConnection connection = ConnectionManager.DBConnection();
                SqlCommand command = new SqlCommand(addQuery, connection);
                SqlCommand command1 = new SqlCommand(update, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@BookID", int.Parse(txtBookID.Text));
                command.Parameters.AddWithValue("@StudentID", int.Parse(txtStudentID.Text));
                command.Parameters.AddWithValue("@IssueDate", dateTimePickerDateOfIssue.Value);
                command.Parameters.AddWithValue("@ReturnDate", DateTime.Parse(txtReturnDate.Text));
                command.Parameters.AddWithValue("@LibrarianID", int.Parse(txtLibrarianID.Text));
                command.Parameters.AddWithValue("NewIssueID", SqlDbType.Int).Direction = ParameterDirection.Output;

                connection.Open();
                command.Transaction = connection.BeginTransaction();
                command.ExecuteNonQuery();
                command.Transaction.Commit();

                command1.Transaction = connection.BeginTransaction();
                command1.ExecuteNonQuery();
                command1.Transaction.Commit();

                connection.Close();
                Close();                

                MessageBox.Show("Success", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("unsuccessful " + ex);
            }
        }
    }
}
