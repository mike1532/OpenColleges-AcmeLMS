using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LMS_OC.Data_Access_Layer;

namespace LMS_OC.Presentation_Layer
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }   
       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        //STUDENT MENU
        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            frmViewStudents viewStudents = new frmViewStudents();
            viewStudents.Show();
            viewStudents.MdiParent = this;

        }     

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();            
            AddStudentForm frm= new AddStudentForm();
            frm.Show();
            frm.MdiParent = this;
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            EditStudentForm frm = new EditStudentForm();
            frm.Show();
            frm.MdiParent = this;
        }


        //BOOK MENU
        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            AddBookForm frm = new AddBookForm();
            frm.Show();
            frm.MdiParent = this;
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            EditBookForm frm = new EditBookForm();
            frm.Show();
            frm.MdiParent = this;
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            frmViewBooks viewBooks = new frmViewBooks();
            viewBooks.Show();
            viewBooks.MdiParent = this;
        }

        private void searchBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmSearchBooks searchBooks = new frmSearchBooks();
            searchBooks.Show();
            searchBooks.MdiParent = this;
        }

        //EXIT 

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + "           " + System.Environment.GetEnvironmentVariable("librarianName") + " logged in.";            
        }

        //Librarian menu
        private void librarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            frmViewLibrarian viewLibrarian = new frmViewLibrarian();
            viewLibrarian.Show();
            viewLibrarian.MdiParent = this;
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmBorrowBook borrowBook = new frmBorrowBook();
            borrowBook.Show();
            borrowBook.MdiParent = this;
        }

        private void viewBookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmViewIBookIssue bookIssue = new frmViewIBookIssue();
            bookIssue.Show();
            bookIssue.MdiParent = this;
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmBookReturn bookReturn = new frmBookReturn();
            bookReturn.Show();
            bookReturn.MdiParent = this;
        }
    }
}
