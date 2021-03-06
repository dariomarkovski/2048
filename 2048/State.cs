﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2048
{
    public class State
    {
        public string[][] matrix { get; set; }
        private Random rnd;
        public State()
        {
            matrix = new string[4][];
            for(int i = 0; i < 4; i++)
            {
                matrix[i] = new string[4];
                for(int j = 0; j < 4; j++)
                {
                    matrix[i][j] = "";
                }
            }
            rnd = new Random();
            generateRandom();
        }
        public State(State other)
        {
            matrix = new string[4][];
            for (int i = 0; i < 4; i++)
            {
                matrix[i] = new string[4];
                for (int j = 0; j < 4; j++)
                {
                    matrix[i][j] = other.matrix[i][j];
                }
            }
            rnd = new Random();
        }
        public State(string _matrix)
        {
            string[] strSplit = _matrix.Split('_');
            matrix = new string[4][];
            for (int i = 0; i < 4; i++)
            {
                matrix[i] = new string[4];
                for (int j = 0; j < 4; j++)
                {
                    string str = strSplit[i * 4 + j].ToString();
                    if (str.Equals(" "))
                        matrix[i][j] = "";
                    else
                        matrix[i][j] = str;
                }
            }
            rnd = new Random();
        }
        private void generateRandom()
        {
            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!(matrix[i][j].Equals("")))
                        counter++;
                }
            }
            if (counter == 16)
            {
                return;
            }

            int prob = rnd.Next(1, 11);
            string valueToInsert = "2";
            if (prob > 8) valueToInsert = "4";
                

            while (true)
            {
                int row = rnd.Next(0, 4);
                int col = rnd.Next(0, 4);
                if (matrix[row][col].Equals(""))
                {
                    matrix[row][col] = valueToInsert;
                    break;
                }
            }
        }
        public int move(string key) {
            int score = 0;
            if (key.Equals("up"))
            {
                bool moved = false;
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (matrix[i][k].Equals(""))
                        {
                            for (int j = i + 1; j < 4; j++)
                            {
                                if (!matrix[j][k].Equals(""))
                                {
                                    matrix[i][k] = matrix[j][k];
                                    matrix[j][k] = "";
                                    moved = true;
                                    break;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (!matrix[i][k].Equals("") && matrix[i][k].Equals(matrix[i + 1][k]))
                        {
                            score += Convert.ToInt32(matrix[i][k]) * 2;
                            matrix[i][k] = (Convert.ToInt32(matrix[i][k]) * 2).ToString();
                            matrix[i + 1][k] = "";
                            for (int j = i + 1; j < 3; j++)
                            {
                                matrix[j][k] = matrix[j + 1][k];
                                matrix[j + 1][k] = "";
                            }
                            moved = true;
                        }
                    }
                }
                if (moved) generateRandom();
            }
            if (key.Equals("down"))
            {
                bool moved = false;
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 3; i > 0; i--)
                    {
                        if (matrix[i][k].Equals(""))
                        {
                            for (int j = i - 1; j >= 0; j--)
                            {
                                if (!matrix[j][k].Equals(""))
                                {
                                    matrix[i][k] = matrix[j][k];
                                    matrix[j][k] = "";
                                    moved = true;
                                    break;
                                }
                            }
                        }
                    }
                    for (int i = 3; i > 0; i--)
                    {
                        if (!matrix[i][k].Equals("") && matrix[i][k].Equals(matrix[i - 1][k]))
                        {
                            score += Convert.ToInt32(matrix[i][k]) * 2;
                            matrix[i][k] = (Convert.ToInt32(matrix[i][k]) * 2).ToString();
                            matrix[i - 1][k] = "";
                            for (int j = i - 1; j >= 1; j--)
                            {
                                matrix[j][k] = matrix[j - 1][k];
                                matrix[j - 1][k] = "";
                            }
                            moved = true;
                        }
                    }
                }
                if (moved) generateRandom();
            }
            if (key.Equals("right"))
            {
                bool moved = false;
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 3; i > 0; i--)
                    {
                        if (matrix[k][i].Equals(""))
                        {
                            for (int j = i - 1; j >= 0; j--)
                            {
                                if (!matrix[k][j].Equals(""))
                                {
                                    matrix[k][i] = matrix[k][j];
                                    matrix[k][j] = "";
                                    moved = true;
                                    break;
                                }
                            }
                        }
                    }
                    for (int i = 3; i > 0; i--)
                    {
                        if (!matrix[k][i].Equals("") && matrix[k][i].Equals(matrix[k][i - 1]))
                        {
                            score += Convert.ToInt32(matrix[k][i]) * 2;
                            matrix[k][i] = (Convert.ToInt32(matrix[k][i]) * 2).ToString();
                            matrix[k][i - 1] = "";
                            for (int j = i - 1; j >= 1; j--)
                            {
                                matrix[k][j] = matrix[k][j - 1];
                                matrix[k][j - 1] = "";
                            }
                            moved = true;
                        }
                    }
                }
                if (moved) generateRandom();
            }
            if (key.Equals("left"))
            {
                bool moved = false;
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (matrix[k][i].Equals(""))
                        {
                            for (int j = i + 1; j < 4; j++)
                            {
                                if (!matrix[k][j].Equals(""))
                                {
                                    matrix[k][i] = matrix[k][j];
                                    matrix[k][j] = "";
                                    moved = true;
                                    break;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (!matrix[k][i].Equals("") && matrix[k][i].Equals(matrix[k][i + 1]))
                        {
                            score += Convert.ToInt32(matrix[k][i]) * 2;
                            matrix[k][i] = (Convert.ToInt32(matrix[k][i]) * 2).ToString();
                            matrix[k][i + 1] = "";
                            for (int j = i + 1; j < 3; j++)
                            {
                                matrix[k][j] = matrix[k][j + 1];
                                matrix[k][j + 1] = "";
                            }
                            moved = true;
                        }
                    }
                }
                if (moved) generateRandom();
            }
            return score;
        }
        public bool wonValue()
        {
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[i][j].Equals("2048")) return true;
                }
            }
            return false;
        }
        public bool isFinished() {
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if( matrix[i][j].Equals("") || ( (i > 0) && matrix[i - 1][j].Equals(matrix[i][j]) ) 
                        || ( (i < matrix.Length - 1) && matrix[i + 1][j].Equals(matrix[i][j]) ) || ( (j > 0) && matrix[i][j - 1].Equals(matrix[i][j]))
                        || ( (j < matrix[i].Length - 1) && matrix[i][j + 1].Equals(matrix[i][j]) ))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool canMove(string key)
        {
            if (key.Equals("up"))
            {
                for (int k = 0; k < 4; k++)
                {
                    for(int i = 3; i >= 1; i--)
                    {
                        if (matrix[i][k].Equals("")) continue;
                        for(int j = i -1; j >= 0; j--)
                        {
                            if (!matrix[j][k].Equals("") && !matrix[j][k].Equals(matrix[i][k])) break;
                            return true;
                        }
                    }
                }
            }
            if (key.Equals("down"))
            {
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (matrix[i][k].Equals("")) continue;
                        for (int j = i + 1; j < 4; j++)
                        {
                            if (!matrix[j][k].Equals("") && !matrix[j][k].Equals(matrix[i][k])) break;
                            return true;
                        }
                    }
                }
            }
            if (key.Equals("right"))
            {
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (matrix[k][i].Equals("")) continue;
                        for (int j = i + 1; j < 4; j++)
                        {
                            if (!matrix[k][j].Equals("") && !matrix[k][j].Equals(matrix[k][i])) break;
                            return true;
                        }
                    }
                }
            }
            if (key.Equals("left"))
            {
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 3; i >= 1; i--)
                    {
                        if (matrix[k][i].Equals("")) continue;
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (!matrix[k][j].Equals("") && !matrix[k][j].Equals(matrix[k][i])) break;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public string getStringFormat()
        {
            string returnString = "";
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j].Equals("")) returnString += " ";
                    else returnString += matrix[i][j];
                    returnString += "_";
                }
            }
            return returnString;
        }
    }
}
