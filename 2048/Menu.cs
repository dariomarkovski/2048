using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Menu : Form, ITheme
    {
        public Menu()
        {
            InitializeComponent();
            setTheme();
            /*
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "HighScores.sc";
            using (StreamWriter sw = File.AppendText(path))
            {
            }*/
        }

        public void setTheme()
        {
            Program.setTheme(this);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();

            Play play = new Play();
            if (play.ShowDialog() == DialogResult.No)
                this.Show();
            else
                this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();

            Settings s = new Settings();
            if (s.ShowDialog() == DialogResult.No)
            {
                this.Show();
                setTheme();
            }
            else
                this.Close();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            this.Hide();

            HighScores hs = new HighScores();
            if (hs.ShowDialog() == DialogResult.No)
                this.Show();
            else
                this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
