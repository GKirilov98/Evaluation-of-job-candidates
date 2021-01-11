namespace Proekt
{
    partial class Form8
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label pOSITION_IDLabel;
            System.Windows.Forms.Label pOSITION_NAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            System.Windows.Forms.Label aPPLICANT_AGELabel;
            System.Windows.Forms.Label aPPLICANT_IDLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pOSITION_IDTextBox = new System.Windows.Forms.TextBox();
            this.sKIL_MIN_ASSEMENTTextBox = new System.Windows.Forms.TextBox();
            this.applicant_TrackingDataSet = new Proekt.Applicant_TrackingDataSet();
            this.aPPLICANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPLICANTTableAdapter = new Proekt.Applicant_TrackingDataSetTableAdapters.APPLICANTTableAdapter();
            this.tableAdapterManager = new Proekt.Applicant_TrackingDataSetTableAdapters.TableAdapterManager();
            this.aPPLICANTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aPPLICANTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aPPLICANT_AGETextBox = new System.Windows.Forms.TextBox();
            this.aPPLICANT_IDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pOSITION_IDLabel = new System.Windows.Forms.Label();
            pOSITION_NAMELabel = new System.Windows.Forms.Label();
            aPPLICANT_AGELabel = new System.Windows.Forms.Label();
            aPPLICANT_IDLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTBindingNavigator)).BeginInit();
            this.aPPLICANTBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(aPPLICANT_IDLabel);
            this.groupBox2.Controls.Add(this.aPPLICANT_IDTextBox);
            this.groupBox2.Controls.Add(aPPLICANT_AGELabel);
            this.groupBox2.Controls.Add(this.aPPLICANT_AGETextBox);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.pOSITION_IDTextBox);
            this.groupBox2.Controls.Add(pOSITION_IDLabel);
            this.groupBox2.Controls.Add(pOSITION_NAMELabel);
            this.groupBox2.Controls.Add(this.sKIL_MIN_ASSEMENTTextBox);
            this.groupBox2.Location = new System.Drawing.Point(44, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 374);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Регистрация";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 224);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 17);
            label2.TabIndex = 16;
            label2.Text = "Фамилия";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 183);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 17);
            label1.TabIndex = 14;
            label1.Text = "Презиме";
            // 
            // pOSITION_IDTextBox
            // 
            this.pOSITION_IDTextBox.Location = new System.Drawing.Point(151, 92);
            this.pOSITION_IDTextBox.Name = "pOSITION_IDTextBox";
            this.pOSITION_IDTextBox.Size = new System.Drawing.Size(159, 22);
            this.pOSITION_IDTextBox.TabIndex = 8;
            // 
            // pOSITION_IDLabel
            // 
            pOSITION_IDLabel.AutoSize = true;
            pOSITION_IDLabel.Location = new System.Drawing.Point(22, 97);
            pOSITION_IDLabel.Name = "pOSITION_IDLabel";
            pOSITION_IDLabel.Size = new System.Drawing.Size(35, 17);
            pOSITION_IDLabel.TabIndex = 7;
            pOSITION_IDLabel.Text = "ЕГН";
            // 
            // pOSITION_NAMELabel
            // 
            pOSITION_NAMELabel.AutoSize = true;
            pOSITION_NAMELabel.Location = new System.Drawing.Point(22, 140);
            pOSITION_NAMELabel.Name = "pOSITION_NAMELabel";
            pOSITION_NAMELabel.Size = new System.Drawing.Size(35, 17);
            pOSITION_NAMELabel.TabIndex = 8;
            pOSITION_NAMELabel.Text = "Име";
            // 
            // sKIL_MIN_ASSEMENTTextBox
            // 
            this.sKIL_MIN_ASSEMENTTextBox.Location = new System.Drawing.Point(151, 135);
            this.sKIL_MIN_ASSEMENTTextBox.Name = "sKIL_MIN_ASSEMENTTextBox";
            this.sKIL_MIN_ASSEMENTTextBox.Size = new System.Drawing.Size(159, 22);
            this.sKIL_MIN_ASSEMENTTextBox.TabIndex = 13;
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
            this.aPPLICANTBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.aPPLICANTBindingNavigator.TabIndex = 21;
            this.aPPLICANTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // aPPLICANTBindingNavigatorSaveItem
            // 
            this.aPPLICANTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aPPLICANTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aPPLICANTBindingNavigatorSaveItem.Image")));
            this.aPPLICANTBindingNavigatorSaveItem.Name = "aPPLICANTBindingNavigatorSaveItem";
            this.aPPLICANTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aPPLICANTBindingNavigatorSaveItem.Text = "Save Data";
            this.aPPLICANTBindingNavigatorSaveItem.Click += new System.EventHandler(this.aPPLICANTBindingNavigatorSaveItem_Click);
            // 
            // aPPLICANT_AGELabel
            // 
            aPPLICANT_AGELabel.AutoSize = true;
            aPPLICANT_AGELabel.Location = new System.Drawing.Point(22, 265);
            aPPLICANT_AGELabel.Name = "aPPLICANT_AGELabel";
            aPPLICANT_AGELabel.Size = new System.Drawing.Size(63, 17);
            aPPLICANT_AGELabel.TabIndex = 17;
            aPPLICANT_AGELabel.Text = "Възраст";
            // 
            // aPPLICANT_AGETextBox
            // 
            this.aPPLICANT_AGETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPLICANTBindingSource, "APPLICANT_AGE", true));
            this.aPPLICANT_AGETextBox.Location = new System.Drawing.Point(151, 260);
            this.aPPLICANT_AGETextBox.Name = "aPPLICANT_AGETextBox";
            this.aPPLICANT_AGETextBox.Size = new System.Drawing.Size(159, 22);
            this.aPPLICANT_AGETextBox.TabIndex = 18;
            // 
            // aPPLICANT_IDLabel
            // 
            aPPLICANT_IDLabel.AutoSize = true;
            aPPLICANT_IDLabel.Location = new System.Drawing.Point(19, 54);
            aPPLICANT_IDLabel.Name = "aPPLICANT_IDLabel";
            aPPLICANT_IDLabel.Size = new System.Drawing.Size(119, 17);
            aPPLICANT_IDLabel.TabIndex = 18;
            aPPLICANT_IDLabel.Text = "Код на служител";
            // 
            // aPPLICANT_IDTextBox
            // 
            this.aPPLICANT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPLICANTBindingSource, "APPLICANT_ID", true));
            this.aPPLICANT_IDTextBox.Location = new System.Drawing.Point(151, 51);
            this.aPPLICANT_IDTextBox.Name = "aPPLICANT_IDTextBox";
            this.aPPLICANT_IDTextBox.Size = new System.Drawing.Size(159, 22);
            this.aPPLICANT_IDTextBox.TabIndex = 19;
            this.aPPLICANT_IDTextBox.TextChanged += new System.EventHandler(this.aPPLICANT_IDTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(539, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "Отказ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(648, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 24;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aPPLICANTBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form8";
            this.Text = " Регистрация на нов служител";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTBindingNavigator)).EndInit();
            this.aPPLICANTBindingNavigator.ResumeLayout(false);
            this.aPPLICANTBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox pOSITION_IDTextBox;
        private System.Windows.Forms.TextBox sKIL_MIN_ASSEMENTTextBox;
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
        private System.Windows.Forms.TextBox aPPLICANT_AGETextBox;
        private System.Windows.Forms.TextBox aPPLICANT_IDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}