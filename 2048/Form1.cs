﻿using System;
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
        TextBox[][] matrix;
        Game game;
        int space = 10;
        int size = 80;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            generateMatrix();
        }
        public Form1(string mode)
        {
            InitializeComponent();
            game = new Game(mode);
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
                }
            }
            btnUndo.Enabled = game.canUndo();
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
                game.updateState("up");
                getGameState();
                return true;
            }
            if (keyData == Keys.Down)
            {
                game.updateState("down");
                getGameState();
                return true;
            }
            if (keyData == Keys.Right)
            {
                game.updateState("right");
                getGameState();
                return true;
            }
            if (keyData == Keys.Left)
            {
                game.updateState("left");
                getGameState();
                return true;
            }
            return base.ProcessDialogKey(keyData);
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
