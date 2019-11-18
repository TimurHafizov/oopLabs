using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace lab8
{
    public partial class Form1 : Form
    {

        DataBase Base = new DataBase();


        Random rnd = new Random();

        string[] BaseNumberBus = { "AA444A", "CC222C", "BB111B", "RR333R", "RR333R" };
        string[] BaseNameDriver = { "Владимир", "Андрей", "Евгений", "Михаил", "Константин" };
        string[] BaseNumberRoute = { "60", "41", "53", "20", "15" };
        bool[] BoolMas = { true, false };
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowError(string s = "Ошибка!")
        {
            MessageBox.Show(s);
        }


        private void RandomInput(int size = 10)
        {
            for (int i = 0; i < size; i++)
            {
                Base.AddBus(BaseNumberRoute[rnd.Next(0, 4)], BaseNameDriver[rnd.Next(0, 4)], BaseNumberBus[rnd.Next(0, 4)], BoolMas[rnd.Next(0, 2)]);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ReadFile();
                UpdateTable();
                Proverka();
            }
            catch
            {
                ShowError();
            }

        }
        private void SaveToFile(string filename = "f1.json")
        {
            try
            {
                string json = JsonConvert.SerializeObject(Base);
                StreamWriter sw = File.CreateText(filename);
                //Записываем текст в поток файла
                sw.WriteLine(json);
                //Закрываем файл
                sw.Close();
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, json);
                MessageBox.Show("Файл сохранен");
            }
            catch
            {
                ShowError("Произошла ошибка с файлом, возможно, его не существует");
            }

        }

        private void ReadFile(string filename = "f1.json")
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                filename = openFileDialog1.FileName;
                // читаем файл в строку
                string json = System.IO.File.ReadAllText(filename);

                DataBase newBase = new DataBase();
                newBase = JsonConvert.DeserializeObject<DataBase>(json);
                newBase.DeleteRepeat();
                Base = newBase;
            }
            catch
            {
                ShowError("Произошла ошибка с файлом");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Base.SortOfNumberRoure();
            UpdateTable();
        }

        private void LoadTable()
        {
            //создадим таблицу вывода товаров с колонками 
            //Название, Цена, Остаток
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер"; //текст в шапке
            column1.Width = 80; //ширина колонки
            column1.Name = "NumberRoute"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Маршрут";
            column2.Name = "NumberBus";
            column2.Width = 80;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Водитель";
            column3.Name = "NameDriver";
            column3.Width = 150;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Состояние";
            column4.Name = "Where";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTable();
            openFileDialog1.Filter = "Text files(*.json)|*.json";
            saveFileDialog1.Filter = "Text files(*.json)|*.json";
            SaveDB.Enabled = false;
            menuStrip1.Enabled = false;
            DeleteZap.Enabled = false;
            DeleteBase.Enabled = false;
            ShowInRoute.Enabled = false;
        }
        private void Proverka()
        {
            if (!Base.Empty())
            {
                SaveDB.Enabled = false;
                menuStrip1.Enabled = false;
                DeleteZap.Enabled = false;
                DeleteBase.Enabled = false;
                ShowInRoute.Enabled = false;
            }
            else
            {
                SaveDB.Enabled = true;
                menuStrip1.Enabled = true;
                DeleteZap.Enabled = true;
                DeleteBase.Enabled = true;
                ShowInRoute.Enabled = true;
            }
        }

        private void UpdateTable()
        {
            ClearTable();
            for (int i = 0; i < Base.List.Length; i++)
            {
                string nameBus = Base.List[i].NameBus;
                dataGridView1.Rows.Add(nameBus, Base.List[i].NumberRoute,
                Base.List[i].NameDriver, (Base.List[i].Where) ? "В маршруте" : "В парке");
            }
        }

        private void UpdateBaseFromTable()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int x;
                if (!int.TryParse(dataGridView1[1, i].Value.ToString(), out x))
                {
                    ShowError($"Значение {dataGridView1[1, i].Value.ToString()} некорректно.\nПовторите ввод!");
                    SaveDB.Enabled = false;
                    return;
                }

                if (Base.Search2(dataGridView1[0, i].Value.ToString()))
                {
                    ShowError($"Автобус с номером {dataGridView1[0, i].Value.ToString()} уже существует.\nУдалён один из одинаковых номеров");
                    dataGridView1[0, i].Value = "";
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[i];
                    SaveDB.Enabled = false;
                    return;
                }
                string sost = dataGridView1[3, i].Value.ToString();
                sost = sost.Replace(" ", "");
                sost = sost.ToLower();
                if (sost != "впарке" && sost != "вмаршруте")
                {
                    ShowError($"Значение {dataGridView1[3, i].Value.ToString()} некорректно.\nПовторите ввод!");
                    SaveDB.Enabled = false;
                    return;
                }
                Base.List[i].NameBus = dataGridView1[0, i].Value.ToString();
                Base.List[i].NumberRoute = dataGridView1[1, i].Value.ToString();
                Base.List[i].NameDriver = dataGridView1[2, i].Value.ToString();
                Base.List[i].Where = sost == "впарке" ? false : true;
                SaveDB.Enabled = true;
            }
        }

        private void ClearTable()
        {
            dataGridView1.Rows.Clear();
        }
        private void AddBus()
        {
            string a1, a2, a3, a4;
            while (true)
            {
                a1 = Microsoft.VisualBasic.Interaction.InputBox($"Введите номер автобуса в виде А111АА", "", "");
                if (a1.Length == 0)
                {
                    return;
                }
                a1.Replace(" ", "");
                if (a1.Length != 6)
                {
                    ShowError("Некорректный ввод\nПопробуйте еще раз");
                }
                else
                {
                    if (Base.Search(a1))
                    {
                        ShowError("Такой автобус уже существует!\nПопробуйте еще раз");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            while (true)
            {
                int asdf;
                a2 = Microsoft.VisualBasic.Interaction.InputBox($"Введите номер маршрута", "", "");
                if (a2.Length == 0)
                {
                    return;
                }
                if (!int.TryParse(a2, out asdf))
                {
                    ShowError("Некорректный ввод\nПопробуйте еще раз");
                }
                else
                {
                    break;
                }
            }

            a3 = Microsoft.VisualBasic.Interaction.InputBox($"Введите имя водителя", "", "");
            if (a3.Length == 0)
            {
                return;
            }

            while (true)
            {

                a4 = Microsoft.VisualBasic.Interaction.InputBox("Введите состояние автобуса\n<<В парке>> или <<В маршруте>>", "", "");
                if (a4.Length == 0)
                {
                    return;
                }
                a4 = a4.Replace(" ", "");
                a4 = a4.ToLower();

                if (a4 != "впарке" && a4 != "вмаршруте")
                {
                    ShowError("Некорректный ввод\nПопробуйте еще раз");
                }
                else
                {
                    break;
                }
            }


            Base.AddBus(a2, a3, a1, (a4 == "впарке" ? false : true));
        }

        private void AddBusInBase_Click(object sender, EventArgs e)
        {
            try
            {
                AddBus();
                UpdateTable();
                UpdateBaseFromTable();
                Proverka();
            }
            catch
            {
                ShowError();
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SaveToFile();
            }
            catch
            {
                ShowError();
            }

        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UpdateBaseFromTable();
                SaveDB.Enabled = true;
            }
            catch
            {
                ShowError("Некорректные данные!\nПовторите ввод!");
                SaveDB.Enabled = false;
            }

        }

        private void DeleteElement()
        {

            if (Base.Empty())
            {
                string input;
                while (true)
                {
                    input = Microsoft.VisualBasic.Interaction.InputBox($"Введите номер автобуса, который нужно удалить в виде А111АА", "", "");
                    if (input.Length == 0)
                    {
                        return;
                    }
                    if (input.Length != 6)
                    {
                        ShowError("Некорректный ввод, повторите");
                    }
                    else
                    {
                        break;
                    }
                }
                int ok = Base.DeleteEl(input);
                if (ok == -1)
                {
                    ShowError("Такого автобуса нет");
                }
                else
                {
                    UpdateTable();
                    Proverka();
                    ShowError("Удалено");
                }
            }
        }
        private void Button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                DeleteElement();
            }
            catch
            {
                ShowError();
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SortName_Click(object sender, EventArgs e)
        {
            Base.SortOfNameDriver();
            UpdateTable();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            UpdateBaseFromTable();
            UpdateTable();
        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            Base.SortOfNameBus();
            UpdateTable();
        }

        private void ПоНомеруМаршрутаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Base.SortOfNumberRoure();
                UpdateTable();
            }
            catch
            {
                ShowError();
            }

        }

        private void ПоНомеруАвтобусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Base.SortOfNameBus();
                UpdateTable();
            }
            catch
            {
                ShowError();
            }

        }

        private void ПоИмениВодителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Base.SortOfNameDriver();
                UpdateTable();
            }
            catch
            {
                ShowError();
            }

        }

        private void DeleteBase_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase newBase = new DataBase();
                Base = newBase;
                UpdateTable();
                Proverka();
            }
            catch
            {
                ShowError();
            }

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ShowDriverInRoute()
        {
            if (Base.Empty())
            {
                string x = "Водители в маршруте\n";
                for (int i = 0; i < Base.GetLength(); i++)
                {
                    if (Base.List[i].Where == true)
                    {
                        x += "\n" + Base.List[i].NameDriver;
                    }
                }
                ShowError(x);
            }
            else
            {
                ShowError("Заполните базу данных!");
            }
        }

        private void ShowInRoute_Click(object sender, EventArgs e)
        {
            try
            {
                ShowDriverInRoute();
            }
            catch
            {
                ShowError();
            }

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
