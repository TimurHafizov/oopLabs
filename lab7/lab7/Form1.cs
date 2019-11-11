using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab7;

namespace lab7
{
    public partial class Form1 : Form
    {
        Vector vector = new Vector();
        Matrix matrix = new Matrix();
        public Form1()
        {
            InitializeComponent();
        }

        private void OutputArray()
        {
            //clear.Enabled = true;
            outputBox.Text += "{ ";
            for (int i = 0; i < vector.Length(); i++)
            {
                
                    outputBox.Text += vector[i].ToString();
                    outputBox.Text += "; ";
                
                
            }
            if (vector.Length() == 0)
                outputBox.Text += " Массив пуст! ";
            outputBox.Text += "}\nРазмер массива: " + vector.Length() + "\n\n";
        }

        private void Clear(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            outputBox.Text = "";
        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void BlockUnblockButtons()
        {
            if (!vector.Empty() == true)
            {
                RandomInputVector.Enabled = false;
                PrintVector.Enabled = false;
                DeleteElOfVector.Enabled = false;
                ClearVector.Enabled = false;
            }
            else
            {
                RandomInputVector.Enabled = true;
                PrintVector.Enabled = true;
                DeleteElOfVector.Enabled = true;
                ClearVector.Enabled = true;
            }
        }
        private void NewMas(object sender, EventArgs e)
        {
            Clear();
            BlockUnblockButtons();
            bool ok = true;
            int size = 0;
            if (Int32.TryParse(SizeOfVector.Text, out size))
            {
                if (size >= 0)
                {
                    vector = new Vector(size);
                    ok = true;
                    //OutputArray();
                }
                else
                {
                    ErrorMsg.Text = "Ошибка. Повторите ввод!";
                    //OutErr(outArrBox, clear);
                    ok = false;
                }
            }
            else
            {
                ErrorMsg.Text = "Ошибка. Повторите ввод!";
                ok = false;
                //OutErr(outArrBox, clear);
            }
            //if (vector.Empty())
            //{
            //    randomInputButton.Enabled = false;
            //    goalButton.Enabled = false;
            //}
            //else
            //{
            //    randomInputButton.Enabled = true;
            //    goalButton.Enabled = true;
            //}
            if (ok)
            {
                OutputArray();
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RandomInputVector_Click(object sender, EventArgs e)
        {
            vector.RandomInput();
            OutputArray();
        }

        private void PrintVector_Click(object sender, EventArgs e)
        {
            OutputArray();
        }

        private void Size_TextChanged(object sender, EventArgs e)
        {
            if (SizeOfVector.Text == "")
            {
                NewVector.Enabled = false;
            }
            else
            {
                NewVector.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewVector.Enabled = false;
            RandomInputVector.Enabled = false;
            PrintVector.Enabled = false;
            DeleteElOfVector.Enabled = false;
            ClearVector.Enabled = false;
            Proverka();
            MakeMatrix.Enabled = false;
            RandomInputMatrix.Enabled = false;
            PrintMatrix.Enabled = false;
            AddColomn.Enabled = false;
            ClearMatrix.Enabled = false;
            Proverka2();

        }

        private void DeleteElOfVector_Click(object sender, EventArgs e)
        {
            //FormDeleteElementsOfVector f3 = new FormDeleteElementsOfVector(this);
            //f3.ShowDialog();
            if (textBoxN.Text == "" || textBoxK.Text == "")
            {
                ErrorMsg2.Text = "Заполните поля ввода!";
            }
            else
            {
                try
                {
                    FunDeleted();
                }
                catch(Exception) {
                    ErrorMsg2.Text = "Ошибка, повторите ввод!";
                }
                if (vector.Length() == 0)
                {
                    ErrorMsg2.Text = "Массив пуст!";
                }
                
            }
            
            
        }
        void ErrorMsg2AndBlock()
        {
            ErrorMsg2.Text = "Ошибка. Повторите ввод!";
            DeleteElOfVector.Enabled = false;
        }
        private void FunDeleted()
        {
            bool ok = true;
            int size = vector.Length();
            int k = 0;
            if (Int32.TryParse(textBoxK.Text, out k))
            {
                if (ReadRange(k, size, 1))
                {
                    ok = true;
                    //OutputArray();
                }
                else
                {
                    ErrorMsg2AndBlock();
                    //OutErr(outArrBox, clear);
                    ok = false;
                }
            }
            else
            {
                ErrorMsg2AndBlock();
                ok = false;
                //OutErr(outArrBox, clear);
            }

            int n = 0;
            if (Int32.TryParse(textBoxN.Text, out n))
            {
                if (ReadRange(n, size, 1))
                {
                    ok = true;
                    //OutputArray();
                }
                else
                {
                    ErrorMsg2AndBlock();
                    //OutErr(outArrBox, clear);
                    ok = false;
                }
            }
            else
            {
                ErrorMsg2AndBlock();
                ok = false;
                //OutErr(outArrBox, clear);
            }
            if (k - 1 + n > size)
            {
                ErrorMsg2AndBlock();
            }
            else {
                vector.DeleteElements(k - 1, n);
                OutputArray();
            }
            
        }
        static bool ReadRange(int choise, int max = 1000, int min = 1)
        {

            bool ok = true;
            if (choise < min)
            {
                ok = false;
            }
            if (choise > max)
            {
                ok = false;
            }
            return ok;
        }
        public int GetLength()
        {
            return vector.Length();
        }
        public void InputZnach(int k, int n)
        {
            vector.DeleteElements(k, n);
        }

        private void TextBoxN_TextChanged(object sender, EventArgs e)
        {
            if (textBoxN.Text == "")
            {
                DeleteElOfVector.Enabled = false;
            }
            else
            {
                DeleteElOfVector.Enabled = true;
            }
        }
        void Proverka()
        {
            if (textBoxK.Text == "")
            {
                DeleteElOfVector.Enabled = false;
            }
            else
            {
                DeleteElOfVector.Enabled = true;
            }
            if (textBoxN.Text == "")
            {
                DeleteElOfVector.Enabled = false;
            }
            else
            {
                DeleteElOfVector.Enabled = true;
            }
        }
        void Proverka2()
        {
            if (textBoxRow.Text == "")
            {
                MakeMatrix.Enabled = false;
            }
            else
            {
                MakeMatrix.Enabled = true;
            }
            if (textBoxCol.Text == "")
            {
                MakeMatrix.Enabled = false;
            }
            else
            {
                MakeMatrix.Enabled = true;
            }
        }
        private void TextBoxK_TextChanged(object sender, EventArgs e)
        {
            if (textBoxK.Text == "")
            {
                DeleteElOfVector.Enabled = false;
            }
            else
            {
                DeleteElOfVector.Enabled = true;
            }
        }


        void OutputMatrix()
        {
            string s = "";
            ClearMatrix.Enabled = true;
            OutMatrix.Text += "";
            for (int i = 0; i < matrix.GetStr(); i++)
            {
                OutMatrix.Text += "{";
                for (int j = 0; j < matrix.getClm(); j++)
                {
                    OutMatrix.Text += matrix[i, j] + "\t";
                }
               
                s = OutMatrix.Text;
                int x1 = s.Length - 1;
                s = s.Remove(x1);
                OutMatrix.Text = s;
                OutMatrix.Text += "}\n";
            }
            OutMatrix.Text += "Размер Массива: " + matrix.GetStr() + " строк, " + matrix.getClm() + " столбцов\n\n";
        }



        private void Label7_Click(object sender, EventArgs e)
        {

        }
        
        private void MakeMatrix_Click(object sender, EventArgs e)
        {
            int row = 0, col = 0;
            if (int.TryParse(textBoxRow.Text, out row))
            {
                if (int.TryParse(textBoxCol.Text, out col))
                    if (col > 0 && row > 0)
                    {
                        matrix = new Matrix(row, col);
                        OutputMatrix();

                        ErrorMatrix.Text = "";
                    }
                    else ErrorMatrix.Text = "Нулевое значение - это ошибка\nПовторите ввод!";
                else ErrorMatrix.Text = "Кол-во столбцов таким не может быть\nПовторите ввод!";
            }
            else
            {
                ErrorMatrix.Text = "Кол-во сстрок таким не может быть\nПовторите ввод!";
            }
            if (matrix.Empty())
            {
                RandomInputMatrix.Enabled = false;
                //tDgoalButton.Enabled = false;
            }
            else
            {
                RandomInputMatrix.Enabled = true;
            }
            ClearMatrix.Enabled = true;
            PrintMatrix.Enabled = true;
            AddColomn.Enabled = true;
        }

        private void RandomInputMatrix_Click(object sender, EventArgs e)
        {
            matrix.RandomInput();
            OutputMatrix();
        }

        private void PrintMatrix_Click(object sender, EventArgs e)
        {
            OutputMatrix();
        }

        private void ClearMatrix_Click(object sender, EventArgs e)
        {
            OutMatrix.Text = "";
        }

        private void AddColomn_Click(object sender, EventArgs e)
        {
            matrix.AddColomn();
            OutputMatrix();
        }

        private void TextBoxCol_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRow.Text == "") { if (textBoxCol.Text == "") MakeMatrix.Enabled = false; }
            else MakeMatrix.Enabled = true;
        }

        private void TextBoxRow_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCol.Text == "") { if (textBoxRow.Text == "") MakeMatrix.Enabled = false; }
            else MakeMatrix.Enabled = true;
        }
    }
}
