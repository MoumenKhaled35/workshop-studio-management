namespace The_Creative_Workshop___Studio_Management
{
    partial class RegistrationForm
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
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Select_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.wORKSHOPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEMBERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGISTRATIONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGISTRATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theCreativeWorkshop_StudioManagementDataSet = new The_Creative_Workshop___Studio_Management.TheCreativeWorkshop_StudioManagementDataSet();
            this.rEGISTRATIONTableAdapter = new The_Creative_Workshop___Studio_Management.TheCreativeWorkshop_StudioManagementDataSetTableAdapters.REGISTRATIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCreativeWorkshop_StudioManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wORKSHOPIDDataGridViewTextBoxColumn,
            this.mEMBERIDDataGridViewTextBoxColumn,
            this.rEGISTRATIONIDDataGridViewTextBoxColumn,
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEGISTRATIONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(458, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // Insert_btn
            // 
            this.Insert_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.Location = new System.Drawing.Point(153, 298);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(106, 41);
            this.Insert_btn.TabIndex = 1;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(553, 294);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(113, 42);
            this.Delete_btn.TabIndex = 2;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(350, 297);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(111, 42);
            this.Update_btn.TabIndex = 3;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Select_btn
            // 
            this.Select_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.Select_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_btn.Location = new System.Drawing.Point(714, 208);
            this.Select_btn.Name = "Select_btn";
            this.Select_btn.Size = new System.Drawing.Size(163, 54);
            this.Select_btn.TabIndex = 4;
            this.Select_btn.Text = "Show Data";
            this.Select_btn.UseVisualStyleBackColor = false;
            this.Select_btn.Click += new System.EventHandler(this.Select_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Workshop ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Registration ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registration Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(212, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 22);
            this.textBox4.TabIndex = 12;
            // 
            // wORKSHOPIDDataGridViewTextBoxColumn
            // 
            this.wORKSHOPIDDataGridViewTextBoxColumn.DataPropertyName = "WORKSHOP_ID";
            this.wORKSHOPIDDataGridViewTextBoxColumn.HeaderText = "WORKSHOP_ID";
            this.wORKSHOPIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wORKSHOPIDDataGridViewTextBoxColumn.Name = "wORKSHOPIDDataGridViewTextBoxColumn";
            this.wORKSHOPIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mEMBERIDDataGridViewTextBoxColumn
            // 
            this.mEMBERIDDataGridViewTextBoxColumn.DataPropertyName = "MEMBER_ID";
            this.mEMBERIDDataGridViewTextBoxColumn.HeaderText = "MEMBER_ID";
            this.mEMBERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mEMBERIDDataGridViewTextBoxColumn.Name = "mEMBERIDDataGridViewTextBoxColumn";
            this.mEMBERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rEGISTRATIONIDDataGridViewTextBoxColumn
            // 
            this.rEGISTRATIONIDDataGridViewTextBoxColumn.DataPropertyName = "REGISTRATIONID";
            this.rEGISTRATIONIDDataGridViewTextBoxColumn.HeaderText = "REGISTRATIONID";
            this.rEGISTRATIONIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rEGISTRATIONIDDataGridViewTextBoxColumn.Name = "rEGISTRATIONIDDataGridViewTextBoxColumn";
            this.rEGISTRATIONIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rEGISTRATIONDATEDataGridViewTextBoxColumn
            // 
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.DataPropertyName = "REGISTRATIONDATE";
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.HeaderText = "REGISTRATIONDATE";
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.Name = "rEGISTRATIONDATEDataGridViewTextBoxColumn";
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // rEGISTRATIONBindingSource
            // 
            this.rEGISTRATIONBindingSource.DataMember = "REGISTRATION";
            this.rEGISTRATIONBindingSource.DataSource = this.theCreativeWorkshop_StudioManagementDataSet;
            // 
            // theCreativeWorkshop_StudioManagementDataSet
            // 
            this.theCreativeWorkshop_StudioManagementDataSet.DataSetName = "TheCreativeWorkshop_StudioManagementDataSet";
            this.theCreativeWorkshop_StudioManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEGISTRATIONTableAdapter
            // 
            this.rEGISTRATIONTableAdapter.ClearBeforeFill = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1027, 401);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Select_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCreativeWorkshop_StudioManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TheCreativeWorkshop_StudioManagementDataSet theCreativeWorkshop_StudioManagementDataSet;
        private System.Windows.Forms.BindingSource rEGISTRATIONBindingSource;
        private TheCreativeWorkshop_StudioManagementDataSetTableAdapters.REGISTRATIONTableAdapter rEGISTRATIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORKSHOPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEMBERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGISTRATIONIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGISTRATIONDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Select_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}