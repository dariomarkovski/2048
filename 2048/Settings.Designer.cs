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
            this.lblTheme = new System.Windows.Forms.Label();
            this.ddlThemes = new System.Windows.Forms.ComboBox();
            this.btnResetHS = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(13, 38);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(43, 13);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "Theme:";
            // 
            // ddlThemes
            // 
            this.ddlThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlThemes.FormattingEnabled = true;
            this.ddlThemes.Location = new System.Drawing.Point(113, 38);
            this.ddlThemes.Name = "ddlThemes";
            this.ddlThemes.Size = new System.Drawing.Size(121, 21);
            this.ddlThemes.TabIndex = 1;
            // 
            // btnResetHS
            // 
            this.btnResetHS.Location = new System.Drawing.Point(65, 121);
            this.btnResetHS.Name = "btnResetHS";
            this.btnResetHS.Size = new System.Drawing.Size(119, 23);
            this.btnResetHS.TabIndex = 2;
            this.btnResetHS.Text = "Reset High Scores";
            this.btnResetHS.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(65, 188);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnResetHS);
            this.Controls.Add(this.ddlThemes);
            this.Controls.Add(this.lblTheme);
            this.Name = "Settings";
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