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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void iNTERVIEWBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iNTERVIEWBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicant_TrackingDataSet);

        }

        private void iNTERVIEWBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.iNTERVIEWBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicant_TrackingDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.APPRAISER' table. You can move, or remove it, as needed.
            this.aPPRAISERTableAdapter.Fill(this.applicant_TrackingDataSet.APPRAISER);
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.APPLICANT' table. You can move, or remove it, as needed.
            this.aPPLICANTTableAdapter.Fill(this.applicant_TrackingDataSet.APPLICANT);
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.INTERVIEW' table. You can move, or remove it, as needed.
            this.iNTERVIEWTableAdapter.Fill(this.applicant_TrackingDataSet.INTERVIEW);

        }

        private void aPPLICANT_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
