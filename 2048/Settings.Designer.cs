namespace _2048
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblTheme = new System.Windows.Forms.Label();
            this.ddlThemes = new System.Windows.Forms.ComboBox();
            this.btnResetHS = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.BackColor = System.Drawing.Color.Transparent;
            this.lblTheme.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(12, 35);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(109, 29);
            this.lblTheme.TabIndex = 3;
            this.lblTheme.Text = "Theme:";
            // 
            // ddlThemes
            // 
            this.ddlThemes.BackColor = System.Drawing.Color.Beige;
            this.ddlThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlThemes.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlThemes.FormattingEnabled = true;
            this.ddlThemes.Items.AddRange(new object[] {
            "wood",
            "aqua"});
            this.ddlThemes.Location = new System.Drawing.Point(128, 35);
            this.ddlThemes.Name = "ddlThemes";
            this.ddlThemes.Size = new System.Drawing.Size(194, 37);
            this.ddlThemes.TabIndex = 0;
            this.ddlThemes.SelectedIndexChanged += new System.EventHandler(this.ddlThemes_SelectedIndexChanged);
            // 
            // btnResetHS
            // 
            this.btnResetHS.BackColor = System.Drawing.Color.Beige;
            this.btnResetHS.FlatAppearance.BorderSize = 2;
            this.btnResetHS.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate;
            this.btnResetHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetHS.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetHS.Location = new System.Drawing.Point(12, 107);
            this.btnResetHS.Name = "btnResetHS";
            this.btnResetHS.Size = new System.Drawing.Size(310, 50);
            this.btnResetHS.TabIndex = 1;
            this.btnResetHS.Text = "Reset High Scores";
            this.btnResetHS.UseVisualStyleBackColor = false;
            this.btnResetHS.Click += new System.EventHandler(this.btnResetHS_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Beige;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 221);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(310, 50);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 316);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnResetHS);
            this.Controls.Add(this.ddlThemes);
            this.Controls.Add(this.lblTheme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 355);
            this.MinimumSize = new System.Drawing.Size(350, 355);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox ddlThemes;
        private System.Windows.Forms.Button btnResetHS;
        private System.Windows.Forms.Button btnBack;
    }
}