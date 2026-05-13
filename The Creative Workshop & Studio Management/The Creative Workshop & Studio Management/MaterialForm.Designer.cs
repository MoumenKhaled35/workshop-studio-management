namespace The_Creative_Workshop___Studio_Management
{
    partial class MaterialForm
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.theCreativeWorkshop_StudioManagementDataSet = new The_Creative_Workshop___Studio_Management.TheCreativeWorkshop_StudioManagementDataSet();
            this.mATERIALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mATERIALTableAdapter = new The_Creative_Workshop___Studio_Management.TheCreativeWorkshop_StudioManagementDataSetTableAdapters.MATERIALTableAdapter();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYAVAILABLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCreativeWorkshop_StudioManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(329, 386);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 48);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.qUANTITYAVAILABLEDataGridViewTextBoxColumn,
            this.uNITDataGridViewTextBoxColumn,
            this.mATERIALNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mATERIALBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(329, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // theCreativeWorkshop_StudioManagementDataSet
            // 
            this.theCreativeWorkshop_StudioManagementDataSet.DataSetName = "TheCreativeWorkshop_StudioManagementDataSet";
            this.theCreativeWorkshop_StudioManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATERIALBindingSource
            // 
            this.mATERIALBindingSource.DataMember = "MATERIAL";
            this.mATERIALBindingSource.DataSource = this.theCreativeWorkshop_StudioManagementDataSet;
            // 
            // mATERIALTableAdapter
            // 
            this.mATERIALTableAdapter.ClearBeforeFill = true;
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL_ID";
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = "MATERIAL_ID";
            this.mATERIALIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            this.mATERIALIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // qUANTITYAVAILABLEDataGridViewTextBoxColumn
            // 
            this.qUANTITYAVAILABLEDataGridViewTextBoxColumn.DataPropertyName = "QUANTITYAVAILABLE";
            this.qUANTITYAVAILABLEDataGridViewTextBoxColumn.HeaderText = "QUANTITYAVAILABLE";
            this.qUANTITYAVAILABLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qUANTITYAVAILABLEDataGridViewTextBoxColumn.Name = "qUANTITYAVAILABLEDataGridViewTextBoxColumn";
            this.qUANTITYAVAILABLEDataGridViewTextBoxColumn.Width = 125;
            // 
            // uNITDataGridViewTextBoxColumn
            // 
            this.uNITDataGridViewTextBoxColumn.DataPropertyName = "UNIT";
            this.uNITDataGridViewTextBoxColumn.HeaderText = "UNIT";
            this.uNITDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uNITDataGridViewTextBoxColumn.Name = "uNITDataGridViewTextBoxColumn";
            this.uNITDataGridViewTextBoxColumn.Width = 125;
            // 
            // mATERIALNAMEDataGridViewTextBoxColumn
            // 
            this.mATERIALNAMEDataGridViewTextBoxColumn.DataPropertyName = "MATERIALNAME";
            this.mATERIALNAMEDataGridViewTextBoxColumn.HeaderText = "MATERIALNAME";
            this.mATERIALNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mATERIALNAMEDataGridViewTextBoxColumn.Name = "mATERIALNAMEDataGridViewTextBoxColumn";
            this.mATERIALNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Material ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(153, 149);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity Available";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(41, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(12, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Material Name";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(226, 220);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 7;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(153, 288);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 22);
            this.txtUnit.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(177, 358);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 22);
            this.txtName.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(500, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 48);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(659, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 48);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(659, 237);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(153, 48);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Show Data";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(894, 459);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInsert);
            this.Name = "MaterialForm";
            this.Text = "Material";
            this.Load += new System.EventHandler(this.MaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCreativeWorkshop_StudioManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TheCreativeWorkshop_StudioManagementDataSet theCreativeWorkshop_StudioManagementDataSet;
        private System.Windows.Forms.BindingSource mATERIALBindingSource;
        private TheCreativeWorkshop_StudioManagementDataSetTableAdapters.MATERIALTableAdapter mATERIALTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYAVAILABLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
    }
}