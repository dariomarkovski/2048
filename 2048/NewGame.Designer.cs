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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnUltimate = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.Beige;
            this.btnNormal.FlatAppearance.BorderSize = 2;
            this.btnNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(12, 53);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(310, 50);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnUltimate
            // 
            this.btnUltimate.BackColor = System.Drawing.Color.Beige;
            this.btnUltimate.FlatAppearance.BorderSize = 2;
            this.btnUltimate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnUltimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimate.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimate.Location = new System.Drawing.Point(12, 109);
            this.btnUltimate.Name = "btnUltimate";
            this.btnUltimate.Size = new System.Drawing.Size(310, 50);
            this.btnUltimate.TabIndex = 1;
            this.btnUltimate.Text = "Ultimate";
            this.btnUltimate.UseVisualStyleBackColor = false;
            this.btnUltimate.Click += new System.EventHandler(this.btnUltimate_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.BackColor = System.Drawing.Color.Beige;
            this.btnPractice.FlatAppearance.BorderSize = 2;
            this.btnPractice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPractice.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractice.Location = new System.Drawing.Point(12, 165);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(310, 50);
            this.btnPractice.TabIndex = 2;
            this.btnPractice.Text = "Practice";
            this.btnPractice.UseVisualStyleBackColor = false;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Beige;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 221);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(310, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 316);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnUltimate);
            this.Controls.Add(this.btnNormal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 355);
            this.MinimumSize = new System.Drawing.Size(350, 355);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnUltimate;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnBack;
    }
}