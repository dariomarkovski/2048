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
    public partial class HighScores : Form, ITheme
    {
        public HighScores()
        {
            InitializeComponent();
            setTheme();
            getScores();
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

        private void getScores()
        {
            List<Label> itemsToRemove = new List<Label>();
            foreach (Label label in Controls.OfType<Label>())
            {
                if (label.Name != "Normal" && label.Name != "Ultimate")
                {
                    itemsToRemove.Add(label);
                }
            }

            foreach (Label label in itemsToRemove)
            {
                Controls.Remove(label);
                label.Dispose();
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "HighScores.sc";

            List<Score> HighScores = new List<Score>();
            //bin/Debug!
            try
            {
                using (TextReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!String.IsNullOrWhiteSpace(line))
                        {
                            String[] q = line.Split(null);
                            Console.WriteLine(line);
                            HighScores.Add(new Score(q[0], q[1], q[2]));
                        }
                    }
                }
            }
            catch (Exception ex) { }

            HighScores = HighScores.OrderBy(x => x.mode).ThenBy(x => int.Parse(x.score)).Reverse().ToList();

            int NormalX = Normal.Location.X;
            int NormalY = Normal.Location.Y;

            int UltimateX = Ultimate.Location.X;
            int UltimateY = Ultimate.Location.Y;

            int normal = 0;
            int ultimate = 0;

            for (int i = 0; i < HighScores.Count; i++)
            {
                if (HighScores.ElementAt(i).mode == "normal" && normal < 3)
                {
                    Label l = new Label();
                    l.BackColor = Color.Transparent;
                    l.Text = HighScores.ElementAt(i).name;
                    l.Width = 80;
                    l.ForeColor = Color.White;
                    l.Location = new Point(NormalX - 50, NormalY + 25);
                    l.Font = new Font("Arial", 10);
                    this.Controls.Add(l);
                    Label l2 = new Label();
                    l2.BackColor = Color.Transparent;
                    l2.ForeColor = Color.White;
                    l2.Text = HighScores.ElementAt(i).score;
                    l2.Location = new Point(NormalX + 80, NormalY + 25);
                    l2.Width = 80;
                    l2.Font = new Font("Arial", 10);
                    this.Controls.Add(l2);
                    NormalY += 25;
                    normal++;
                }
                else if (HighScores.ElementAt(i).mode == "ultimate" && ultimate < 3)
                {
                    Label l = new Label();
                    l.BackColor = Color.Transparent;
                    l.Text = HighScores.ElementAt(i).name;
                    l.Width = 80;
                    l.ForeColor = Color.White;
                    l.Location = new Point(NormalX - 50, UltimateY + 25);
                    l.Font = new Font("Arial", 10);
                    this.Controls.Add(l);
                    Label l2 = new Label();
                    l2.BackColor = Color.Transparent;
                    l2.Width = 80;
                    l2.Font = new Font("Arial", 10);
                    l2.ForeColor = Color.White;
                    l2.Text = HighScores.ElementAt(i).score;
                    l2.Location = new Point(NormalX + 80, UltimateY + 25);
                    this.Controls.Add(l2);
                    UltimateY += 25;
                    ultimate++;
                }
                else if (normal >= 3 && ultimate >= 3)
                    break;
            }
        }
    }
}
