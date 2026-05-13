namespace The_Creative_Workshop___Studio_Management
{
    partial class StudioForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.theCreativeWorkshop_StudioManagementDataSet = new The_Creative_Workshop___Studio_Management.TheCreativeWorkshop_StudioManagementDataSet();
            this.sTUDIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDIOTableAdapter = new The_Creative_Workshop___Studio_Management.TheCreativeWorkshop_StudioManagementDataSetTableAdapters.STUDIOTableAdapter();
            this.sTUDIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAXCAPACITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDIONAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudioID = new System.Windows.Forms.TextBox();
            this.txtMaxCapacity = new System.Windows.Forms.TextBox();
            this.txtStudioName = new System.Windows.Forms.TextBox();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Select_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCreativeWorkshop_StudioManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUDIOIDDataGridViewTextBoxColumn,
            this.mAXCAPACITYDataGridViewTextBoxColumn,
            this.sTUDIONAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTUDIOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(599, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // theCreativeWorkshop_StudioManagementDataSet
            // 
            this.theCreativeWorkshop_StudioManagementDataSet.DataSetName = "TheCreativeWorkshop_StudioManagementDataSet";
            this.theCreativeWorkshop_StudioManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDIOBindingSource
            // 
            this.sTUDIOBindingSource.DataMember = "STUDIO";
            this.sTUDIOBindingSource.DataSource = this.theCreativeWorkshop_StudioManagementDataSet;
            // 
            // sTUDIOTableAdapter
            // 
            this.sTUDIOTableAdapter.ClearBeforeFill = true;
            // 
            // sTUDIOIDDataGridViewTextBoxColumn
            // 
            this.sTUDIOIDDataGridViewTextBoxColumn.DataPropertyName = "STUDIOID";
            this.sTUDIOIDDataGridViewTextBoxColumn.HeaderText = "STUDIOID";
            this.sTUDIOIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDIOIDDataGridViewTextBoxColumn.Name = "sTUDIOIDDataGridViewTextBoxColumn";
            this.sTUDIOIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAXCAPACITYDataGridViewTextBoxColumn
            // 
            this.mAXCAPACITYDataGridViewTextBoxColumn.DataPropertyName = "MAXCAPACITY";
            this.mAXCAPACITYDataGridViewTextBoxColumn.HeaderText = "MAXCAPACITY";
            this.mAXCAPACITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAXCAPACITYDataGridViewTextBoxColumn.Name = "mAXCAPACITYDataGridViewTextBoxColumn";
            this.mAXCAPACITYDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTUDIONAMEDataGridViewTextBoxColumn
            // 
            this.sTUDIONAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDIONAME";
            this.sTUDIONAMEDataGridViewTextBoxColumn.HeaderText = "STUDIONAME";
            this.sTUDIONAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDIONAMEDataGridViewTextBoxColumn.Name = "sTUDIONAMEDataGridViewTextBoxColumn";
            this.sTUDIONAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Studio ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Studio Name";
            // 
            // txtStudioID
            // 
            this.txtStudioID.Location = new System.Drawing.Point(188, 40);
            this.txtStudioID.Name = "txtStudioID";
            this.txtStudioID.Size = new System.Drawing.Size(111, 22);
            this.txtStudioID.TabIndex = 4;
            // 
            // txtMaxCapacity
            // 
            this.txtMaxCapacity.Location = new System.Drawing.Point(222, 105);
            this.txtMaxCapacity.Name = "txtMaxCapacity";
            this.txtMaxCapacity.Size = new System.Drawing.Size(111, 22);
            this.txtMaxCapacity.TabIndex = 5;
            // 
            // txtStudioName
            // 
            this.txtStudioName.Location = new System.Drawing.Point(222, 169);
            this.txtStudioName.Name = "txtStudioName";
            this.txtStudioName.Size = new System.Drawing.Size(111, 22);
            this.txtStudioName.TabIndex = 6;
            // 
            // Insert_btn
            // 
            this.Insert_btn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.Location = new System.Drawing.Point(128, 356);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(121, 51);
            this.Insert_btn.TabIndex = 7;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(366, 356);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(121, 51);
            this.Update_btn.TabIndex = 8;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(634, 356);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(121, 51);
            this.Delete_btn.TabIndex = 9;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Select_btn
            // 
            this.Select_btn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Select_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_btn.Location = new System.Drawing.Point(763, 238);
            this.Select_btn.Name = "Select_btn";
            this.Select_btn.Size = new System.Drawing.Size(186, 51);
            this.Select_btn.TabIndex = 10;
            this.Select_btn.Text = "Show Date";
            this.Select_btn.UseVisualStyleBackColor = false;
            this.Select_btn.Click += new System.EventHandler(this.Select_btn_Click);
            // 
            // StudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1027, 491);
            this.Controls.Add(this.Select_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.txtStudioName);
            this.Controls.Add(this.txtMaxCapacity);
            this.Controls.Add(this.txtStudioID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudioForm";
            this.Text = "StudioForm";
            this.Load += new System.EventHandler(this.StudioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCreativeWorkshop_StudioManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDIOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TheCreativeWorkshop_StudioManagementDataSet theCreativeWorkshop_StudioManagementDataSet;
        private System.Windows.Forms.BindingSource sTUDIOBindingSource;
        private TheCreativeWorkshop_StudioManagementDataSetTableAdapters.STUDIOTableAdapter sTUDIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXCAPACITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDIONAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudioID;
        private System.Windows.Forms.TextBox txtMaxCapacity;
        private System.Windows.Forms.TextBox txtStudioName;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Select_btn;
    }
}