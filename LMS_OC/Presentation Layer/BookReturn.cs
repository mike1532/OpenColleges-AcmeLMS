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
            btnSearchAgain.Visible = false;
            //SetBookAvailable();
        }        

        //buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtStudentID.Clear();            
            dateTimePickerReturnDate.Value = DateTime.Now;
        }

        private void btnSearchRecords_Click(object sender, EventArgs e)
        {
            if (CheckStudentID() == false)
                return;
            if (CheckBookID() == false)
                return;

            //Searchs that entered data matches a record in book issue
            string enteredStudentID = txtStudentID.Text;
            string enteredBookID = txtBookID.Text;
            string recordExists = "sp_BookIssue_RecordExists";
            int recordCount;

            SqlConnection connection = ConnectionManager.DBConnection();
            SqlCommand command = new SqlCommand(recordExists, connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@studentID", enteredStudentID);
            command.Parameters.AddWithValue("@bookID", enteredBookID);
            SqlParameter returnValue = new SqlParameter("@RecordCount", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.Output;
            command.Parameters.Add(returnValue);

            connection.Open();
            command.Transaction = connection.BeginTransaction();
            command.ExecuteNonQuery();
            command.Transaction.Commit();
            recordCount = (int)command.Parameters["@RecordCount"].Value;
            connection.Close();

            if (recordCount == 0)
            {
                MessageBox.Show("No record match found. Please check entered data.", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                //remove this once its loading successfully 
                MessageBox.Show("Record found.", "RECORD FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string selectQuery = "SELECT BookIssue.issueID, Book.bookID, Book.title, Student.studentID, " +
                        "Student.firstName, Student.lastName, BookIssue.issueDate," +
                        "BookIssue.returnDate, Librarian.librarianID FROM BookIssue " +
                        "INNER JOIN Book ON BookIssue.bookID = Book.bookID " +
                        "INNER JOIN Student ON BookIssue.studentID = Student.studentID " +
                        "INNER JOIN Librarian ON BookIssue.librarianID = Librarian.librarianID " +
                        "WHERE Student.studentID = '" + txtStudentID.Text + "' " +
                        "AND Book.bookID = '" + txtBookID.Text + "'";

                SqlConnection connection1 = ConnectionManager.DBConnection();
                SqlCommand command1 = new SqlCommand(selectQuery, connection1);

                try
                {
                    connection1.Open();
                    SqlDataReader reader = command1.ExecuteReader();
                    reader.Read();

                    lblDisplayName.Text = reader["firstName"].ToString() + " " + reader["lastName"].ToString();
                    lblDisplayTitle.Text = reader["title"].ToString();
                    string doi = reader["issueDate"].ToString();
                    DateTime issued = DateTime.Parse(doi);
                    lblDisplayDateIssued.Text = issued.ToString("ddd d MMM yyyy");
                    dateTimePickerReturnDate.Value = DateTime.Today;
                    txtIssueID.Text = reader["issueID"].ToString();
                    txtLibrarianID.Text = reader["librarianID"].ToString();

                    reader.Close();
                    connection1.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("unsuccessful " + ex);
                }

                DisplayInfo();
            }
        }

        private void btnSearchAgain_Click(object sender, EventArgs e)
        {
            SearchAgain();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {        
            
            /*if (DaysBorrowed() <= 7)
                MessageBox.Show("Message here. Thank you", "SUCCESS", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);        */ 
           
            try
            {
                double fine = CalculateFine();
                string addQuery = "sp_BookReturn_ReturnBook";
                string update = "UPDATE Book SET noOfAvailableBooks = noOfAvailableBooks + 1, " +
                         "noOfBorrowedBooks = noOfBorrowedBooks - 1 WHERE bookID = " + txtBookID.Text + "";
                string delete = "sp_BookIssue_DeleteRecord";
                string insertFine = "UPDATE Student SET fine = fine + '" + fine.ToString() + "'" +
                    "WHERE Student.studentID = '" + txtStudentID.Text + "'";

                SqlConnection connection = ConnectionManager.DBConnection();
                SqlCommand addCommand = new SqlCommand(addQuery, connection);
                SqlCommand updateCommand = new SqlCommand(update, connection);
                SqlCommand deleteCommand = new SqlCommand(delete, connection);
                SqlCommand addFineCommand = new SqlCommand(insertFine, connection);

                addCommand.CommandType = CommandType.StoredProcedure;
                addCommand.Parameters.AddWithValue("@bookID", txtBookID.Text);
                addCommand.Parameters.AddWithValue("@studentID", txtStudentID.Text);
                addCommand.Parameters.AddWithValue("@returnDate", dateTimePickerReturnDate.Value);
                addCommand.Parameters.AddWithValue("@librarianID", txtLibrarianID.Text);
                addCommand.Parameters.AddWithValue("@NewReturnID", SqlDbType.Int).Direction = ParameterDirection.Output;

                deleteCommand.CommandType = CommandType.StoredProcedure;
                deleteCommand.Parameters.AddWithValue("@issueID", txtIssueID.Text);

                connection.Open();

                addCommand.Transaction = connection.BeginTransaction();
                addCommand.ExecuteNonQuery();
                addCommand.Transaction.Commit();

                updateCommand.Transaction = connection.BeginTransaction();
                updateCommand.ExecuteNonQuery();
                updateCommand.Transaction.Commit();

                deleteCommand.Transaction = connection.BeginTransaction();
                deleteCommand.ExecuteNonQuery();
                deleteCommand.Transaction.Commit();

                addFineCommand.Transaction = connection.BeginTransaction();
                addFineCommand.ExecuteNonQuery();
                addFineCommand.Transaction.Commit();

                connection.Close();

                MessageBox.Show("Book returned successfully", "Book Returned", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SearchAgain();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful " + ex);
            }
        }



        //methods       
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
        public void DisplayInfo()
        {
            btnSearchAgain.Visible = true;
            btnSearchRecords.Visible = false;
            gbRecordInfo.Visible = true;
            lblDisplayName.Visible = true;
            lblDisplayTitle.Visible = true;
            lblDisplayDateIssued.Visible = true;
            btnReturn.Visible = true;
        }
        public void SearchAgain()
        {
            gbRecordInfo.Visible = false;
            lblDisplayName.Visible = false;
            lblDisplayTitle.Visible = false;
            lblDisplayDateIssued.Visible = false;
            btnReturn.Visible = false;
            btnSearchRecords.Visible = true;
            btnSearchAgain.Visible = false;
            txtStudentID.Clear();
            txtBookID.Clear();
            txtIssueID.Clear();
            txtLibrarianID.Clear();           
        }

        public double DaysBorrowed()
         {
             DateTime issued = DateTime.Parse(lblDisplayDateIssued.Text);
             DateTime returned = dateTimePickerReturnDate.Value;
             return (returned - issued).TotalDays;
         }

        public double CalculateFine()
        {
            if (DaysBorrowed() <= 7)
            {
                MessageBox.Show("Book returned before due date. Thank you");
                return 0;
            }
            else
            {
                double daysOverdue = DaysBorrowed() - 7;
                double fineDue = daysOverdue * 2;
                MessageBox.Show("Book is over due. You have been fined $" + fineDue, "Overdue Book", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return fineDue;
            }            
        }

        public void SetBookAvailable()
        {
            string setBookOne = "UPDATE Book SET noOfAvailableBooks = 10, noOfBorrowedBooks = 0 WHERE bookId = 1";
            string setBookTwo = "UPDATE Book SET noOfAvailableBooks = 10, noOfBorrowedBooks = 0 WHERE bookId = 2";
            string setBookThree = "UPDATE Book SET noOfAvailableBooks = 10, noOfBorrowedBooks = 0 WHERE bookId = 3";
            string setBookFour = "UPDATE Book SET noOfAvailableBooks = 10, noOfBorrowedBooks = 0 WHERE bookId = 4";

            SqlConnection connection = ConnectionManager.DBConnection();
            SqlCommand bookOne = new SqlCommand(setBookOne, connection);
            SqlCommand bookTwo = new SqlCommand(setBookTwo, connection);
            SqlCommand bookThree = new SqlCommand(setBookThree, connection);
            SqlCommand bookFour = new SqlCommand(setBookFour, connection);

            connection.Open();
            bookOne.Transaction = connection.BeginTransaction();
            bookOne.ExecuteNonQuery();
            bookOne.Transaction.Commit();

            bookTwo.Transaction = connection.BeginTransaction();
            bookTwo.ExecuteNonQuery();
            bookTwo.Transaction.Commit();

            bookThree.Transaction = connection.BeginTransaction();
            bookThree.ExecuteNonQuery();
            bookThree.Transaction.Commit();

            bookFour.Transaction = connection.BeginTransaction();
            bookFour.ExecuteNonQuery();
            bookFour.Transaction.Commit();

            connection.Close();

        }
       
    }
}
