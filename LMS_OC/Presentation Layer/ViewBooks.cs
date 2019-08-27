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
    public partial class frmViewBooks : Form
    {
        public frmViewBooks()
        {
            InitializeComponent();
        }

        private void frmViewBooks_Load(object sender, EventArgs e)
        {
            DisplayBook();
        }

        public void DisplayBook()
        {
            string selectQuery = "SELECT * FROM Book";
            dataGridViewBooks.DataSource = ConnectionManager.GetTable(selectQuery);
        }
    }
}
