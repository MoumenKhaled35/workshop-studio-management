namespace The_Creative_Workshop___Studio_Management
{
    partial class ReportsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MostPopular = new System.Windows.Forms.Button();
            this.btn_Inactive = new System.Windows.Forms.Button();
            this.btn_ToolRental = new System.Windows.Forms.Button();
            this.btn_MaterialUsage = new System.Windows.Forms.Button();
            this.btn_Empty = new System.Windows.Forms.Button();
            this.btn_TopArtist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTS";
            // 
            // btn_MostPopular
            // 
            this.btn_MostPopular.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_MostPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostPopular.Location = new System.Drawing.Point(0, 100);
            this.btn_MostPopular.Name = "btn_MostPopular";
            this.btn_MostPopular.Size = new System.Drawing.Size(358, 42);
            this.btn_MostPopular.TabIndex = 1;
            this.btn_MostPopular.Text = "Most Popular Workshop";
            this.btn_MostPopular.UseVisualStyleBackColor = false;
            this.btn_MostPopular.Click += new System.EventHandler(this.btn_MostPopular_Click);
            // 
            // btn_Inactive
            // 
            this.btn_Inactive.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Inactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inactive.Location = new System.Drawing.Point(540, 100);
            this.btn_Inactive.Name = "btn_Inactive";
            this.btn_Inactive.Size = new System.Drawing.Size(358, 42);
            this.btn_Inactive.TabIndex = 2;
            this.btn_Inactive.Text = "Empty Studios";
            this.btn_Inactive.UseVisualStyleBackColor = false;
            this.btn_Inactive.Click += new System.EventHandler(this.btn_Inactive_Click);
            // 
            // btn_ToolRental
            // 
            this.btn_ToolRental.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_ToolRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ToolRental.Location = new System.Drawing.Point(540, 366);
            this.btn_ToolRental.Name = "btn_ToolRental";
            this.btn_ToolRental.Size = new System.Drawing.Size(358, 42);
            this.btn_ToolRental.TabIndex = 3;
            this.btn_ToolRental.Text = "Tool Rental Statistics";
            this.btn_ToolRental.UseVisualStyleBackColor = false;
            this.btn_ToolRental.Click += new System.EventHandler(this.btn_ToolRental_Click);
            // 
            // btn_MaterialUsage
            // 
            this.btn_MaterialUsage.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_MaterialUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaterialUsage.Location = new System.Drawing.Point(0, 366);
            this.btn_MaterialUsage.Name = "btn_MaterialUsage";
            this.btn_MaterialUsage.Size = new System.Drawing.Size(358, 42);
            this.btn_MaterialUsage.TabIndex = 4;
            this.btn_MaterialUsage.Text = "Material Usage";
            this.btn_MaterialUsage.UseVisualStyleBackColor = false;
            this.btn_MaterialUsage.Click += new System.EventHandler(this.btn_MaterialUsage_Click);
            // 
            // btn_Empty
            // 
            this.btn_Empty.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empty.Location = new System.Drawing.Point(454, 233);
            this.btn_Empty.Name = "btn_Empty";
            this.btn_Empty.Size = new System.Drawing.Size(287, 42);
            this.btn_Empty.TabIndex = 5;
            this.btn_Empty.Text = "Inactive Members";
            this.btn_Empty.UseVisualStyleBackColor = false;
            this.btn_Empty.Click += new System.EventHandler(this.btn_Empty_Click);
            // 
            // btn_TopArtist
            // 
            this.btn_TopArtist.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_TopArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TopArtist.Location = new System.Drawing.Point(147, 233);
            this.btn_TopArtist.Name = "btn_TopArtist";
            this.btn_TopArtist.Size = new System.Drawing.Size(246, 42);
            this.btn_TopArtist.TabIndex = 6;
            this.btn_TopArtist.Text = "Top Artist";
            this.btn_TopArtist.UseVisualStyleBackColor = false;
            this.btn_TopArtist.Click += new System.EventHandler(this.btn_TopArtist_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(901, 460);
            this.Controls.Add(this.btn_TopArtist);
            this.Controls.Add(this.btn_Empty);
            this.Controls.Add(this.btn_MaterialUsage);
            this.Controls.Add(this.btn_ToolRental);
            this.Controls.Add(this.btn_Inactive);
            this.Controls.Add(this.btn_MostPopular);
            this.Controls.Add(this.label1);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MostPopular;
        private System.Windows.Forms.Button btn_Inactive;
        private System.Windows.Forms.Button btn_ToolRental;
        private System.Windows.Forms.Button btn_MaterialUsage;
        private System.Windows.Forms.Button btn_Empty;
        private System.Windows.Forms.Button btn_TopArtist;
    }
}