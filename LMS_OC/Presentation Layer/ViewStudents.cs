using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_OC.Presentation_Layer
{
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();
        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        public void DisplayStudents()
        {           
            string selectQuery = "SELECT Student.StudentID AS \"Student ID\", Student.firstName AS \"First Name\", " +
                "Student.lastName AS \"Last Name\" FROM Student";

            dataGridViewStudents.DataSource = ConnectionManager.GetTable(selectQuery);
        }

       
    }
}
