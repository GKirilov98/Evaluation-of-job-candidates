namespace Proekt
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            System.Windows.Forms.Label pOSITION_IDLabel;
            System.Windows.Forms.Label label1;
            this.applicant_TrackingDataSet = new Proekt.Applicant_TrackingDataSet();
            this.pOSITIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSITIONSTableAdapter = new Proekt.Applicant_TrackingDataSetTableAdapters.POSITIONSTableAdapter();
            this.tableAdapterManager = new Proekt.Applicant_TrackingDataSetTableAdapters.TableAdapterManager();
            this.pOSITIONSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pOSITIONSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button3 = new System.Windows.Forms.Button();
            this.pOSITIONSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pOSITION_IDTextBox = new System.Windows.Forms.TextBox();
            this.pOSITION_NAMETextBox = new System.Windows.Forms.TextBox();
            pOSITION_IDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingNavigator)).BeginInit();
            this.pOSITIONSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicant_TrackingDataSet
            // 
            this.applicant_TrackingDataSet.DataSetName = "Applicant_TrackingDataSet";
            this.applicant_TrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOSITIONSBindingSource
            // 
            this.pOSITIONSBindingSource.DataMember = "POSITIONS";
            this.pOSITIONSBindingSource.DataSource = this.applicant_TrackingDataSet;
            // 
            // pOSITIONSTableAdapter
            // 
            this.pOSITIONSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APPLICANTTableAdapter = null;
            this.tableAdapterManager.APPRAISERTableAdapter = null;
            this.tableAdapterManager.ASSESMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLOYEESTableAdapter = null;
            this.tableAdapterManager.INTERVIEWTableAdapter = null;
            this.tableAdapterManager.POSITIONSTableAdapter = this.pOSITIONSTableAdapter;
            this.tableAdapterManager.SKILSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proekt.Applicant_TrackingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pOSITIONSBindingNavigator
            // 
            this.pOSITIONSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pOSITIONSBindingNavigator.BindingSource = this.pOSITIONSBindingSource;
            this.pOSITIONSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pOSITIONSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pOSITIONSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pOSITIONSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pOSITIONSBindingNavigatorSaveItem});
            this.pOSITIONSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pOSITIONSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pOSITIONSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pOSITIONSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pOSITIONSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pOSITIONSBindingNavigator.Name = "pOSITIONSBindingNavigator";
            this.pOSITIONSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pOSITIONSBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.pOSITIONSBindingNavigator.TabIndex = 0;
            this.pOSITIONSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pOSITIONSBindingNavigatorSaveItem
            // 
            this.pOSITIONSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pOSITIONSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pOSITIONSBindingNavigatorSaveItem.Image")));
            this.pOSITIONSBindingNavigatorSaveItem.Name = "pOSITIONSBindingNavigatorSaveItem";
            this.pOSITIONSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pOSITIONSBindingNavigatorSaveItem.Text = "Save Data";
            this.pOSITIONSBindingNavigatorSaveItem.Click += new System.EventHandler(this.pOSITIONSBindingNavigatorSaveItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(268, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "Търсене ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pOSITIONSDataGridView
            // 
            this.pOSITIONSDataGridView.AutoGenerateColumns = false;
            this.pOSITIONSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pOSITIONSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.pOSITIONSDataGridView.DataSource = this.pOSITIONSBindingSource;
            this.pOSITIONSDataGridView.Location = new System.Drawing.Point(460, 101);
            this.pOSITIONSDataGridView.Name = "pOSITIONSDataGridView";
            this.pOSITIONSDataGridView.RowHeadersWidth = 51;
            this.pOSITIONSDataGridView.RowTemplate.Height = 24;
            this.pOSITIONSDataGridView.Size = new System.Drawing.Size(300, 220);
            this.pOSITIONSDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "POSITION_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "POSITION_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "POSITION_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "POSITION_NAME";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.pOSITION_IDTextBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(pOSITION_IDLabel);
            this.groupBox1.Controls.Add(this.pOSITION_NAMETextBox);
            this.groupBox1.Location = new System.Drawing.Point(32, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 254);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Търсене";
            // 
            // pOSITION_IDTextBox
            // 
            this.pOSITION_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOSITIONSBindingSource, "POSITION_ID", true));
            this.pOSITION_IDTextBox.Location = new System.Drawing.Point(222, 38);
            this.pOSITION_IDTextBox.Name = "pOSITION_IDTextBox";
            this.pOSITION_IDTextBox.Size = new System.Drawing.Size(132, 22);
            this.pOSITION_IDTextBox.TabIndex = 9;
            // 
            // pOSITION_IDLabel
            // 
            pOSITION_IDLabel.AutoSize = true;
            pOSITION_IDLabel.Location = new System.Drawing.Point(18, 41);
            pOSITION_IDLabel.Name = "pOSITION_IDLabel";
            pOSITION_IDLabel.Size = new System.Drawing.Size(125, 17);
            pOSITION_IDLabel.TabIndex = 8;
            pOSITION_IDLabel.Text = "Код на дължност:";
            // 
            // pOSITION_NAMETextBox
            // 
            this.pOSITION_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOSITIONSBindingSource, "POSITION_NAME", true));
            this.pOSITION_NAMETextBox.Location = new System.Drawing.Point(222, 100);
            this.pOSITION_NAMETextBox.Name = "pOSITION_NAMETextBox";
            this.pOSITION_NAMETextBox.Size = new System.Drawing.Size(132, 22);
            this.pOSITION_NAMETextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 103);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(198, 17);
            label1.TabIndex = 12;
            label1.Text = "Наименование на длъжност:";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pOSITIONSDataGridView);
            this.Controls.Add(this.pOSITIONSBindingNavigator);
            this.Name = "Form10";
            this.Text = " Списък с длъжности";
            this.Load += new System.EventHandler(this.Form10_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingNavigator)).EndInit();
            this.pOSITIONSBindingNavigator.ResumeLayout(false);
            this.pOSITIONSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applicant_TrackingDataSet applicant_TrackingDataSet;
        private System.Windows.Forms.BindingSource pOSITIONSBindingSource;
        private Applicant_TrackingDataSetTableAdapters.POSITIONSTableAdapter pOSITIONSTableAdapter;
        private Applicant_TrackingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pOSITIONSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pOSITIONSBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView pOSITIONSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pOSITION_IDTextBox;
        private System.Windows.Forms.TextBox pOSITION_NAMETextBox;
    }
}