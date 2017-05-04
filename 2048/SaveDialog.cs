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
    public partial class SaveDialog : Form
    {
        public SaveDialog()
        {
            InitializeComponent();
        }

        private string mode { get; set; }
        private string score { get; set; }

        public SaveDialog(string s, string m )
        {
            mode = m;
            score = s;
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Trim(). Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "You must enter a name to save");
            }
            else if (tbName.Text.Contains(" "))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "No blank spaces");
            }
            else
                errorProvider1.SetError(tbName, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "HighScores.sc";
            using (StreamWriter sw = File.AppendText(path))
            {
                String line = "\r\n";
                line += tbName.Text;
                line += " " + score + " " + mode;
                sw.Write(line);
            }
            this.Close();
        }
    }
}
