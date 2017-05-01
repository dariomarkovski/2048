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
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("c:\\Test\\test.txt");
            while((line = file.ReadLine()) != null)
            {
                if (line.Equals(tbUserName.Text))
                {
                    btnContinue.Enabled = true;
                    return;
                }
                else
                {
                    btnContinue.Enabled = false;
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();

            NewGame ng = new NewGame();
            if (ng.ShowDialog() == DialogResult.No)
                this.Show();
            else
                this.Close();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            this.Hide();

            HowToPlay htp = new HowToPlay();       
            if (htp.ShowDialog() == DialogResult.No)
                this.Show();
            else
                this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
