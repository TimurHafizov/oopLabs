﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace lab7
{
    class Vector
    {
        private int[] arr;
        Random rnd = new Random();

        public Vector(int size = 0)
        {
            arr = new int[size];
        }
        public bool Empty()
        {
            if (arr.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RandomInput()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
            }
        }

        public void DeleteElements(int K /*с какого элемента удалим*/, int N /*сколько удалим*/)
        {
            int size = arr.Length - N;
            int[] newArr = new int[size];
            DeleteEl(ref newArr, K, N);
            this.arr = newArr;
        }
        public void DeleteEl(ref int[] newMas, int K, int N)
        {
            if (newMas.Length != 0)
            {
                int count = 0;
                for (int i = 0; i < K; i++)
                {
                    newMas[count] = arr[i];
                    count++;
                }
                for (int i = K + N; i < arr.Length; i++)
                {
                    newMas[count] = arr[i];
                    count++;
                }
            }
        }

        public int Length()
        {
            return arr.Length;
        }

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

    }
    class Matrix
    {
        private int[,] arr;
        Random rnd = new Random();
        int row, col;
        public Matrix(int row = 0, int col = 0)
        {
            this.arr = new int[row, col];
            this.row = row;
            this.col = col;
        }

        public void RandomInput(int begin = 0)
        {
            for (int i = begin; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = rnd.Next(1, 11);
                }
            }
        }

        public void AddColomn()
        {

            int newSizeColumn = col + col / 2;
            int[,] newArr = new int[row, newSizeColumn];
            RandomInputNoClass(ref newArr, row, newSizeColumn);
            int newSizeColumn2 = col / 2;
            int[,] newArr2 = new int[row, newSizeColumn2];
            RandomInputNoClass(ref newArr2, row, newSizeColumn2);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < newSizeColumn; j++)
                {
                    if (2 * j <= col && 3 * j < newSizeColumn)
                    {
                        newArr[i, 3 * j] = arr[i, 2 * j];
                    }
                }
            }
            //chet
            for (int i = 0; i < row; i++)
            {
                for (int j = 1; j < newSizeColumn; j++)
                {
                    if (2 * j - 1 <= col && 3 * j - 2 < newSizeColumn)
                    {
                        newArr[i, 3 * j - 2] = arr[i, 2 * j - 1];
                    }
                }
            }
            //1243567
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < newSizeColumn; j++)
                {
                    if (j <= newSizeColumn2 && 3 * j + 2 <= newSizeColumn - 1)
                    {
                        newArr[i, 3 * j + 2] = newArr2[i, j];
                    }
                }
            }

            this.col = newSizeColumn;
            this.arr = newArr;
        }
        public int[,] MakeMatrix(int[,] arrr, int row, int col)
        {
            arrr = new int[row, col];
            return arrr;
        }
        public void RandomInputNoClass(ref int[,] arrr, int roww, int coll)
        {
            for (int i = 0; i < roww; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    arrr[i, j] = rnd.Next(1, 10);
                }
            }
        }

        public bool Empty()
        {
            if (arr.Length == 0) return true;
            else return false;
        }
        public int GetStr() { return row; }
        public int getClm() { return col; }
        public int this[int i, int j]
        {
            get
            {
                return arr[i, j];
            }
            set
            {
                arr[i, j] = value;
            }
        }

        


    }
    public class Jagarray
    {
        static Random rand = new Random();
        int[][] jag;

        void CreateJagArray()
        {
            for (int i = 0; i < jag.Length; i++)
            {
                int colomn = rand.Next(1, 10);
                jag[i] = new int[colomn];
            }
        }
        public Jagarray(int lines = 0)
        {
            jag = new int[lines][];
            CreateJagArray();
        }

        public int GetStr() { return jag.Length; }
        public int[] this[int i]
        {
            get
            {
                return jag[i];
            }

        }
        public int this[int i, int j]
        {
            get
            {
                return jag[i][j];
            }
        }
        public void RandomInput()
        {
            for (int i = 0; i < jag.Length; i++)
            {
                for (int j = 0; j < jag[i].Length; j++)
                {
                    jag[i][j] = rand.Next(1, 10);
                }
            }
        }


        public void ChoiceDelete(int n, int k)
        {
            int lines = jag.Length;
            //Console.WriteLine("После какой строки будем добавлять строки?n");
            //Console.WriteLine("Сколько строк добавить? k");
            int lines2 = k + lines;
            int[][] jag2 = new int[lines2][];
            CreateNewJagArray(ref jag, ref jag2, lines, lines2, n, k);
            jag = jag2;
        }
        private void CreateNewJagArray(ref int[][] jag, ref int[][] jag2, int lines, int lines2, int n, int k)
        {
            for (int i = 0; i < n; i++)
            {
                int colomn = jag[i].Length;
                jag2[i] = new int[colomn];
                for (int j = 0; j < colomn; j++)
                {
                    jag2[i][j] = jag[i][j];
                }
            }
            for (int i = n; i <= n + k - 1; i++)
            {
                int colomn = rand.Next(1, 10);
                jag2[i] = new int[colomn];
                for (int j = 0; j < colomn; j++)
                {
                    jag2[i][j] = rand.Next(1, 10);
                }
            }
            for (int i = n + k; i < lines2; i++)
            {
                int colomn = jag[i - k].Length;
                jag2[i] = new int[colomn];
                for (int j = 0; j < colomn; j++)
                {
                    jag2[i][j] = jag[i - k][j];
                }
            }
        }
        public void CreateJagFromFile(int[] x)
        {
            for (int i = 0; i < jag.Length; i++)
            {
                int colomn = x[i];
                jag[i] = new int[colomn];
            }
        }
        public bool Empty()
        {
            if (jag.Length == 0) return true;
            else return false;
        }

        

    }
}

