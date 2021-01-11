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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void sKILSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sKILSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicant_TrackingDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.INTERVIEW' table. You can move, or remove it, as needed.
            this.iNTERVIEWTableAdapter.Fill(this.applicant_TrackingDataSet.INTERVIEW);
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.POSITIONS' table. You can move, or remove it, as needed.
            this.pOSITIONSTableAdapter.Fill(this.applicant_TrackingDataSet.POSITIONS);
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.SKILS' table. You can move, or remove it, as needed.
            this.sKILSTableAdapter.Fill(this.applicant_TrackingDataSet.SKILS);

        }
    }
}
