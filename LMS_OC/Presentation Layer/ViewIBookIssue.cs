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
    public partial class frmViewIBookIssue : Form
    {
        public frmViewIBookIssue()
        {
            InitializeComponent();
        }

        public void Display()
        {
            string query = "SELECT * FROM BookIssue";
            dataGridView1.DataSource = ConnectionManager.GetTable(query);
        }

        private void ViewIBookIssue_Load(object sender, EventArgs e)
        {
            Display();
        }
    }
}
