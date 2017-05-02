namespace _2048
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTextScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Beige;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("OCR A Extended", 20F);
            this.btnUndo.Location = new System.Drawing.Point(385, 12);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(147, 50);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = global::_2048.Properties.Resources.up_arrow;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(435, 81);
            this.btnUp.Name = "btnUp";
            this.btnUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUp.Size = new System.Drawing.Size(50, 50);
            this.btnUp.TabIndex = 1;
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BackgroundImage = global::_2048.Properties.Resources.left_arrow;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Location = new System.Drawing.Point(385, 137);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(50, 50);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.BackgroundImage = global::_2048.Properties.Resources.right_arrow;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Location = new System.Drawing.Point(482, 137);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(50, 50);
            this.btnRight.TabIndex = 3;
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.BackgroundImage = global::_2048.Properties.Resources.down_arrow;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(435, 193);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(50, 50);
            this.btnDown.TabIndex = 4;
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Beige;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("OCR A Extended", 20F);
            this.btnBack.Location = new System.Drawing.Point(385, 324);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 50);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTextScore
            // 
            this.lblTextScore.AutoSize = true;
            this.lblTextScore.BackColor = System.Drawing.Color.Transparent;
            this.lblTextScore.Font = new System.Drawing.Font("OCR A Extended", 16F);
            this.lblTextScore.Location = new System.Drawing.Point(381, 261);
            this.lblTextScore.Name = "lblTextScore";
            this.lblTextScore.Size = new System.Drawing.Size(88, 24);
            this.lblTextScore.TabIndex = 6;
            this.lblTextScore.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("OCR A Extended", 16F);
            this.lblScore.Location = new System.Drawing.Point(381, 285);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(23, 24);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(544, 386);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTextScore);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnUndo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(560, 425);
            this.MinimumSize = new System.Drawing.Size(560, 425);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTextScore;
        private System.Windows.Forms.Label lblScore;
    }
}

