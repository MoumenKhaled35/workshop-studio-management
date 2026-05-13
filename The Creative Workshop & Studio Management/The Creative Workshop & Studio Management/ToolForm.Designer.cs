namespace The_Creative_Workshop___Studio_Management
{
    partial class ToolForm
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
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Select_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.tOOLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theCreativeWorkshop_StudioManagementDataSet = new The_Creative_Workshop___Studio_Management.TheCreativeWorkshop_StudioManagementDataSet();
            this.tOOLTableAdapter = new The_Creative_Workshop___Studio_Management.TheCreativeWorkshop_StudioManagementDataSetTableAdapters.TOOLTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToolID = new System.Windows.Forms.TextBox();
            this.txtStudioID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.txtToolName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tOOLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABILITYSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOOLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDIONAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOOLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tOOLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCreativeWorkshop_StudioManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOOLBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(766, 408);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(109, 50);
            this.Delete_btn.TabIndex = 2;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Select_btn
            // 
            this.Select_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Select_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_btn.Location = new System.Drawing.Point(1005, 328);
            this.Select_btn.Name = "Select_btn";
            this.Select_btn.Size = new System.Drawing.Size(172, 50);
            this.Select_btn.TabIndex = 3;
            this.Select_btn.Text = "Show Data";
            this.Select_btn.UseVisualStyleBackColor = false;
            this.Select_btn.Click += new System.EventHandler(this.Select_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(573, 408);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(109, 50);
            this.Update_btn.TabIndex = 4;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.Location = new System.Drawing.Point(395, 408);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(109, 50);
            this.Insert_btn.TabIndex = 5;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // tOOLBindingSource
            // 
            this.tOOLBindingSource.DataMember = "TOOL";
            this.tOOLBindingSource.DataSource = this.theCreativeWorkshop_StudioManagementDataSet;
            // 
            // theCreativeWorkshop_StudioManagementDataSet
            // 
            this.theCreativeWorkshop_StudioManagementDataSet.DataSetName = "TheCreativeWorkshop_StudioManagementDataSet";
            this.theCreativeWorkshop_StudioManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOOLTableAdapter
            // 
            this.tOOLTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tool ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Studio ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Condition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Availability Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tool Name";
            // 
            // txtToolID
            // 
            this.txtToolID.Location = new System.Drawing.Point(156, 29);
            this.txtToolID.Name = "txtToolID";
            this.txtToolID.Size = new System.Drawing.Size(138, 22);
            this.txtToolID.TabIndex = 13;
            // 
            // txtStudioID
            // 
            this.txtStudioID.Location = new System.Drawing.Point(156, 85);
            this.txtStudioID.Name = "txtStudioID";
            this.txtStudioID.Size = new System.Drawing.Size(138, 22);
            this.txtStudioID.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(156, 145);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(138, 22);
            this.txtDescription.TabIndex = 15;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(171, 219);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(138, 22);
            this.txtCondition.TabIndex = 16;
            // 
            // txtAvailability
            // 
            this.txtAvailability.Location = new System.Drawing.Point(219, 285);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(138, 22);
            this.txtAvailability.TabIndex = 17;
            // 
            // txtToolName
            // 
            this.txtToolName.Location = new System.Drawing.Point(199, 356);
            this.txtToolName.Name = "txtToolName";
            this.txtToolName.Size = new System.Drawing.Size(138, 22);
            this.txtToolName.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tOOLIDDataGridViewTextBoxColumn,
            this.sTUDIOIDDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.cONDITIONDataGridViewTextBoxColumn,
            this.aVAILABILITYSTATUSDataGridViewTextBoxColumn,
            this.tOOLNAMEDataGridViewTextBoxColumn,
            this.STUDIONAME});
            this.dataGridView1.DataSource = this.tOOLBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(350, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 189);
            this.dataGridView1.TabIndex = 19;
            // 
            // tOOLIDDataGridViewTextBoxColumn
            // 
            this.tOOLIDDataGridViewTextBoxColumn.DataPropertyName = "TOOLID";
            this.tOOLIDDataGridViewTextBoxColumn.HeaderText = "TOOLID";
            this.tOOLIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tOOLIDDataGridViewTextBoxColumn.Name = "tOOLIDDataGridViewTextBoxColumn";
            this.tOOLIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTUDIOIDDataGridViewTextBoxColumn
            // 
            this.sTUDIOIDDataGridViewTextBoxColumn.DataPropertyName = "STUDIOID";
            this.sTUDIOIDDataGridViewTextBoxColumn.HeaderText = "STUDIOID";
            this.sTUDIOIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDIOIDDataGridViewTextBoxColumn.Name = "sTUDIOIDDataGridViewTextBoxColumn";
            this.sTUDIOIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // cONDITIONDataGridViewTextBoxColumn
            // 
            this.cONDITIONDataGridViewTextBoxColumn.DataPropertyName = "CONDITION";
            this.cONDITIONDataGridViewTextBoxColumn.HeaderText = "CONDITION";
            this.cONDITIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cONDITIONDataGridViewTextBoxColumn.Name = "cONDITIONDataGridViewTextBoxColumn";
            this.cONDITIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // aVAILABILITYSTATUSDataGridViewTextBoxColumn
            // 
            this.aVAILABILITYSTATUSDataGridViewTextBoxColumn.DataPropertyName = "AVAILABILITYSTATUS";
            this.aVAILABILITYSTATUSDataGridViewTextBoxColumn.HeaderText = "AVAILABILITYSTATUS";
            this.aVAILABILITYSTATUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aVAILABILITYSTATUSDataGridViewTextBoxColumn.Name = "aVAILABILITYSTATUSDataGridViewTextBoxColumn";
            this.aVAILABILITYSTATUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // tOOLNAMEDataGridViewTextBoxColumn
            // 
            this.tOOLNAMEDataGridViewTextBoxColumn.DataPropertyName = "TOOLNAME";
            this.tOOLNAMEDataGridViewTextBoxColumn.HeaderText = "TOOLNAME";
            this.tOOLNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tOOLNAMEDataGridViewTextBoxColumn.Name = "tOOLNAMEDataGridViewTextBoxColumn";
            this.tOOLNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // STUDIONAME
            // 
            this.STUDIONAME.DataPropertyName = "STUDIONAME";
            this.STUDIONAME.HeaderText = "STUDIONAME";
            this.STUDIONAME.MinimumWidth = 6;
            this.STUDIONAME.Name = "STUDIONAME";
            this.STUDIONAME.Width = 125;
            // 
            // tOOLBindingSource1
            // 
            this.tOOLBindingSource1.DataMember = "TOOL";
            this.tOOLBindingSource1.DataSource = this.theCreativeWorkshop_StudioManagementDataSet;
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1280, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtToolName);
            this.Controls.Add(this.txtAvailability);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStudioID);
            this.Controls.Add(this.txtToolID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Select_btn);
            this.Controls.Add(this.Delete_btn);
            this.Name = "ToolForm";
            this.Text = "ToolForm";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tOOLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCreativeWorkshop_StudioManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOOLBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Select_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Insert_btn;
        private TheCreativeWorkshop_StudioManagementDataSet theCreativeWorkshop_StudioManagementDataSet;
        private System.Windows.Forms.BindingSource tOOLBindingSource;
        private TheCreativeWorkshop_StudioManagementDataSetTableAdapters.TOOLTableAdapter tOOLTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToolID;
        private System.Windows.Forms.TextBox txtStudioID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.TextBox txtToolName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tOOLBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOOLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVAILABILITYSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOOLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDIONAME;
    }
}