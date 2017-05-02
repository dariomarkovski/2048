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
    public partial class Play : Form, ITheme
    {
        public Play()
        {
            InitializeComponent();
            if (Properties.Settings.Default.savedGame) btnContinue.Enabled = true;
            else btnContinue.Enabled = false;
            setTheme();
        }

        public void setTheme()
        {
            Program.setTheme(this);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();

            NewGame ng = new NewGame();
            if (ng.ShowDialog() == DialogResult.No)
            {
                this.Show();
                if (Properties.Settings.Default.savedGame) btnContinue.Enabled = true;
                else btnContinue.Enabled = false;
                Invalidate();
            }
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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(Properties.Settings.Default.savedMode, Properties.Settings.Default.savedString);
            if (form1.ShowDialog() == DialogResult.No)
                this.Show();
            else
                this.Close();
        }
    }
}
