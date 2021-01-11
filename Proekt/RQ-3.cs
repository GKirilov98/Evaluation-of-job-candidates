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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void aPPLICANTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPPLICANTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicant_TrackingDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.APPLICANT' table. You can move, or remove it, as needed.
            this.aPPLICANTTableAdapter.Fill(this.applicant_TrackingDataSet.APPLICANT);

        }

        private void aPPLICANT_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
