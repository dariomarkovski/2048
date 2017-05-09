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
    
    public partial class Form1 : Form, ITheme
    {
        TextBox[][] matrix;
        Game game;
        int space = 10;
        int size = 80;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            generateMatrix();
            setTheme();
            DoubleBuffered = true;
        }
        public Form1(string mode)
        {
            InitializeComponent();
            game = new Game(mode);
            generateMatrix();
            setTheme();
            DoubleBuffered = true;
        }
        public Form1(string mode, string _matrix, int score)
        {
            InitializeComponent();
            game = new Game(mode, _matrix, score);
            generateMatrix();
            setTheme();
            DoubleBuffered = true;
        }
        public void setTheme()
        {
            Program.setTheme(this);
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
            getGameState();
        }
        private void getGameState()
        {
            string [][] matrixValues = game.getState();
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j].Text = matrixValues[i][j];
                    switch (matrix[i][j].Text)
                    {
                        case "":
                            matrix[i][j].BackColor = SystemColors.Control;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "2":
                            matrix[i][j].BackColor = Color.Wheat;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "4":
                            matrix[i][j].BackColor = Color.PeachPuff;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "8":
                            matrix[i][j].BackColor = Color.Tan;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "16":
                            matrix[i][j].BackColor = Color.Crimson;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "32":
                            matrix[i][j].BackColor = Color.DarkRed;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "64":
                            matrix[i][j].BackColor = Color.LightYellow;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "128":
                            matrix[i][j].BackColor = Color.Yellow;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "256":
                            matrix[i][j].BackColor = Color.Gold;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "512":
                            matrix[i][j].BackColor = Color.Pink;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "1024":
                            matrix[i][j].BackColor = Color.Magenta;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "2048":
                            matrix[i][j].BackColor = Color.DarkMagenta;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "4096":
                            matrix[i][j].BackColor = Color.PaleGreen;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "8192":
                            matrix[i][j].BackColor = Color.SpringGreen;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 20);
                            break;
                        case "16384":
                            matrix[i][j].BackColor = Color.Lime;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 18);
                            break;
                        case "32768":
                            matrix[i][j].BackColor = Color.Turquoise;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 18);
                            break;
                        case "65536":
                            matrix[i][j].BackColor = Color.DeepSkyBlue;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 18);
                            break;
                        case "131072":
                            matrix[i][j].BackColor = Color.DarkBlue;
                            matrix[i][j].Font = new Font(matrix[i][j].Font.FontFamily, 16);
                            break;

                    }
                }
            }
            btnUndo.Enabled = game.canUndo();
            lblScore.Text = game.score.ToString();
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            game.undoMove();
            getGameState();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                return move("up");
            }
            if (keyData == Keys.Down)
            {
                return move("down");
            }
            if (keyData == Keys.Right)
            {
                return move("right");
            }
            if (keyData == Keys.Left)
            {
                return move("left");
            }
            return base.ProcessDialogKey(keyData);
        }
        private bool move(string move)
        {
            game.updateState(move);
            getGameState();
            if (game.isFinished() || game.won)
            {
                finishGame();
            }
            return true;
        }
        private void finishGame()
        {
            SaveDialog sd = new SaveDialog(game.score.ToString(), game.mode);
            sd.ShowDialog();
            btnBack.PerformClick();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            game.saveGame();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            game.saveGame();
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            this.ProcessDialogKey(Keys.Up);
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.ProcessDialogKey(Keys.Left);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            this.ProcessDialogKey(Keys.Down);
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            this.ProcessDialogKey(Keys.Right);
        }
    }
}
