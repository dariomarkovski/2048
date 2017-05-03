using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class HowToPlay : Form, ITheme
    {
        public int id = 1;
        public int MainX;
        public int MainY;
        public int SecondX;
        public int SecondY;
        public int FirstX;
        public int FirstY;

        public HowToPlay()
        {
            InitializeComponent();
            setTheme();
            DoubleBuffered = true;

            pbLeft.Image = Properties.Resources.left_arrow;
            pbLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLeft.Visible = false;

            pbRight.Image = Properties.Resources.right_arrow;
            pbRight.SizeMode = PictureBoxSizeMode.StretchImage;

            HowTo1.Image = Properties.Resources.HowTo1;
            HowTo1.SizeMode = PictureBoxSizeMode.StretchImage;

            MainX = HowTo1.Location.X;
            MainY = HowTo1.Location.Y;

            SecondX = 363;
            SecondY = HowTo3.Location.Y;

            FirstX = 363;
            FirstY = HowTo2.Location.Y;

            HowTo2.Image = Properties.Resources.HowTo2;
            HowTo2.SizeMode = PictureBoxSizeMode.StretchImage;
            HowTo2.Location = new Point(SecondX, SecondY);

            HowTo3.Image = Properties.Resources.HowTo3;
            HowTo3.SizeMode = PictureBoxSizeMode.StretchImage;
            HowTo3.Size = HowTo2.Size;
            HowTo3.Location = new Point(SecondX, SecondY);
        }

        public void setTheme()
        {
            Program.setTheme(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void pbRight_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pbLeft.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(id == 1)
            {
                int x = HowTo1.Location.X;
                int y = HowTo1.Location.Y;
                int x2 = HowTo2.Location.X;
                int y2 = HowTo2.Location.Y;

                HowTo1.Location = new Point(x - 10, y);
                HowTo2.Location = new Point(x2 - 10, y2);

                if(HowTo2.Location.X <= MainX)
                {
                    id = 2;
                    timer1.Stop();
                }
            }
            else
            {
                id = 3;
                int x = HowTo3.Location.X;
                int y = HowTo3.Location.Y;
                int x2 = HowTo2.Location.X;
                int y2 = HowTo2.Location.Y;

                HowTo3.Location = new Point(x - 10, y);
                HowTo2.Location = new Point(x2 - 10, y2);

                if (HowTo3.Location.X <= MainX)
                {
                    pbRight.Visible = false;
                    timer1.Stop();
                }
            }
        }

        private void pbLeft_Click(object sender, EventArgs e)
        {
            timer2.Start();
            pbRight.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (id == 3)
            {
                int x = HowTo2.Location.X;
                int y = HowTo2.Location.Y;
                int x2 = HowTo3.Location.X;
                int y2 = HowTo3.Location.Y;

                HowTo2.Location = new Point(x + 10, y);
                HowTo3.Location = new Point(x2 + 10, y2);

                if (HowTo2.Location.X >= MainX)
                {
                    id = 2;
                    timer2.Stop();
                }
            }
            else
            {
                id = 1;
                int x = HowTo2.Location.X;
                int y = HowTo2.Location.Y;
                int x2 = HowTo1.Location.X;
                int y2 = HowTo1.Location.Y;

                HowTo2.Location = new Point(x + 10, y);
                HowTo1.Location = new Point(x2 + 10, y2);

                if (HowTo1.Location.X >= MainX)
                {
                    pbLeft.Visible = false;
                    timer2.Stop();
                }
            }
        }
    }
}
