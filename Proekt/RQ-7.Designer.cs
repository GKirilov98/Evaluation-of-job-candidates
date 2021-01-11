namespace Proekt
{
    partial class Form4
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
            System.Windows.Forms.Label sKIL_NAMELabel;
            System.Windows.Forms.Label pOSITION_IDLabel;
            System.Windows.Forms.Label pOSITION_NAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.pOSITION_IDTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sKILSTableAdapter = new Proekt.Applicant_TrackingDataSetTableAdapters.SKILSTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sKILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sKIL_NAMELabel = new System.Windows.Forms.Label();
            pOSITION_IDLabel = new System.Windows.Forms.Label();
            pOSITION_NAMELabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingNavigator)).BeginInit();
            this.pOSITIONSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sKILSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sKIL_NAMELabel
            // 
            sKIL_NAMELabel.AutoSize = true;
            sKIL_NAMELabel.Location = new System.Drawing.Point(22, 147);
            sKIL_NAMELabel.Name = "sKIL_NAMELabel";
            sKIL_NAMELabel.Size = new System.Drawing.Size(62, 17);
            sKIL_NAMELabel.TabIndex = 10;
            sKIL_NAMELabel.Text = "Умения:";
            // 
            // pOSITION_IDLabel
            // 
            pOSITION_IDLabel.AutoSize = true;
            pOSITION_IDLabel.Location = new System.Drawing.Point(22, 46);
            pOSITION_IDLabel.Name = "pOSITION_IDLabel";
            pOSITION_IDLabel.Size = new System.Drawing.Size(125, 17);
            pOSITION_IDLabel.TabIndex = 7;
            pOSITION_IDLabel.Text = "Код на длъжност:";
            // 
            // pOSITION_NAMELabel
            // 
            pOSITION_NAMELabel.AutoSize = true;
            pOSITION_NAMELabel.Location = new System.Drawing.Point(22, 93);
            pOSITION_NAMELabel.Name = "pOSITION_NAMELabel";
            pOSITION_NAMELabel.Size = new System.Drawing.Size(198, 17);
            pOSITION_NAMELabel.TabIndex = 8;
            pOSITION_NAMELabel.Text = "Наименование на длъжност:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.pOSITION_IDTextBox);
            this.groupBox2.Controls.Add(sKIL_NAMELabel);
            this.groupBox2.Controls.Add(pOSITION_IDLabel);
            this.groupBox2.Controls.Add(pOSITION_NAMELabel);
            this.groupBox2.Location = new System.Drawing.Point(53, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 197);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактиране";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Location = new System.Drawing.Point(550, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 18;
            this.button4.Text = "Отказ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Aqua;
            this.button5.Location = new System.Drawing.Point(659, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 41);
            this.button5.TabIndex = 17;
            this.button5.Text = "Запази";
            this.button5.UseVisualStyleBackColor = false;
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
            this.tableAdapterManager.SKILSTableAdapter = this.sKILSTableAdapter;
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
            this.pOSITIONSBindingNavigator.Size = new System.Drawing.Size(836, 27);
            this.pOSITIONSBindingNavigator.TabIndex = 19;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // pOSITION_IDTextBox
            // 
            this.pOSITION_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOSITIONSBindingSource, "POSITION_ID", true));
            this.pOSITION_IDTextBox.Location = new System.Drawing.Point(242, 41);
            this.pOSITION_IDTextBox.Name = "pOSITION_IDTextBox";
            this.pOSITION_IDTextBox.Size = new System.Drawing.Size(159, 22);
            this.pOSITION_IDTextBox.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOSITIONSBindingSource, "POSITION_NAME", true));
            this.textBox1.Location = new System.Drawing.Point(242, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 23;
            // 
            // sKILSTableAdapter
            // 
            this.sKILSTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sKILSBindingSource, "SKIL_NAME", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(242, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // sKILSBindingSource
            // 
            this.sKILSBindingSource.DataMember = "FK_SKILS_REFERENCE_POSITION";
            this.sKILSBindingSource.DataSource = this.pOSITIONSBindingSource;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.pOSITIONSBindingNavigator);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form4";
            this.Text = "Редактиране на дължност";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_TrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingNavigator)).EndInit();
            this.pOSITIONSBindingNavigator.ResumeLayout(false);
            this.pOSITIONSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sKILSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
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
        private System.Windows.Forms.TextBox pOSITION_IDTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private Applicant_TrackingDataSetTableAdapters.SKILSTableAdapter sKILSTableAdapter;
        private System.Windows.Forms.BindingSource sKILSBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}