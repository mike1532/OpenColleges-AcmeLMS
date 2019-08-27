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

namespace LMS_OC.Presentation_Layer
{
    public partial class frmViewLibrarian : Form
    {
        public frmViewLibrarian()
        {
            InitializeComponent();
        }

        private void frmViewLibrarian_Load(object sender, EventArgs e)
        {
            DisplayLibrarian();
        }

        public void DisplayLibrarian()
        {
            string selectQuery = "SELECT * FROM Librarian";
            dataGridViewLibrarian.DataSource = ConnectionManager.GetTable(selectQuery);
        }        
    }
}
