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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pOSITIONSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pOSITIONSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicant_TrackingDataSet);

        }

        private void pOSITIONSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pOSITIONSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicant_TrackingDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.SKILS' table. You can move, or remove it, as needed.
            this.sKILSTableAdapter.Fill(this.applicant_TrackingDataSet.SKILS);
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.SKILS' table. You can move, or remove it, as needed.
            this.sKILSTableAdapter.Fill(this.applicant_TrackingDataSet.SKILS);
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.POSITIONS' table. You can move, or remove it, as needed.
            this.pOSITIONSTableAdapter.Fill(this.applicant_TrackingDataSet.POSITIONS);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
