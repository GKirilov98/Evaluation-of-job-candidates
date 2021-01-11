namespace Proekt
{
    partial class Form6
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
            System.Windows.Forms.Label aPPLICANT_EGNLabel;
            System.Windows.Forms.Label aPPLICANT_NAMELabel;
            System.Windows.Forms.Label aPPLICANT_SURNAMELabel;
            System.Windows.Forms.Label aPPLICANT_LASTNAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button3 = new System.Windows.Forms.Button();
            this.applicant_TrackingDataSet = new Proekt.Applicant_TrackingDataSet();
            this.aPPLICANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPLICANTTableAdapter = new Proekt.Applicant_TrackingDataSetTableAdapters.APPLICANTTableAdapter();
            this.tableAdapterManager = new Proekt.Applicant_TrackingDataSetTableAdapters.TableAdapterManager();
            this.aPPLICANTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aPPLICANTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aPPLICANT_LASTNAMETextBox = new System.Windows.Forms.TextBox();
            this.aPPLICANT_SURNAMETextBox = new System.Windows.Forms.TextBox();
            this.aPPLICANT_NAMETextBox = new System.Windows.Forms.TextBox();
            this.aPPLICANT_EGNTextBox = new System.Windows.Forms.TextBox();
            this.aPPLICANTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aPPLICANT_EGNLabel = new System.Windows.Forms.Label();
            aPPLICANT_NAMELabel = new System.Windows.Forms.Label();
            aPPLICANT_SURNAMELabel = new System.Windows.Forms.Label();
            aPPLICANT_LASTNAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTBindingNavigator)).BeginInit();
            this.aPPLICANTBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aPPLICANT_EGNLabel
            // 
            aPPLICANT_EGNLabel.AutoSize = true;
            aPPLICANT_EGNLabel.Location = new System.Drawing.Point(21, 46);
            aPPLICANT_EGNLabel.Name = "aPPLICANT_EGNLabel";
            aPPLICANT_EGNLabel.Size = new System.Drawing.Size(39, 17);
            aPPLICANT_EGNLabel.TabIndex = 0;
            aPPLICANT_EGNLabel.Text = "ЕГН:";
            // 
            // aPPLICANT_NAMELabel
            // 
            aPPLICANT_NAMELabel.AutoSize = true;
            aPPLICANT_NAMELabel.Location = new System.Drawing.Point(22, 91);
            aPPLICANT_NAMELabel.Name = "aPPLICANT_NAMELabel";
            aPPLICANT_NAMELabel.Size = new System.Drawing.Size(39, 17);
            aPPLICANT_NAMELabel.TabIndex = 2;
            aPPLICANT_NAMELabel.Text = "Име:";
            // 
            // aPPLICANT_SURNAMELabel
            // 
            aPPLICANT_SURNAMELabel.AutoSize = true;
            aPPLICANT_SURNAMELabel.Location = new System.Drawing.Point(25, 133);
            aPPLICANT_SURNAMELabel.Name = "aPPLICANT_SURNAMELabel";
            aPPLICANT_SURNAMELabel.Size = new System.Drawing.Size(70, 17);
            aPPLICANT_SURNAMELabel.TabIndex = 4;
            aPPLICANT_SURNAMELabel.Text = "Презиме:";
            // 
            // aPPLICANT_LASTNAMELabel
            // 
            aPPLICANT_LASTNAMELabel.AutoSize = true;
            aPPLICANT_LASTNAMELabel.Location = new System.Drawing.Point(23, 175);
            aPPLICANT_LASTNAMELabel.Name = "aPPLICANT_LASTNAMELabel";
            aPPLICANT_LASTNAMELabel.Size = new System.Drawing.Size(74, 17);
            aPPLICANT_LASTNAMELabel.TabIndex = 6;
            aPPLICANT_LASTNAMELabel.Text = "Фамилия:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(173, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Търсене ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // applicant_TrackingDataSet
            // 
            this.applicant_TrackingDataSet.DataSetName = "Applicant_TrackingDataSet";
            this.applicant_TrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPLICANTBindingSource
            // 
            this.aPPLICANTBindingSource.DataMember = "APPLICANT";
            this.aPPLICANTBindingSource.DataSource = this.applicant_TrackingDataSet;
            // 
            // aPPLICANTTableAdapter
            // 
            this.aPPLICANTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APPLICANTTableAdapter = this.aPPLICANTTableAdapter;
            this.tableAdapterManager.APPRAISERTableAdapter = null;
            this.tableAdapterManager.ASSESMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLOYEESTableAdapter = null;
            this.tableAdapterManager.INTERVIEWTableAdapter = null;
            this.tableAdapterManager.POSITIONSTableAdapter = null;
            this.tableAdapterManager.SKILSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proekt.Applicant_TrackingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aPPLICANTBindingNavigator
            // 
            this.aPPLICANTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aPPLICANTBindingNavigator.BindingSource = this.aPPLICANTBindingSource;
            this.aPPLICANTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aPPLICANTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aPPLICANTBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aPPLICANTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aPPLICANTBindingNavigatorSaveItem});
            this.aPPLICANTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aPPLICANTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aPPLICANTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aPPLICANTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aPPLICANTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aPPLICANTBindingNavigator.Name = "aPPLICANTBindingNavigator";
            this.aPPLICANTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aPPLICANTBindingNavigator.Size = new System.Drawing.Size(808, 27);
            this.aPPLICANTBindingNavigator.TabIndex = 6;
            this.aPPLICANTBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // aPPLICANTBindingNavigatorSaveItem
            // 
            this.aPPLICANTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aPPLICANTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aPPLICANTBindingNavigatorSaveItem.Image")));
            this.aPPLICANTBindingNavigatorSaveItem.Name = "aPPLICANTBindingNavigatorSaveItem";
            this.aPPLICANTBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.aPPLICANTBindingNavigatorSaveItem.Text = "Save Data";
            this.aPPLICANTBindingNavigatorSaveItem.Click += new System.EventHandler(this.aPPLICANTBindingNavigatorSaveItem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(aPPLICANT_LASTNAMELabel);
            this.groupBox1.Controls.Add(this.aPPLICANT_LASTNAMETextBox);
            this.groupBox1.Controls.Add(aPPLICANT_SURNAMELabel);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.aPPLICANT_SURNAMETextBox);
            this.groupBox1.Controls.Add(aPPLICANT_NAMELabel);
            this.groupBox1.Controls.Add(this.aPPLICANT_NAMETextBox);
            this.groupBox1.Controls.Add(aPPLICANT_EGNLabel);
            this.groupBox1.Controls.Add(this.aPPLICANT_EGNTextBox);
            this.groupBox1.Location = new System.Drawing.Point(36, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 321);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Търсене";
            // 
            // aPPLICANT_LASTNAMETextBox
            // 
            this.aPPLICANT_LASTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPLICANTBindingSource, "APPLICANT_LASTNAME", true));
            this.aPPLICANT_LASTNAMETextBox.Location = new System.Drawing.Point(133, 175);
            this.aPPLICANT_LASTNAMETextBox.Name = "aPPLICANT_LASTNAMETextBox";
            this.aPPLICANT_LASTNAMETextBox.Size = new System.Drawing.Size(135, 22);
            this.aPPLICANT_LASTNAMETextBox.TabIndex = 7;
            // 
            // aPPLICANT_SURNAMETextBox
            // 
            this.aPPLICANT_SURNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPLICANTBindingSource, "APPLICANT_SURNAME", true));
            this.aPPLICANT_SURNAMETextBox.Location = new System.Drawing.Point(133, 133);
            this.aPPLICANT_SURNAMETextBox.Name = "aPPLICANT_SURNAMETextBox";
            this.aPPLICANT_SURNAMETextBox.Size = new System.Drawing.Size(135, 22);
            this.aPPLICANT_SURNAMETextBox.TabIndex = 5;
            // 
            // aPPLICANT_NAMETextBox
            // 
            this.aPPLICANT_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPLICANTBindingSource, "APPLICANT_NAME", true));
            this.aPPLICANT_NAMETextBox.Location = new System.Drawing.Point(133, 91);
            this.aPPLICANT_NAMETextBox.Name = "aPPLICANT_NAMETextBox";
            this.aPPLICANT_NAMETextBox.Size = new System.Drawing.Size(135, 22);
            this.aPPLICANT_NAMETextBox.TabIndex = 3;
            // 
            // aPPLICANT_EGNTextBox
            // 
            this.aPPLICANT_EGNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPLICANTBindingSource, "APPLICANT_EGN", true));
            this.aPPLICANT_EGNTextBox.Location = new System.Drawing.Point(133, 46);
            this.aPPLICANT_EGNTextBox.Name = "aPPLICANT_EGNTextBox";
            this.aPPLICANT_EGNTextBox.Size = new System.Drawing.Size(135, 22);
            this.aPPLICANT_EGNTextBox.TabIndex = 1;
            // 
            // aPPLICANTDataGridView
            // 
            this.aPPLICANTDataGridView.AutoGenerateColumns = false;
            this.aPPLICANTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aPPLICANTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.aPPLICANTDataGridView.DataSource = this.aPPLICANTBindingSource;
            this.aPPLICANTDataGridView.Location = new System.Drawing.Point(347, 78);
            this.aPPLICANTDataGridView.Name = "aPPLICANTDataGridView";
            this.aPPLICANTDataGridView.RowHeadersWidth = 51;
            this.aPPLICANTDataGridView.RowTemplate.Height = 24;
            this.aPPLICANTDataGridView.Size = new System.Drawing.Size(449, 220);
            this.aPPLICANTDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "APPLICANT_EGN";
            this.dataGridViewTextBoxColumn2.HeaderText = "APPLICANT_EGN";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "APPLICANT_NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "APPLICANT_NAME";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "APPLICANT_SURNAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "APPLICANT_SURNAME";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "APPLICANT_LASTNAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "APPLICANT_LASTNAME";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.aPPLICANTDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aPPLICANTBindingNavigator);
            this.Name = "Form6";
            this.Text = "Търсене на служител";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTBindingNavigator)).EndInit();
            this.aPPLICANTBindingNavigator.ResumeLayout(false);
            this.aPPLICANTBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private Applicant_TrackingDataSet applicant_TrackingDataSet;
        private System.Windows.Forms.BindingSource aPPLICANTBindingSource;
        private Applicant_TrackingDataSetTableAdapters.APPLICANTTableAdapter aPPLICANTTableAdapter;
        private Applicant_TrackingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aPPLICANTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aPPLICANTBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox aPPLICANT_LASTNAMETextBox;
        private System.Windows.Forms.TextBox aPPLICANT_SURNAMETextBox;
        private System.Windows.Forms.TextBox aPPLICANT_NAMETextBox;
        private System.Windows.Forms.TextBox aPPLICANT_EGNTextBox;
        private System.Windows.Forms.DataGridView aPPLICANTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}