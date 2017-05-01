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
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnNormal, "Play until you get 2048, NO UNDO!");
            ToolTip ToolTip2 = new ToolTip();
            ToolTip2.SetToolTip(this.btnUltimate, "Play until you lose, 1 UNDO!");
            ToolTip ToolTip3 = new ToolTip();
            ToolTip3.SetToolTip(this.btnPractice, "5 UNDOS!!!");
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1("normal");
            form1.ShowDialog();

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnUltimate_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1("ultimate");
            form1.ShowDialog();

            this.Close();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1("practice");
            form1.ShowDialog();

            this.Close();
        }
    }
}
