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
            //Search by title
            if (rbTitle.Checked == true)
            {
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("Please enter a book title", "Enter Title", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    gbResults.Visible = false;
                    btnSearch.Visible = true;
                    return;
                }

                else
                {
                    GlobalVariable.bookSearchCriteria = "WHERE title LIKE '%" + txtSearch.Text + "%'";
                    btnSearch.Visible = false;
                    gbResults.Visible = true;
                    lvResults.Items.Clear();
                    DisplayResults();
                }                                
            }
            else if (rbAuthor.Checked == true)
            {

            }


        }

        private void btnSearchAgain_Click(object sender, EventArgs e)
        {
            gbResults.Visible = false;
            btnSearch.Visible = true;
            txtSearch.Clear();
            lvResults.Items.Clear();
        }


        public void DisplayResults()
        {
            string searchQuery = "SELECT Book.bookID, Author.authorName, Book.title, Book.ISBN, Book.rackNo," +
                "Book.noOfAvailableBooks, Book.noOfBorrowedBooks, Book.price, Book.librarianID FROM Book " +
                "INNER JOIN Author ON Book.authorID = Author.authorID";

           
            searchQuery = searchQuery + " " + GlobalVariable.bookSearchCriteria;

            SqlConnection connection = ConnectionManager.DBConnection();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(searchQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book(reader["ISBN"].ToString(), reader["title"].ToString(),
                            reader["authorName"].ToString(), double.Parse(reader["price"].ToString()), reader["rackNo"].ToString(),
                            int.Parse(reader["noOfAvailableBooks"].ToString()), int.Parse(reader["noOfBorrowedBooks"].ToString()),
                            int.Parse(reader["librarianID"].ToString()));

                    ListViewItem listView = new ListViewItem("");
                    listView.SubItems.Add(book.BookTitle);
                    listView.SubItems.Add(book.AuthourName);
                    listView.SubItems.Add(book.BookISBN);
                    listView.SubItems.Add(book.AvailableBooks.ToString());
                    listView.SubItems.Add(book.RackNumber);

                    lvResults.Items.Add(listView);
                }
                if (reader != null)
                    reader.Close();
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }
        }

        
    }      
}

