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
    public partial class Settings : Form, ITheme
    {
        public Settings()
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

        private void ddlThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string path = @"C:\Users\dario\th2048.th";
            File.WriteAllText(path, ddlThemes.SelectedItem.ToString());*/
            Properties.Settings.Default.theme = ddlThemes.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            setTheme();
        }
    }
}
