//DO NOT REMOVE THIS FORM//
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
    public partial class frmViewBookReturn : Form
    {
        public frmViewBookReturn()
        {
            InitializeComponent();
        }
        //events
        private void frmViewBookReturn_Load(object sender, EventArgs e)
        {
            lvBookReturn.Items.Clear();
            DisplayBooks();            
        }

        //methods
        public void DisplayBooks()
        {            
            string selectQuery = "SELECT BookIssue.issueID, Book.bookID, Book.title, Student.studentID, " +
                                 "Student.firstName, Student.lastName, BookIssue.issueDate, " +
                                 "BookIssue.returnDate, Librarian.librarianID FROM BookIssue " +
                                 "INNER JOIN Book ON BookIssue.bookID = Book.bookID " +
                                 "INNER JOIN Student ON BookIssue.studentID = Student.studentID " +
                                 "INNER JOIN Librarian ON BookIssue.librarianID = Librarian.librarianID";           
            SqlConnection connection = ConnectionManager.DBConnection();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    ListViewItem listView = new ListViewItem("");
                    listView.SubItems.Add(reader["issueID"].ToString());
                    listView.SubItems.Add(reader["bookID"].ToString());
                    listView.SubItems.Add(reader["title"].ToString());
                    listView.SubItems.Add(reader["studentID"].ToString());
                    listView.SubItems.Add(reader["firstName"].ToString() + " " + reader["lastName"].ToString());

                    string issueDate = reader["issueDate"].ToString();
                    DateTime issued = DateTime.Parse(issueDate);
                    listView.SubItems.Add(issued.ToString("ddd d MMM yyyy"));

                    string returnDate = reader["returnDate"].ToString();
                    DateTime returned = DateTime.Parse(returnDate);
                    listView.SubItems.Add(returned.ToString("ddd d MMM yyyy"));

                    lvBookReturn.Items.Add(listView);                             
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvBookReturn.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a book to return", "Return Book",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GlobalVariable.selectedIssueID = int.Parse(lvBookReturn.SelectedItems[0].SubItems[1].Text);
                       
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmBookReturn bookReturn = new frmBookReturn() { MdiParent = MdiParent };
            bookReturn.Show();
            //bookReturn.MdiParent = this;
           
        }
    }     
}
