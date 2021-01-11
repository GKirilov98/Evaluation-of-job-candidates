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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pOSITION_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pOSITIONSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pOSITIONSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicant_TrackingDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.SKILS' table. You can move, or remove it, as needed.
            this.sKILSTableAdapter.Fill(this.applicant_TrackingDataSet.SKILS);
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.POSITIONS' table. You can move, or remove it, as needed.
            this.pOSITIONSTableAdapter.Fill(this.applicant_TrackingDataSet.POSITIONS);

        }

        private void sKIL_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
