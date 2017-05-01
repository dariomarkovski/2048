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
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        TextBox[][] matrix;
        int space = 10;
        int size = 80;

        public Form1()
        {
            InitializeComponent();
            generateMatrix();
        }
        private void generateMatrix()
        {
            matrix = new TextBox[4][];
            for (int i = 0; i < 4; i++)
            {
                matrix[i] = new TextBox[4];
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i][j] = new TextBox();
                    matrix[i][j].Location = new Point((j + 1) * space + j * size, (i + 1) * space + i * size);
                    matrix[i][j].Multiline = true;
                    matrix[i][j].Size = new Size(80, 80);
                    matrix[i][j].Enabled = false;
                    matrix[i][j].ForeColor = Color.Black;
                    matrix[i][j].Visible = true;
                    matrix[i][j].TextAlign = HorizontalAlignment.Center;
                    matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                    this.Controls.Add(matrix[i][j]);
                }
            }
            generateRandom();
        }
        private void generateRandom()
        {
            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!matrix[i][j].Text.Equals(""))
                        counter++;
                }
            }
            label1.Text = counter.ToString();
            if (counter == 16)
            {
                label1.Text = "can't";
                return;
            }
            while (true)
            {
                int row = rnd.Next(0, 4);
                int col = rnd.Next(0, 4);
                label2.Text = row + " " + col;
                if (matrix[row][col].Text.Equals(""))
                {
                    matrix[row][col].Text = "2";
                    break;
                }
            }
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.G)
            {
                generateRandom();
            }
            if (e.KeyCode == Keys.Up)
            {
                bool moved = false;
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (matrix[i][k].Text.Equals(""))
                        {
                            for (int j = i + 1; j < 4; j++)
                            {
                                if (!matrix[j][k].Text.Equals(""))
                                {
                                    matrix[i][k].Text = matrix[j][k].Text;
                                    matrix[j][k].Text = "";
                                    moved = true;
                                    break;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (!matrix[i][k].Text.Equals("") && matrix[i][k].Text.Equals(matrix[i + 1][k].Text))
                        {
                            matrix[i][k].Text = (Convert.ToInt32(matrix[i][k].Text) * 2).ToString();
                            matrix[i + 1][k].Text = "";
                            for (int j = i + 1; j < 3; j++)
                            {
                                matrix[j][k].Text = matrix[j + 1][k].Text;
                                matrix[j + 1][k].Text = "";
                            }
                            moved = true;
                        }
                    }
                }
                if (moved) generateRandom();
            }
            if(e.KeyCode == Keys.Down)
            {
                bool moved = false;
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 3; i > 0; i--)
                    {
                        if (matrix[i][k].Text.Equals(""))
                        {
                            for (int j = i - 1; j >= 0 ; j--)
                            {
                                if (!matrix[j][k].Text.Equals(""))
                                {
                                    matrix[i][k].Text = matrix[j][k].Text;
                                    matrix[j][k].Text = "";
                                    moved = true;
                                    break;
                                }
                            }
                        }
                    }
                    for (int i = 3; i > 0; i--)
                    {
                        if (!matrix[i][k].Text.Equals("") && matrix[i][k].Text.Equals(matrix[i - 1][k].Text))
                        {
                            matrix[i][k].Text = (Convert.ToInt32(matrix[i][k].Text) * 2).ToString();
                            matrix[i - 1][k].Text = "";
                            for (int j = i - 1; j >= 1; j--)
                            {
                                matrix[j][k].Text = matrix[j - 1][k].Text;
                                matrix[j - 1][k].Text = "";
                            }
                            moved = true;
                        }
                    }
                }
                if (moved) generateRandom();
            }
            if (e.KeyCode == Keys.Right)
            {
                bool moved = false;
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 3; i > 0; i--)
                    {
                        if (matrix[k][i].Text.Equals(""))
                        {
                            for (int j = i - 1; j >= 0; j--)
                            {
                                if (!matrix[k][j].Text.Equals(""))
                                {
                                    matrix[k][i].Text = matrix[k][j].Text;
                                    matrix[k][j].Text = "";
                                    moved = true;
                                    break;
                                }
                            }
                        }
                    }
                    for (int i = 3; i > 0; i--)
                    {
                        if (!matrix[k][i].Text.Equals("") && matrix[k][i].Text.Equals(matrix[k][i-1].Text))
                        {
                            matrix[k][i].Text = (Convert.ToInt32(matrix[k][i].Text) * 2).ToString();
                            matrix[k][i-1].Text = "";
                            for (int j = i - 1; j >= 1; j--)
                            {
                                matrix[k][j].Text = matrix[k][j-1].Text;
                                matrix[k][j-1].Text = "";
                            }
                            moved = true;
                        }
                    }
                }
                if (moved) generateRandom();
            }
            if (e.KeyCode == Keys.Left)
            {
                bool moved = false;
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (matrix[k][i].Text.Equals(""))
                        {
                            for (int j = i + 1; j < 4; j++)
                            {
                                if (!matrix[k][j].Text.Equals(""))
                                {
                                    matrix[k][i].Text = matrix[k][j].Text;
                                    matrix[k][j].Text = "";
                                    moved = true;
                                    break;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (!matrix[k][i].Text.Equals("") && matrix[k][i].Text.Equals(matrix[k][i + 1].Text))
                        {
                            matrix[k][i].Text = (Convert.ToInt32(matrix[k][i].Text) * 2).ToString();
                            matrix[k][i + 1].Text = "";
                            for (int j = i + 1; j < 3; j++)
                            {
                                matrix[k][j].Text = matrix[k][j + 1].Text;
                                matrix[k][j + 1].Text = "";
                            }
                            moved = true;
                        }
                    }
                }
                if (moved) generateRandom();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Zacuvaj Napredok?", "Izlezi od igra?", MessageBoxButtons.YesNoCancel);
            if(window == DialogResult.Yes)
            {
                MessageBox.Show("Progress is saved!");
            }
            else if(window == DialogResult.No)
            {
                MessageBox.Show("BYE FELICIA!");
            }
            e.Cancel = (window == DialogResult.Cancel);
        }
    }
}
