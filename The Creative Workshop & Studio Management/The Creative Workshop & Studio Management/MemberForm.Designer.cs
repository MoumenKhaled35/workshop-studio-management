namespace The_Creative_Workshop___Studio_Management
{
    partial class MemberForm
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
            this.Insertbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.theCreativeWorkshop_StudioManagementDataSet = new The_Creative_Workshop___Studio_Management.TheCreativeWorkshop_StudioManagementDataSet();
            this.mEMBERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEMBERTableAdapter = new The_Creative_Workshop___Studio_Management.TheCreativeWorkshop_StudioManagementDataSetTableAdapters.MEMBERTableAdapter();
            this.mEMBERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBFEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBSTARTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEMBERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Selectbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCreativeWorkshop_StudioManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Insertbtn
            // 
            this.Insertbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbtn.Location = new System.Drawing.Point(268, 535);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(117, 48);
            this.Insertbtn.TabIndex = 0;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = false;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mEMBERIDDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pHONENUMDataGridViewTextBoxColumn,
            this.sUBFEEDataGridViewTextBoxColumn,
            this.sUBSTARTDATEDataGridViewTextBoxColumn,
            this.mEMBERNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mEMBERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(173, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // theCreativeWorkshop_StudioManagementDataSet
            // 
            this.theCreativeWorkshop_StudioManagementDataSet.DataSetName = "TheCreativeWorkshop_StudioManagementDataSet";
            this.theCreativeWorkshop_StudioManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEMBERBindingSource
            // 
            this.mEMBERBindingSource.DataMember = "MEMBER";
            this.mEMBERBindingSource.DataSource = this.theCreativeWorkshop_StudioManagementDataSet;
            // 
            // mEMBERTableAdapter
            // 
            this.mEMBERTableAdapter.ClearBeforeFill = true;
            // 
            // mEMBERIDDataGridViewTextBoxColumn
            // 
            this.mEMBERIDDataGridViewTextBoxColumn.DataPropertyName = "MEMBER_ID";
            this.mEMBERIDDataGridViewTextBoxColumn.HeaderText = "MEMBER_ID";
            this.mEMBERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mEMBERIDDataGridViewTextBoxColumn.Name = "mEMBERIDDataGridViewTextBoxColumn";
            this.mEMBERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHONENUMDataGridViewTextBoxColumn
            // 
            this.pHONENUMDataGridViewTextBoxColumn.DataPropertyName = "PHONENUM";
            this.pHONENUMDataGridViewTextBoxColumn.HeaderText = "PHONENUM";
            this.pHONENUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONENUMDataGridViewTextBoxColumn.Name = "pHONENUMDataGridViewTextBoxColumn";
            this.pHONENUMDataGridViewTextBoxColumn.Width = 125;
            // 
            // sUBFEEDataGridViewTextBoxColumn
            // 
            this.sUBFEEDataGridViewTextBoxColumn.DataPropertyName = "SUBFEE";
            this.sUBFEEDataGridViewTextBoxColumn.HeaderText = "SUBFEE";
            this.sUBFEEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sUBFEEDataGridViewTextBoxColumn.Name = "sUBFEEDataGridViewTextBoxColumn";
            this.sUBFEEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sUBSTARTDATEDataGridViewTextBoxColumn
            // 
            this.sUBSTARTDATEDataGridViewTextBoxColumn.DataPropertyName = "SUBSTARTDATE";
            this.sUBSTARTDATEDataGridViewTextBoxColumn.HeaderText = "SUBSTARTDATE";
            this.sUBSTARTDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sUBSTARTDATEDataGridViewTextBoxColumn.Name = "sUBSTARTDATEDataGridViewTextBoxColumn";
            this.sUBSTARTDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // mEMBERNAMEDataGridViewTextBoxColumn
            // 
            this.mEMBERNAMEDataGridViewTextBoxColumn.DataPropertyName = "MEMBERNAME";
            this.mEMBERNAMEDataGridViewTextBoxColumn.HeaderText = "MEMBERNAME";
            this.mEMBERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mEMBERNAMEDataGridViewTextBoxColumn.Name = "mEMBERNAMEDataGridViewTextBoxColumn";
            this.mEMBERNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Member ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(187, 215);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 22);
            this.txtMemberID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subscription Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Member Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(187, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(187, 317);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(135, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(207, 376);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(100, 22);
            this.txtFee.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(207, 421);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(207, 469);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 22);
            this.txtName.TabIndex = 13;
            // 
            // Selectbtn
            // 
            this.Selectbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Selectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectbtn.Location = new System.Drawing.Point(738, 349);
            this.Selectbtn.Name = "Selectbtn";
            this.Selectbtn.Size = new System.Drawing.Size(155, 48);
            this.Selectbtn.TabIndex = 14;
            this.Selectbtn.Text = "Show Data";
            this.Selectbtn.UseVisualStyleBackColor = false;
            this.Selectbtn.Click += new System.EventHandler(this.Selectbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(472, 535);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(117, 48);
            this.Updatebtn.TabIndex = 15;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.SandyBrown;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(671, 535);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(117, 48);
            this.deletebtn.TabIndex = 16;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(989, 595);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Selectbtn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Insertbtn);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCreativeWorkshop_StudioManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TheCreativeWorkshop_StudioManagementDataSet theCreativeWorkshop_StudioManagementDataSet;
        private System.Windows.Forms.BindingSource mEMBERBindingSource;
        private TheCreativeWorkshop_StudioManagementDataSetTableAdapters.MEMBERTableAdapter mEMBERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEMBERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBFEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBSTARTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEMBERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button Selectbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button deletebtn;
    }
}