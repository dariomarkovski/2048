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
    public partial class HighScores : Form, ITheme
    {
        public HighScores()
        {
            InitializeComponent();
            setTheme();
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
    }
}
