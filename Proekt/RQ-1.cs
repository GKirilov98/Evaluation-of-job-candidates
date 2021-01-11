using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void aPPLICANTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPPLICANTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicant_TrackingDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.APPLICANT' table. You can move, or remove it, as needed.
            this.aPPLICANTTableAdapter.Fill(this.applicant_TrackingDataSet.APPLICANT);

        }

        private void aPPLICANTBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.aPPLICANTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicant_TrackingDataSet);

        }

        private void aPPLICANTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           

        }
    }
}
