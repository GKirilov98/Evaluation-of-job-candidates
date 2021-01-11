namespace Proekt
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.applicant_TrackingDataSet = new Proekt.Applicant_TrackingDataSet();
            this.sKILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKILSTableAdapter = new Proekt.Applicant_TrackingDataSetTableAdapters.SKILSTableAdapter();
            this.tableAdapterManager = new Proekt.Applicant_TrackingDataSetTableAdapters.TableAdapterManager();
            this.sKILSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sKILSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pOSITIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSITIONSTableAdapter = new Proekt.Applicant_TrackingDataSetTableAdapters.POSITIONSTableAdapter();
            this.pOSITION_NAMETextBox = new System.Windows.Forms.TextBox();
            this.iNTERVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNTERVIEWTableAdapter = new Proekt.Applicant_TrackingDataSetTableAdapters.INTERVIEWTableAdapter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKILSBindingNavigator)).BeginInit();
            this.sKILSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNTERVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Брой кандидати:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име на дължност:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Средна оценка от интервютата:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.pOSITION_NAMETextBox);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 233);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация за кандидатите";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(754, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Край на прегледа";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // applicant_TrackingDataSet
            // 
            this.applicant_TrackingDataSet.DataSetName = "Applicant_TrackingDataSet";
            this.applicant_TrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sKILSBindingSource
            // 
            this.sKILSBindingSource.DataMember = "SKILS";
            this.sKILSBindingSource.DataSource = this.applicant_TrackingDataSet;
            // 
            // sKILSTableAdapter
            // 
            this.sKILSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APPLICANTTableAdapter = null;
            this.tableAdapterManager.APPRAISERTableAdapter = null;
            this.tableAdapterManager.ASSESMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLOYEESTableAdapter = null;
            this.tableAdapterManager.INTERVIEWTableAdapter = this.iNTERVIEWTableAdapter;
            this.tableAdapterManager.POSITIONSTableAdapter = this.pOSITIONSTableAdapter;
            this.tableAdapterManager.SKILSTableAdapter = this.sKILSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proekt.Applicant_TrackingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sKILSBindingNavigator
            // 
            this.sKILSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sKILSBindingNavigator.BindingSource = this.sKILSBindingSource;
            this.sKILSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sKILSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sKILSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sKILSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sKILSBindingNavigatorSaveItem});
            this.sKILSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sKILSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sKILSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sKILSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sKILSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sKILSBindingNavigator.Name = "sKILSBindingNavigator";
            this.sKILSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sKILSBindingNavigator.Size = new System.Drawing.Size(842, 27);
            this.sKILSBindingNavigator.TabIndex = 6;
            this.sKILSBindingNavigator.Text = "bindingNavigator1";
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
            // sKILSBindingNavigatorSaveItem
            // 
            this.sKILSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sKILSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sKILSBindingNavigatorSaveItem.Image")));
            this.sKILSBindingNavigatorSaveItem.Name = "sKILSBindingNavigatorSaveItem";
            this.sKILSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.sKILSBindingNavigatorSaveItem.Text = "Save Data";
            this.sKILSBindingNavigatorSaveItem.Click += new System.EventHandler(this.sKILSBindingNavigatorSaveItem_Click);
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
            // pOSITION_NAMETextBox
            // 
            this.pOSITION_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOSITIONSBindingSource, "POSITION_NAME", true));
            this.pOSITION_NAMETextBox.Location = new System.Drawing.Point(214, 46);
            this.pOSITION_NAMETextBox.Name = "pOSITION_NAMETextBox";
            this.pOSITION_NAMETextBox.Size = new System.Drawing.Size(148, 22);
            this.pOSITION_NAMETextBox.TabIndex = 7;
            // 
            // iNTERVIEWBindingSource
            // 
            this.iNTERVIEWBindingSource.DataMember = "INTERVIEW";
            this.iNTERVIEWBindingSource.DataSource = this.applicant_TrackingDataSet;
            // 
            // iNTERVIEWTableAdapter
            // 
            this.iNTERVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNTERVIEWBindingSource, "INTERVIEW_ASSESMENT", true));
            this.textBox4.Location = new System.Drawing.Point(244, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 22);
            this.textBox4.TabIndex = 10;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.sKILSBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.Text = "Дължност детайли";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKILSBindingNavigator)).EndInit();
            this.sKILSBindingNavigator.ResumeLayout(false);
            this.sKILSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNTERVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private Applicant_TrackingDataSet applicant_TrackingDataSet;
        private System.Windows.Forms.BindingSource sKILSBindingSource;
        private Applicant_TrackingDataSetTableAdapters.SKILSTableAdapter sKILSTableAdapter;
        private Applicant_TrackingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sKILSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sKILSBindingNavigatorSaveItem;
        private Applicant_TrackingDataSetTableAdapters.POSITIONSTableAdapter pOSITIONSTableAdapter;
        private System.Windows.Forms.BindingSource pOSITIONSBindingSource;
        private Applicant_TrackingDataSetTableAdapters.INTERVIEWTableAdapter iNTERVIEWTableAdapter;
        private System.Windows.Forms.TextBox pOSITION_NAMETextBox;
        private System.Windows.Forms.BindingSource iNTERVIEWBindingSource;
        private System.Windows.Forms.TextBox textBox4;
    }
}