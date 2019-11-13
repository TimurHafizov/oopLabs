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
using Microsoft.VisualBasic;
using System.IO;

namespace lab7
{
    public partial class Form1 : Form
    {
        Vector vector = new Vector();
        Matrix matrix = new Matrix();
        Jagarray jag = new Jagarray();
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
            if (vector.Empty() == true)
            {
                RandomInputVector.Enabled = false;
                PrintVector.Enabled = false;
                DeleteElOfVector.Enabled = false;
                ClearVector.Enabled = false;
                UserFillVector.Enabled = false;
                SaveFileVector.Enabled = false;
                ReadFileVector.Enabled = false;
            }
            else
            {
                SaveFileVector.Enabled = true;
                ReadFileVector.Enabled = true;
                RandomInputVector.Enabled = true;
                PrintVector.Enabled = true;
                DeleteElOfVector.Enabled = true;
                ClearVector.Enabled = true;
                UserFillVector.Enabled = true;
            }
        }
        void ShowError(string s = "Ошибка. Повторите ввод!")
        {
            MessageBox.Show(s);
        }

        void SizeOfVectorDefault()
        {
            SizeOfVector.Text = "";
            SizeOfVector.Focus();
        }


        void DeleteVector()
        {
            vector.DeleteElements(1, vector.Length());
            Proverka();
        }

        private void NewMas(object sender, EventArgs e)
        {
            DeleteVector();
            Clear();
            BlockUnblockButtons();
            bool ok = true;
            int size = 0;
            if (Int32.TryParse(SizeOfVector.Text, out size))
            {
                if (size > 0)
                {
                    vector = new Vector(size);
                    ok = true;
                }
                else
                {
                    ShowError();
                    SizeOfVectorDefault();
                    ok = false;
                }
            }
            else
            {
                ShowError();
                SizeOfVectorDefault();
                ok = false;
                //OutErr(outArrBox, clear);
            }
            if (ok)
            {
                OutputArray();
                BlockUnblockButtons();
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
            UserFillVector.Enabled = false;
            PrintVector.Enabled = false;
            DeleteElOfVector.Enabled = false;
            ClearVector.Enabled = false;
            SaveFileVector.Enabled = false;
            ReadFileVector.Enabled = false;
            Proverka();
            MakeMatrix.Enabled = false;
            RandomInputMatrix.Enabled = false;
            PrintMatrix.Enabled = false;
            AddColomn.Enabled = false;
            ClearMatrix.Enabled = false;
            UserFillMatrix.Enabled = false;
            SaveFileMatrix.Enabled = false;
            ReadFileMatrix.Enabled = false;
            Proverka2();
            MakeJag.Enabled = false;
            RandomInputJag.Enabled = false;
            PrintJag.Enabled = false;
            AddJag.Enabled = false;
            ClearJag.Enabled = false;
            UzerFillJag.Enabled = false;
            SaveFIleJag.Enabled = false;
            ReadFileJag.Enabled = false;
            Proverka3();

        }

        private void DeleteElOfVector_Click(object sender, EventArgs e)
        {
            //FormDeleteElementsOfVector f3 = new FormDeleteElementsOfVector(this);
            //f3.ShowDialog();
            if (textBoxN.Text == "" || textBoxK.Text == "")
            {
                ShowError("Заполните поля ввода!");
            }
            else
            {
                try
                {
                    FunDeleted();
                }
                catch (Exception)
                {
                    ShowError("Ошибка, повторите ввод!");
                }
                if (vector.Length() == 0)
                {
                    ShowError("Массив пуст!");
                }

            }

        }
        void ErrorMsg2AndBlock()
        {
            ShowError("Ошибка. Повторите ввод!");
            DeleteElOfVector.Enabled = false;
        }
        void ErrorMsg3AndBlock()
        {
            ShowError("Ошибка. Повторите ввод!");
            AddJag.Enabled = false;
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
                }
                else
                {
                    ErrorMsg2AndBlock();
                    return;
                }
            }
            else
            {
                ErrorMsg2AndBlock();
                return; ;
            }

            int n = 0;
            if (Int32.TryParse(textBoxN.Text, out n))
            {
                if (ReadRange(n, size, 1))
                {
                    ok = true;
                }
                else
                {
                    ErrorMsg2AndBlock();
                    return;
                }
            }
            else
            {
                ErrorMsg2AndBlock();
                return;
            }
            if (k - 1 + n > size)
            {
                ErrorMsg2AndBlock();
                return;
            }
            else
            {
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
        void Proverka3()
        {
            if (textBoxJagK.Text == "")
            {
                AddJag.Enabled = false;
            }
            else
            {
                AddJag.Enabled = true;
            }
            if (textBoxJagN.Text == "")
            {
                AddJag.Enabled = false;
            }
            else
            {
                AddJag.Enabled = true;
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
        private void BlockUnblockButtons2()
        {
            if (matrix.Empty())
            {
                MakeMatrix.Enabled = false;
                RandomInputMatrix.Enabled = false;
                PrintMatrix.Enabled = false;
                AddColomn.Enabled = false;
                ClearMatrix.Enabled = false;
                UserFillMatrix.Enabled = false;
                SaveFileMatrix.Enabled = false;
                ReadFileMatrix.Enabled = false;
                Proverka2();
            }
            else
            {
                MakeMatrix.Enabled = true;
                RandomInputMatrix.Enabled = true;
                PrintMatrix.Enabled = true;
                AddColomn.Enabled = true;
                ClearMatrix.Enabled = true;
                UserFillMatrix.Enabled = true;
                SaveFileMatrix.Enabled = true;
                ReadFileMatrix.Enabled = true;
                Proverka2();
            }
        }
        private void MakeMatrix_Click(object sender, EventArgs e)
        {
            OutMatrix.Text = "";
            matrix = new Matrix();
            int row = 0, col = 0;
            if (int.TryParse(textBoxRow.Text, out row))
            {
                if (int.TryParse(textBoxCol.Text, out col))
                    if (col > 0 && row > 0)
                    {
                        matrix = new Matrix(row, col);
                        OutputMatrix();
                        BlockUnblockButtons2();
                    }
                    else ShowError("Ошибка\nПовторите ввод!");
                else ShowError("Кол-во столбцов таким не может быть\nПовторите ввод!");
            }
            else
            {
                ShowError("Кол-во строк таким не может быть\nПовторите ввод!");
            }
            //if (matrix.Empty())
            //{
            //    RandomInputMatrix.Enabled = false;
            //    //tDgoalButton.Enabled = false;
            //}
            //else
            //{
            //    RandomInputMatrix.Enabled = true;
            //}
            //ClearMatrix.Enabled = true;
            //PrintMatrix.Enabled = true;
            //AddColomn.Enabled = true;
            //UserFillMatrix.Enabled = true;
            BlockUnblockButtons2();
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
            if (matrix.getClm() == 1)
            {
                ShowError("Нет чётных столбцов!");
            }
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

        void FunUserFillVector()
        {
            string input = "";
            int size = vector.Length();
            int x = 0;
            for (int i = 0; i < size; i++)
            {
                while (true)
                {
                    input = Microsoft.VisualBasic.Interaction.InputBox($"Введите элемент [{(i + 1)}]", "", "");
                    if (input.Length == 0)
                    {
                        return;
                    }
                    if (int.TryParse(input, out x))
                    {
                        vector[i] = x;
                        break;
                    }
                    else
                    {
                        ShowError();
                    }
                }
            }
        }
        private void UserFillVector_Click(object sender, EventArgs e)
        {
            FunUserFillVector();
            OutputArray();
        }
        private void FunUserFillMatrix()
        {
            string input = "";
            int x = 0;
            for (int i = 0; i < matrix.GetStr(); i++)
            {
                for (int j = 0; j < matrix.getClm(); j++)
                {
                    while (true)
                    {
                        input = Microsoft.VisualBasic.Interaction.InputBox($"Введите элемент [{(i + 1)},{(j + 1)}]", "", "");
                        if (input.Length == 0)
                        {
                            return;
                        }
                        if (int.TryParse(input, out x))
                        {
                            matrix[i, j] = x;
                            break;
                        }
                        else
                        {
                            ShowError();
                        }
                    }
                }
            }
        }
        private void UserFillMatrix_Click(object sender, EventArgs e)
        {
            FunUserFillMatrix();
            OutputMatrix();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void JagRow_TextChanged(object sender, EventArgs e)
        {
            if (JagRow.Text == "")
            {
                MakeJag.Enabled = false;
            }
            else
            {
                MakeJag.Enabled = true;
            }
        }

        void FClearJag()
        {
            outJag.Text = "";
        }
        private void ClearJag_Click(object sender, EventArgs e)
        {
            FClearJag();
        }
        void JagOutputArray()
        {
            outJag.Text += "\n";
            for (int i = 0; i < jag.GetStr(); i++)
            {
                outJag.Text += "{ ";
                for (int j = 0; j < jag[i].Length; j++)
                {
                    outJag.Text += jag[i, j] + " ";
                }
                outJag.Text += "}\n";
            }
            outJag.Text += "Размер Массива: " + jag.GetStr() + " строк\n";
        }
        private void MakeJag_Click(object sender, EventArgs e)
        {
            jag = new Jagarray();
            int strings = 0;
            if (int.TryParse(JagRow.Text, out strings))
            {
                if (strings > 0)
                {
                    jag = new Jagarray(strings);
                    JagOutputArray();
                }
                else ShowError("Ошибка!\nПовторите ввод");
            }
            else
            {
                ShowError("Ошибка!\nПовторите ввод");
            }


            if (jag.Empty())
            {
                RandomInputJag.Enabled = false;
                AddJag.Enabled = false;
                ClearJag.Enabled = false;
                UzerFillJag.Enabled = false;
                PrintJag.Enabled = false;
                SaveFIleJag.Enabled = false;
                ReadFileJag.Enabled = false;
            }
            else
            {
                RandomInputJag.Enabled = true;
                AddJag.Enabled = true;
                ClearJag.Enabled = true;
                UzerFillJag.Enabled = true;
                PrintJag.Enabled = true;
                SaveFIleJag.Enabled = true;
                ReadFileJag.Enabled = true;
            }
        }

        private void RandomInputJag_Click(object sender, EventArgs e)
        {
            jag.RandomInput();
            JagOutputArray();
        }

        private void PrintJag_Click(object sender, EventArgs e)
        {
            JagOutputArray();
        }

        private void AddJag_Click(object sender, EventArgs e)
        {
            if (textBoxJagK.Text == "" || textBoxJagN.Text == "")
            {
                ShowError("Заполните поля ввода!");
            }
            else
            {
                try
                {
                    FunAdd();
                }
                catch
                {
                    ShowError("Ошибка, повторите ввод!");
                }
                if (jag.GetStr() == 0)
                {
                    ShowError("Массив пуст!");
                }

            }
        }
        private void FunAdd()
        {
            bool ok = true;
            int size = jag.GetStr();
            int k = 0;
            if (int.TryParse(textBoxJagK.Text, out k))
            {
                if (ReadRange(k, 100, 1))
                {
                    ok = true;
                }
                else
                {
                    ErrorMsg3AndBlock();
                    return;
                }
            }
            else
            {
                ErrorMsg3AndBlock();
                return;
            }

            int n = 0;
            if (int.TryParse(textBoxJagN.Text, out n))
            {
                if (ReadRange(n, size, 0))
                {
                    ok = true;
                }
                else
                {
                    ErrorMsg3AndBlock();
                    return;
                }
            }
            else
            {
                ErrorMsg3AndBlock();
                return;
            }
            jag.ChoiceDelete(n, k);
            JagOutputArray();
        }
        private void FunUserFillJag()
        {

            string input = "";
            int size = jag.GetStr();
            int x = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < jag[i].Length; j++)
                {
                    while (true)
                    {
                        input = Microsoft.VisualBasic.Interaction.InputBox($"Введите элемент [{(i + 1)},[{(j + 1)}]]", "", "");
                        if (input.Length == 0)
                        {
                            return;
                        }
                        if (int.TryParse(input, out x))
                        {
                            jag[i][j] = x;
                            break;
                        }
                        else
                        {
                            ShowError();
                        }
                    }
                }
            }

        }
        private void UzerFillJag_Click(object sender, EventArgs e)
        {
            FunUserFillJag();
            JagOutputArray();
        }

        private void TextBoxJagK_TextChanged(object sender, EventArgs e)
        {
            if (textBoxJagK.Text == "")
            {
                AddJag.Enabled = false;
            }
            else
            {
                AddJag.Enabled = true;
            }
        }

        private void CreateDataForJag()
        {
            bool ok;
            StreamReader sr = new StreamReader("f3.txt");

            string sizeRow = sr.ReadLine();
            int newSizeRow = 0;
            if (int.TryParse(sizeRow, out newSizeRow))
            {
                if (newSizeRow == jag.GetStr())
                {
                    ok = true;
                }
                else
                {
                    ShowError($"Количества строк не совпадают!\nКоличество строк созданного массива = {jag.GetStr()}\nКоличество строк массива в файле = {newSizeRow}");
                    ok = false;
                    return;
                }
            }
            else
            {
                ShowError("Некорректные данные в файле!");
                ok = false;
                return;
            }



            string str;
            int[] mas = new int[newSizeRow];

            for (int i = 0; i < newSizeRow; i++)
            {
                int n = 0;
                str = sr.ReadLine();
                
                string[] content = str.Split(new char[] { ' ' });
                if (int.TryParse(content[0], out n))
                {
                    mas[i] = n;
                }
                else
                {
                    ShowError("Некорректные данные в файле!");
                    ok = false;
                    return;
                }
            }

            jag.CreateJagFromFile(mas);

            sr.Close();

            StreamReader sr2 = new StreamReader("f3.txt");

            sr2.ReadLine();


            for (int i = 0; i < newSizeRow; i++)
            {
                int n = 0;
                str = sr2.ReadLine();
                string[] content = str.Split(new char[] { ' ' });
                for (int j = 0; j < jag[i].Length; j++)
                {
                    if (int.TryParse(content[j + 1], out n))
                    {
                        jag[i][j] = n;
                    }
                    else
                    {
                        ShowError("Некорректные данные в файле!");
                        ok = false;
                        return;
                    }
                }

            }
            JagOutputArray();
            sr2.Close();

        }

        private void CreateTextToFileJag()
        {
            string s = $"{jag.GetStr()}\n";

            for (int i = 0; i < jag.GetStr(); i++)
            {
                s += $"{jag[i].Length} ";
                for (int j = 0; j < jag[i].Length; j++)
                {
                    s += jag[i, j] + " ";
                }
                s += "\n";
            }
            SaveToFile(s, "f3");
        }



        private void CreateTextToFileMatrix()
        {
            string s = $"{matrix.GetStr()}\n";
            s += $"{matrix.getClm()}\n";
            for (int i = 0; i < matrix.GetStr(); i++)
            {
                for (int j = 0; j < matrix.getClm(); j++)
                {
                    s += matrix[i, j] + " ";
                }
                s += "\n";
            }
            SaveToFile(s, "f2");
        }

        private void CreateDataForMatrix()
        {
            bool ok;
            StreamReader sr = new StreamReader("f2.txt");

            string sizeRow = sr.ReadLine();
            string sizeCol = sr.ReadLine();
            int newSizeRow = 0;
            int newSizeCol = 0;
            if (int.TryParse(sizeRow, out newSizeRow))
            {
                if (newSizeRow == matrix.GetStr())
                {
                    ok = true;
                }
                else
                {
                    ShowError($"Количества строк не совпадают!\nКоличество строк созданного массива = {matrix.GetStr()}\nКоличество строк массива в файле = {newSizeRow}");
                    ok = false;
                    return;
                }
            }
            else
            {
                ShowError("Некорректные данные в файле!");
                ok = false;
                return;
            }

            if (int.TryParse(sizeCol, out newSizeCol))
            {
                if (newSizeCol == matrix.getClm())
                {
                    ok = true;
                }
                else
                {
                    ShowError($"Количества столбцов не совпадают!\nКоличество столбцов созданного массива = {matrix.getClm()}\nКоличество столбцов массива в файле = {newSizeCol}");
                    ok = false;
                    return;
                }
            }
            else
            {
                ShowError("Некорректные данные в файле!");
                ok = false;
                return;
            }
            string str;

            for (int i = 0; i < newSizeRow; i++)
            {
                str = sr.ReadLine();
                string[] content = str.Split(new char[] { ' ' });
                for (int j = 0; j < newSizeCol; j++)
                {
                    int x = matrix[i, j];
                    if (int.TryParse(content[j], out x))
                    {
                        matrix[i, j] = x;
                    }
                    else
                    {
                        ShowError("Некорректные данные в файле!");
                        ok = false;
                        return;
                    }
                }
            }
            OutputMatrix();
            sr.Close();
        }
        private void CreateDataForVector()
        {
            bool ok;
            StreamReader sr = new StreamReader("f1.txt");
            string sizeString = "";
            sizeString = sr.ReadLine();
            int newSize = 0;
            int size = vector.Length();
            if (int.TryParse(sizeString, out newSize))
            {
                if (newSize == size)
                {
                    vector = new Vector(size);
                    ok = true;
                }
                else
                {
                    ShowError($"Размеры массивов не совпадают!\nРазмер созданного массива = {size}\nРазмер массива в файле = {newSize}");
                    ok = false;
                    return;
                }
            }
            else
            {
                ShowError("Некорректные данные в файле!");
                ok = false;
                return;
            }
            string str = "";
            str = sr.ReadLine();
            string[] content = str.Split(new char[] { ' ' });
            for (int i = 0; i < size; i++)
            {
                int x = vector[i];
                if (int.TryParse(content[i], out x))
                {
                    vector[i] = x;
                }
                else
                {
                    ShowError("Некорректные данные в файле!");
                    ok = false;
                    return;
                }
            }
            OutputArray();
            sr.Close();
        }

        private void CreateTextToFileVector()
        {
            string s = $"{vector.Length()}\n";
            for (int i = 0; i < vector.Length(); i++)
            {
                s += vector[i] + " ";
            }
            SaveToFile(s, "f1");
        }

        private void SaveToFile(string textToSave, string filename)

        {
            try
            {
                //Создаём или перезаписываем существующий файл
                StreamWriter sw = File.CreateText(filename + ".txt");
                //Записываем текст в поток файла
                sw.WriteLine(textToSave);
                //Закрываем файл
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TextBoxJagN_TextChanged(object sender, EventArgs e)
        {
            if (textBoxJagN.Text == "")
            {
                AddJag.Enabled = false;
            }
            else
            {
                AddJag.Enabled = true;
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            CreateTextToFileVector();
        }

        private void SaveFileMatrix_Click(object sender, EventArgs e)
        {
            CreateTextToFileMatrix();
        }

        private void SaveFIleJag_Click(object sender, EventArgs e)
        {
            CreateTextToFileJag();
        }

        private void ReadFileVector_Click(object sender, EventArgs e)
        {
            try
            {
                CreateDataForVector();
            }
            catch
            {
                ShowError("В файле пусто.\nСначала запишите данные в файл");
            }
        }

        private void ReadFileMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                CreateDataForMatrix();
            }
            catch
            {
                ShowError("В файле пусто.\nСначала запишите данные в файл");
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.IO.File.Delete("f1.txt");
            System.IO.File.Delete("f2.txt");
            System.IO.File.Delete("f3.txt");

        }

        private void ReadFileJag_Click(object sender, EventArgs e)
        {
            try
            {
                CreateDataForJag();
            }
            catch
            {
                ShowError("Произошел троллинг");
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}

