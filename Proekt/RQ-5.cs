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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void Form10_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicant_TrackingDataSet.POSITIONS' table. You can move, or remove it, as needed.
            this.pOSITIONSTableAdapter.Fill(this.applicant_TrackingDataSet.POSITIONS);

        }

        private void pOSITIONSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pOSITIONSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicant_TrackingDataSet);

        }
    }
}
