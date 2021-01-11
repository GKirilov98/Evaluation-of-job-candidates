namespace Proekt
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            System.Windows.Forms.Label iNTERVIEW_DATELabel1;
            System.Windows.Forms.Label aPPRAISER_ASSESSMENTLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.applicant_TrackingDataSet = new Proekt.Applicant_TrackingDataSet();
            this.iNTERVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNTERVIEWTableAdapter = new Proekt.Applicant_TrackingDataSetTableAdapters.INTERVIEWTableAdapter();
            this.tableAdapterManager = new Proekt.Applicant_TrackingDataSetTableAdapters.TableAdapterManager();
            this.iNTERVIEWBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iNTERVIEWBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iNTERVIEW_DATEDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aPPLICANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPLICANTTableAdapter = new Proekt.Applicant_TrackingDataSetTableAdapters.APPLICANTTableAdapter();
            this.aPPRAISERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPRAISERTableAdapter = new Proekt.Applicant_TrackingDataSetTableAdapters.APPRAISERTableAdapter();
            this.aPPRAISER_ASSESSMENTTextBox = new System.Windows.Forms.TextBox();
            iNTERVIEW_DATELabel1 = new System.Windows.Forms.Label();
            aPPRAISER_ASSESSMENTLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNTERVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNTERVIEWBindingNavigator)).BeginInit();
            this.iNTERVIEWBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPRAISERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aPPRAISER_ASSESSMENTTextBox);
            this.groupBox2.Controls.Add(aPPRAISER_ASSESSMENTLabel);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(iNTERVIEW_DATELabel1);
            this.groupBox2.Controls.Add(this.iNTERVIEW_DATEDateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(52, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 274);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Детайли";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(682, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 62);
            this.button1.TabIndex = 21;
            this.button1.Text = "Край на прегледа";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // applicant_TrackingDataSet
            // 
            this.applicant_TrackingDataSet.DataSetName = "Applicant_TrackingDataSet";
            this.applicant_TrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.APPLICANTTableAdapter = this.aPPLICANTTableAdapter;
            this.tableAdapterManager.APPRAISERTableAdapter = this.aPPRAISERTableAdapter;
            this.tableAdapterManager.ASSESMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLOYEESTableAdapter = null;
            this.tableAdapterManager.INTERVIEWTableAdapter = this.iNTERVIEWTableAdapter;
            this.tableAdapterManager.POSITIONSTableAdapter = null;
            this.tableAdapterManager.SKILSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proekt.Applicant_TrackingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iNTERVIEWBindingNavigator
            // 
            this.iNTERVIEWBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iNTERVIEWBindingNavigator.BindingSource = this.iNTERVIEWBindingSource;
            this.iNTERVIEWBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iNTERVIEWBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iNTERVIEWBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iNTERVIEWBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iNTERVIEWBindingNavigatorSaveItem});
            this.iNTERVIEWBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iNTERVIEWBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iNTERVIEWBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iNTERVIEWBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iNTERVIEWBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iNTERVIEWBindingNavigator.Name = "iNTERVIEWBindingNavigator";
            this.iNTERVIEWBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iNTERVIEWBindingNavigator.Size = new System.Drawing.Size(804, 27);
            this.iNTERVIEWBindingNavigator.TabIndex = 22;
            this.iNTERVIEWBindingNavigator.Text = "bindingNavigator1";
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
            // iNTERVIEWBindingNavigatorSaveItem
            // 
            this.iNTERVIEWBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iNTERVIEWBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iNTERVIEWBindingNavigatorSaveItem.Image")));
            this.iNTERVIEWBindingNavigatorSaveItem.Name = "iNTERVIEWBindingNavigatorSaveItem";
            this.iNTERVIEWBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.iNTERVIEWBindingNavigatorSaveItem.Text = "Save Data";
            this.iNTERVIEWBindingNavigatorSaveItem.Click += new System.EventHandler(this.iNTERVIEWBindingNavigatorSaveItem_Click_1);
            // 
            // iNTERVIEW_DATELabel1
            // 
            iNTERVIEW_DATELabel1.AutoSize = true;
            iNTERVIEW_DATELabel1.Location = new System.Drawing.Point(21, 140);
            iNTERVIEW_DATELabel1.Name = "iNTERVIEW_DATELabel1";
            iNTERVIEW_DATELabel1.Size = new System.Drawing.Size(128, 17);
            iNTERVIEW_DATELabel1.TabIndex = 19;
            iNTERVIEW_DATELabel1.Text = "INTERVIEW DATE:";
            // 
            // iNTERVIEW_DATEDateTimePicker1
            // 
            this.iNTERVIEW_DATEDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iNTERVIEWBindingSource, "INTERVIEW_DATE", true));
            this.iNTERVIEW_DATEDateTimePicker1.Location = new System.Drawing.Point(189, 140);
            this.iNTERVIEW_DATEDateTimePicker1.Name = "iNTERVIEW_DATEDateTimePicker1";
            this.iNTERVIEW_DATEDateTimePicker1.Size = new System.Drawing.Size(196, 22);
            this.iNTERVIEW_DATEDateTimePicker1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Проведени интервютата:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 22;
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
            // aPPRAISERBindingSource
            // 
            this.aPPRAISERBindingSource.DataMember = "APPRAISER";
            this.aPPRAISERBindingSource.DataSource = this.applicant_TrackingDataSet;
            // 
            // aPPRAISERTableAdapter
            // 
            this.aPPRAISERTableAdapter.ClearBeforeFill = true;
            // 
            // aPPRAISER_ASSESSMENTLabel
            // 
            aPPRAISER_ASSESSMENTLabel.AutoSize = true;
            aPPRAISER_ASSESSMENTLabel.Location = new System.Drawing.Point(21, 84);
            aPPRAISER_ASSESSMENTLabel.Name = "aPPRAISER_ASSESSMENTLabel";
            aPPRAISER_ASSESSMENTLabel.Size = new System.Drawing.Size(157, 17);
            aPPRAISER_ASSESSMENTLabel.TabIndex = 22;
            aPPRAISER_ASSESSMENTLabel.Text = "Оценка на оценителя:";
            // 
            // aPPRAISER_ASSESSMENTTextBox
            // 
            this.aPPRAISER_ASSESSMENTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPRAISERBindingSource, "APPRAISER_ASSESSMENT", true));
            this.aPPRAISER_ASSESSMENTTextBox.Location = new System.Drawing.Point(223, 84);
            this.aPPRAISER_ASSESSMENTTextBox.Name = "aPPRAISER_ASSESSMENTTextBox";
            this.aPPRAISER_ASSESSMENTTextBox.Size = new System.Drawing.Size(134, 22);
            this.aPPRAISER_ASSESSMENTTextBox.TabIndex = 23;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.iNTERVIEWBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form9";
            this.Text = "Служител детайли";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNTERVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNTERVIEWBindingNavigator)).EndInit();
            this.iNTERVIEWBindingNavigator.ResumeLayout(false);
            this.iNTERVIEWBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLICANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPRAISERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private Applicant_TrackingDataSet applicant_TrackingDataSet;
        private System.Windows.Forms.BindingSource iNTERVIEWBindingSource;
        private Applicant_TrackingDataSetTableAdapters.INTERVIEWTableAdapter iNTERVIEWTableAdapter;
        private Applicant_TrackingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iNTERVIEWBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iNTERVIEWBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker iNTERVIEW_DATEDateTimePicker1;
        private Applicant_TrackingDataSetTableAdapters.APPLICANTTableAdapter aPPLICANTTableAdapter;
        private System.Windows.Forms.BindingSource aPPLICANTBindingSource;
        private Applicant_TrackingDataSetTableAdapters.APPRAISERTableAdapter aPPRAISERTableAdapter;
        private System.Windows.Forms.BindingSource aPPRAISERBindingSource;
        private System.Windows.Forms.TextBox aPPRAISER_ASSESSMENTTextBox;
    }
}