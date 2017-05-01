namespace _2048
{
    partial class NewGame
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
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnUltimate = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(90, 44);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnUltimate
            // 
            this.btnUltimate.Location = new System.Drawing.Point(90, 98);
            this.btnUltimate.Name = "btnUltimate";
            this.btnUltimate.Size = new System.Drawing.Size(75, 23);
            this.btnUltimate.TabIndex = 1;
            this.btnUltimate.Text = "Ultimate";
            this.btnUltimate.UseVisualStyleBackColor = true;
            // 
            // btnPractice
            // 
            this.btnPractice.Location = new System.Drawing.Point(90, 153);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(75, 23);
            this.btnPractice.TabIndex = 2;
            this.btnPractice.Text = "Practice";
            this.btnPractice.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(90, 196);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnUltimate);
            this.Controls.Add(this.btnNormal);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnUltimate;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnBack;
    }
}