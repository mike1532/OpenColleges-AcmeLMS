using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using LMS_OC.Data_Access_Layer;

namespace LMS_OC.Business_Logic_Layer
{
    class Book
    {
        private int bookID;
        private string ISBN;
        private string title;
        private string authorName;
        private int authorID;
        private double price;
        private string rackNo;
        private int availableBooks;
        private int borrowedBooks;
        private int librarianID;

        //constructors
        public Book() { }
        public Book(string isbn, string name, string authName, double cost, string rNo, int availBooks, int bBooks, int lID)
        {
            ISBN = isbn;
            title = name;
            authorName = authName;
            price = cost;
            rackNo = rNo;
            availableBooks = availBooks;
            borrowedBooks = bBooks;
            librarianID = lID;
        }
        public Book(string isbn, string name, int authorID, double cost, string rNo, int avilbooks, int bBooks,int lID)
        {
            //this.bookID = bID;
            this.ISBN = isbn;
            this.title = name;
            this.authorID = authorID;
            this.price = cost;
            this.rackNo = rNo;
            this.availableBooks = avilbooks;
            this.borrowedBooks = bBooks;
            this.librarianID = lID;
        }
        

        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }
        public string BookISBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
        public string BookTitle
        {
            get { return title; }
            set { title = value; }
        }
        public int BookAuthor
        {
            get { return authorID; }
            set { authorID = value; }
        }
        public double BookPrice
        {
            get { return price; }
            set { price = value; }
        }
        public string RackNumber
        {
            get { return rackNo; }
            set { rackNo = value; }
        }
        public int AvailableBooks
        {
            get { return availableBooks; }
            set { availableBooks = value; }
        }
        public int BorrowedBooks
        {
            get { return borrowedBooks; }
            set { borrowedBooks = value; }
        }
        public string AuthourName
        {
            get { return authorName; }
            set { authorName = value; }
        }
        public int LibrarianID
        {
            get { return librarianID; }
            set { librarianID = value; }
        }

        
       public int AddNewBook()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Book (title,authorID,price,rackNo,noOfAvailableBooks,noOfBorrowedBooks,librarianID,ISBN) values('" + title + "'," + authorID + "," + price + ",'" + rackNo + "'," + availableBooks + "," + borrowedBooks + "," + librarianID + ",'" + ISBN + "')";
            cmd.Connection = con;
            con.Open();
            int recordInserted= cmd.ExecuteNonQuery();
            con.Close();
            return recordInserted;
        }
        public int EditBook()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Book set title='"+title+"' ,authorID ="+authorID+",price="+price+",rackNo='"+rackNo+"',noOfAvailableBooks="+availableBooks+",librarianID="+librarianID+",ISBN='"+ISBN +"' where bookID="+bookID +"";
            cmd.Connection = con;
            con.Open();
            int recordUpdated = cmd.ExecuteNonQuery();
            con.Close();
            return recordUpdated;
        }
        public int updateBookQtyOnIssue()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Book set noOfAvailableBooks=noOfAvailableBooks-1, noOfBorrowedBooks=noOfBorrowedBooks+1 where bookID=" + bookID + "";
            cmd.Connection = con;
            con.Open();
            int recordUpdated = cmd.ExecuteNonQuery();
            con.Close();
            return recordUpdated;
        }
        public int updateBookQtyOnReturn()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Book set noOfAvailableBooks=noOfAvailableBooks+1, noOfBorrowedBooks=noOfBorrowedBooks-1 where bookID=" + bookID + "";
            cmd.Connection = con;
            con.Open();
            int recordUpdated = cmd.ExecuteNonQuery();
            con.Close();
            return recordUpdated;
        }

    }
}
