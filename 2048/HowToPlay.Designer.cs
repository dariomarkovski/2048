namespace _2048
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.HowTo1 = new System.Windows.Forms.PictureBox();
            this.HowTo2 = new System.Windows.Forms.PictureBox();
            this.HowTo3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HowTo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HowTo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HowTo3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Beige;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 321);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(310, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // pbRight
            // 
            this.pbRight.BackColor = System.Drawing.Color.Transparent;
            this.pbRight.Location = new System.Drawing.Point(185, 254);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(50, 50);
            this.pbRight.TabIndex = 2;
            this.pbRight.TabStop = false;
            this.pbRight.Click += new System.EventHandler(this.pbRight_Click);
            // 
            // pbLeft
            // 
            this.pbLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbLeft.Location = new System.Drawing.Point(115, 254);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(50, 50);
            this.pbLeft.TabIndex = 3;
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.pbLeft_Click);
            // 
            // HowTo1
            // 
            this.HowTo1.Location = new System.Drawing.Point(13, 13);
            this.HowTo1.Name = "HowTo1";
            this.HowTo1.Size = new System.Drawing.Size(310, 235);
            this.HowTo1.TabIndex = 4;
            this.HowTo1.TabStop = false;
            // 
            // HowTo2
            // 
            this.HowTo2.Location = new System.Drawing.Point(350, 13);
            this.HowTo2.Name = "HowTo2";
            this.HowTo2.Size = new System.Drawing.Size(310, 235);
            this.HowTo2.TabIndex = 5;
            this.HowTo2.TabStop = false;
            // 
            // HowTo3
            // 
            this.HowTo3.Location = new System.Drawing.Point(350, 13);
            this.HowTo3.Name = "HowTo3";
            this.HowTo3.Size = new System.Drawing.Size(350, 235);
            this.HowTo3.TabIndex = 6;
            this.HowTo3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 400);
            this.Controls.Add(this.HowTo3);
            this.Controls.Add(this.HowTo2);
            this.Controls.Add(this.HowTo1);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 439);
            this.MinimumSize = new System.Drawing.Size(350, 439);
            this.Name = "HowToPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HowTo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HowTo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HowTo3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox HowTo1;
        private System.Windows.Forms.PictureBox HowTo2;
        private System.Windows.Forms.PictureBox HowTo3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}