namespace lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.NewVector = new System.Windows.Forms.Button();
            this.ClearVector = new System.Windows.Forms.Button();
            this.SizeOfVector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ReadFileVector = new System.Windows.Forms.Button();
            this.SaveFileVector = new System.Windows.Forms.Button();
            this.UserFillVector = new System.Windows.Forms.Button();
            this.ErrorMsg2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.DeleteElOfVector = new System.Windows.Forms.Button();
            this.RandomInputVector = new System.Windows.Forms.Button();
            this.PrintVector = new System.Windows.Forms.Button();
            this.ErrorMsg = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ReadFileMatrix = new System.Windows.Forms.Button();
            this.SaveFileMatrix = new System.Windows.Forms.Button();
            this.UserFillMatrix = new System.Windows.Forms.Button();
            this.ErrorMatrix = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddColomn = new System.Windows.Forms.Button();
            this.RandomInputMatrix = new System.Windows.Forms.Button();
            this.PrintMatrix = new System.Windows.Forms.Button();
            this.MakeMatrix = new System.Windows.Forms.Button();
            this.ClearMatrix = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.OutMatrix = new System.Windows.Forms.RichTextBox();
            this.textBoxRow = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SaveFIleJag = new System.Windows.Forms.Button();
            this.UzerFillJag = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxJagN = new System.Windows.Forms.TextBox();
            this.textBoxJagK = new System.Windows.Forms.TextBox();
            this.AddJag = new System.Windows.Forms.Button();
            this.RandomInputJag = new System.Windows.Forms.Button();
            this.PrintJag = new System.Windows.Forms.Button();
            this.MakeJag = new System.Windows.Forms.Button();
            this.ClearJag = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.outJag = new System.Windows.Forms.RichTextBox();
            this.JagRow = new System.Windows.Forms.TextBox();
            this.ReadFileJag = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.White;
            this.outputBox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(8, 87);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(505, 250);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // NewVector
            // 
            this.NewVector.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewVector.Location = new System.Drawing.Point(336, 17);
            this.NewVector.Name = "NewVector";
            this.NewVector.Size = new System.Drawing.Size(177, 65);
            this.NewVector.TabIndex = 1;
            this.NewVector.Text = "Создать массив";
            this.NewVector.UseVisualStyleBackColor = true;
            this.NewVector.Click += new System.EventHandler(this.NewMas);
            // 
            // ClearVector
            // 
            this.ClearVector.BackColor = System.Drawing.Color.LightSalmon;
            this.ClearVector.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearVector.Location = new System.Drawing.Point(519, 343);
            this.ClearVector.Name = "ClearVector";
            this.ClearVector.Size = new System.Drawing.Size(133, 63);
            this.ClearVector.TabIndex = 2;
            this.ClearVector.Text = "Clear";
            this.ClearVector.UseVisualStyleBackColor = false;
            this.ClearVector.Click += new System.EventHandler(this.Clear);
            // 
            // SizeOfVector
            // 
            this.SizeOfVector.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeOfVector.Location = new System.Drawing.Point(247, 24);
            this.SizeOfVector.Multiline = true;
            this.SizeOfVector.Name = "SizeOfVector";
            this.SizeOfVector.Size = new System.Drawing.Size(43, 39);
            this.SizeOfVector.TabIndex = 3;
            this.SizeOfVector.TextChanged += new System.EventHandler(this.Size_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество элементов:";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(29, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 492);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.ReadFileVector);
            this.tabPage1.Controls.Add(this.SaveFileVector);
            this.tabPage1.Controls.Add(this.UserFillVector);
            this.tabPage1.Controls.Add(this.ErrorMsg2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxK);
            this.tabPage1.Controls.Add(this.textBoxN);
            this.tabPage1.Controls.Add(this.DeleteElOfVector);
            this.tabPage1.Controls.Add(this.RandomInputVector);
            this.tabPage1.Controls.Add(this.PrintVector);
            this.tabPage1.Controls.Add(this.ErrorMsg);
            this.tabPage1.Controls.Add(this.NewVector);
            this.tabPage1.Controls.Add(this.ClearVector);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.outputBox);
            this.tabPage1.Controls.Add(this.SizeOfVector);
            this.tabPage1.Font = new System.Drawing.Font("Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Одномерный";
            // 
            // ReadFileVector
            // 
            this.ReadFileVector.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadFileVector.Location = new System.Drawing.Point(519, 215);
            this.ReadFileVector.Name = "ReadFileVector";
            this.ReadFileVector.Size = new System.Drawing.Size(133, 58);
            this.ReadFileVector.TabIndex = 16;
            this.ReadFileVector.Text = "Заполнить \r\nиз файла\r\n";
            this.ReadFileVector.UseVisualStyleBackColor = true;
            this.ReadFileVector.Click += new System.EventHandler(this.ReadFileVector_Click);
            // 
            // SaveFileVector
            // 
            this.SaveFileVector.BackgroundImage = global::lab7.Properties.Resources.save;
            this.SaveFileVector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveFileVector.FlatAppearance.BorderSize = 0;
            this.SaveFileVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileVector.Location = new System.Drawing.Point(561, 21);
            this.SaveFileVector.Name = "SaveFileVector";
            this.SaveFileVector.Size = new System.Drawing.Size(61, 54);
            this.SaveFileVector.TabIndex = 15;
            this.SaveFileVector.UseVisualStyleBackColor = true;
            this.SaveFileVector.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // UserFillVector
            // 
            this.UserFillVector.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserFillVector.Location = new System.Drawing.Point(519, 151);
            this.UserFillVector.Name = "UserFillVector";
            this.UserFillVector.Size = new System.Drawing.Size(133, 58);
            this.UserFillVector.TabIndex = 14;
            this.UserFillVector.Text = "Заполнить вручную";
            this.UserFillVector.UseVisualStyleBackColor = true;
            this.UserFillVector.Click += new System.EventHandler(this.UserFillVector_Click);
            // 
            // ErrorMsg2
            // 
            this.ErrorMsg2.AutoSize = true;
            this.ErrorMsg2.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg2.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorMsg2.Location = new System.Drawing.Point(175, 530);
            this.ErrorMsg2.Name = "ErrorMsg2";
            this.ErrorMsg2.Size = new System.Drawing.Size(0, 19);
            this.ErrorMsg2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "С какого элемента удалить?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сколько элементов удалить?";
            // 
            // textBoxK
            // 
            this.textBoxK.Font = new System.Drawing.Font("Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxK.Location = new System.Drawing.Point(296, 374);
            this.textBoxK.Multiline = true;
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(43, 32);
            this.textBoxK.TabIndex = 10;
            this.textBoxK.TextChanged += new System.EventHandler(this.TextBoxK_TextChanged);
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(296, 343);
            this.textBoxN.Multiline = true;
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(43, 32);
            this.textBoxN.TabIndex = 9;
            this.textBoxN.TextChanged += new System.EventHandler(this.TextBoxN_TextChanged);
            // 
            // DeleteElOfVector
            // 
            this.DeleteElOfVector.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteElOfVector.Location = new System.Drawing.Point(345, 343);
            this.DeleteElOfVector.Name = "DeleteElOfVector";
            this.DeleteElOfVector.Size = new System.Drawing.Size(168, 63);
            this.DeleteElOfVector.TabIndex = 8;
            this.DeleteElOfVector.Text = "Удалить элементы";
            this.DeleteElOfVector.UseVisualStyleBackColor = true;
            this.DeleteElOfVector.Click += new System.EventHandler(this.DeleteElOfVector_Click);
            // 
            // RandomInputVector
            // 
            this.RandomInputVector.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomInputVector.Location = new System.Drawing.Point(519, 87);
            this.RandomInputVector.Name = "RandomInputVector";
            this.RandomInputVector.Size = new System.Drawing.Size(133, 58);
            this.RandomInputVector.TabIndex = 7;
            this.RandomInputVector.Text = "Заполнить рандомно";
            this.RandomInputVector.UseVisualStyleBackColor = true;
            this.RandomInputVector.Click += new System.EventHandler(this.RandomInputVector_Click);
            // 
            // PrintVector
            // 
            this.PrintVector.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintVector.Location = new System.Drawing.Point(519, 279);
            this.PrintVector.Name = "PrintVector";
            this.PrintVector.Size = new System.Drawing.Size(133, 58);
            this.PrintVector.TabIndex = 6;
            this.PrintVector.Text = "Печать";
            this.PrintVector.UseVisualStyleBackColor = true;
            this.PrintVector.Click += new System.EventHandler(this.PrintVector_Click);
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorMsg.Location = new System.Drawing.Point(11, 99);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(0, 19);
            this.ErrorMsg.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReadFileMatrix);
            this.tabPage2.Controls.Add(this.SaveFileMatrix);
            this.tabPage2.Controls.Add(this.UserFillMatrix);
            this.tabPage2.Controls.Add(this.ErrorMatrix);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxCol);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.AddColomn);
            this.tabPage2.Controls.Add(this.RandomInputMatrix);
            this.tabPage2.Controls.Add(this.PrintMatrix);
            this.tabPage2.Controls.Add(this.MakeMatrix);
            this.tabPage2.Controls.Add(this.ClearMatrix);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.OutMatrix);
            this.tabPage2.Controls.Add(this.textBoxRow);
            this.tabPage2.Font = new System.Drawing.Font("Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Двумерный";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReadFileMatrix
            // 
            this.ReadFileMatrix.Location = new System.Drawing.Point(527, 236);
            this.ReadFileMatrix.Name = "ReadFileMatrix";
            this.ReadFileMatrix.Size = new System.Drawing.Size(125, 58);
            this.ReadFileMatrix.TabIndex = 32;
            this.ReadFileMatrix.Text = "Заполнить\r\nиз файла\r\n";
            this.ReadFileMatrix.UseVisualStyleBackColor = true;
            this.ReadFileMatrix.Click += new System.EventHandler(this.ReadFileMatrix_Click);
            // 
            // SaveFileMatrix
            // 
            this.SaveFileMatrix.BackColor = System.Drawing.Color.Transparent;
            this.SaveFileMatrix.BackgroundImage = global::lab7.Properties.Resources.save;
            this.SaveFileMatrix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveFileMatrix.FlatAppearance.BorderSize = 0;
            this.SaveFileMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileMatrix.Location = new System.Drawing.Point(561, 38);
            this.SaveFileMatrix.Name = "SaveFileMatrix";
            this.SaveFileMatrix.Size = new System.Drawing.Size(59, 55);
            this.SaveFileMatrix.TabIndex = 31;
            this.SaveFileMatrix.UseVisualStyleBackColor = false;
            this.SaveFileMatrix.Click += new System.EventHandler(this.SaveFileMatrix_Click);
            // 
            // UserFillMatrix
            // 
            this.UserFillMatrix.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserFillMatrix.Location = new System.Drawing.Point(527, 172);
            this.UserFillMatrix.Name = "UserFillMatrix";
            this.UserFillMatrix.Size = new System.Drawing.Size(125, 58);
            this.UserFillMatrix.TabIndex = 30;
            this.UserFillMatrix.Text = "Заполнить вручную";
            this.UserFillMatrix.UseVisualStyleBackColor = true;
            this.UserFillMatrix.Click += new System.EventHandler(this.UserFillMatrix_Click);
            // 
            // ErrorMatrix
            // 
            this.ErrorMatrix.AutoSize = true;
            this.ErrorMatrix.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMatrix.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorMatrix.Location = new System.Drawing.Point(238, -19);
            this.ErrorMatrix.Name = "ErrorMatrix";
            this.ErrorMatrix.Size = new System.Drawing.Size(0, 19);
            this.ErrorMatrix.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(57, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Количество столбцов";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // textBoxCol
            // 
            this.textBoxCol.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCol.Location = new System.Drawing.Point(268, 63);
            this.textBoxCol.Multiline = true;
            this.textBoxCol.Name = "textBoxCol";
            this.textBoxCol.Size = new System.Drawing.Size(43, 39);
            this.textBoxCol.TabIndex = 27;
            this.textBoxCol.TextChanged += new System.EventHandler(this.TextBoxCol_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(175, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 26;
            // 
            // AddColomn
            // 
            this.AddColomn.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddColomn.Location = new System.Drawing.Point(8, 364);
            this.AddColomn.Name = "AddColomn";
            this.AddColomn.Size = new System.Drawing.Size(513, 62);
            this.AddColomn.TabIndex = 21;
            this.AddColomn.Text = "Добавить стобцы после чётных столбцов";
            this.AddColomn.UseVisualStyleBackColor = true;
            this.AddColomn.Click += new System.EventHandler(this.AddColomn_Click);
            // 
            // RandomInputMatrix
            // 
            this.RandomInputMatrix.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomInputMatrix.Location = new System.Drawing.Point(527, 108);
            this.RandomInputMatrix.Name = "RandomInputMatrix";
            this.RandomInputMatrix.Size = new System.Drawing.Size(125, 58);
            this.RandomInputMatrix.TabIndex = 20;
            this.RandomInputMatrix.Text = "Заполнить рандомно";
            this.RandomInputMatrix.UseVisualStyleBackColor = true;
            this.RandomInputMatrix.Click += new System.EventHandler(this.RandomInputMatrix_Click);
            // 
            // PrintMatrix
            // 
            this.PrintMatrix.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintMatrix.Location = new System.Drawing.Point(527, 300);
            this.PrintMatrix.Name = "PrintMatrix";
            this.PrintMatrix.Size = new System.Drawing.Size(125, 58);
            this.PrintMatrix.TabIndex = 19;
            this.PrintMatrix.Text = "Печать";
            this.PrintMatrix.UseVisualStyleBackColor = true;
            this.PrintMatrix.Click += new System.EventHandler(this.PrintMatrix_Click);
            // 
            // MakeMatrix
            // 
            this.MakeMatrix.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeMatrix.Location = new System.Drawing.Point(339, 28);
            this.MakeMatrix.Name = "MakeMatrix";
            this.MakeMatrix.Size = new System.Drawing.Size(182, 74);
            this.MakeMatrix.TabIndex = 15;
            this.MakeMatrix.Text = "Создать массив";
            this.MakeMatrix.UseVisualStyleBackColor = true;
            this.MakeMatrix.Click += new System.EventHandler(this.MakeMatrix_Click);
            // 
            // ClearMatrix
            // 
            this.ClearMatrix.BackColor = System.Drawing.Color.LightSalmon;
            this.ClearMatrix.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearMatrix.Location = new System.Drawing.Point(527, 364);
            this.ClearMatrix.Name = "ClearMatrix";
            this.ClearMatrix.Size = new System.Drawing.Size(125, 62);
            this.ClearMatrix.TabIndex = 16;
            this.ClearMatrix.Text = "Clear";
            this.ClearMatrix.UseVisualStyleBackColor = false;
            this.ClearMatrix.Click += new System.EventHandler(this.ClearMatrix_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(57, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Количество строк";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // OutMatrix
            // 
            this.OutMatrix.BackColor = System.Drawing.Color.White;
            this.OutMatrix.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutMatrix.Location = new System.Drawing.Point(8, 108);
            this.OutMatrix.Name = "OutMatrix";
            this.OutMatrix.ReadOnly = true;
            this.OutMatrix.Size = new System.Drawing.Size(513, 250);
            this.OutMatrix.TabIndex = 14;
            this.OutMatrix.Text = "";
            // 
            // textBoxRow
            // 
            this.textBoxRow.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRow.Location = new System.Drawing.Point(268, 28);
            this.textBoxRow.Multiline = true;
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.Size = new System.Drawing.Size(43, 37);
            this.textBoxRow.TabIndex = 17;
            this.textBoxRow.TextChanged += new System.EventHandler(this.TextBoxRow_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ReadFileJag);
            this.tabPage3.Controls.Add(this.SaveFIleJag);
            this.tabPage3.Controls.Add(this.UzerFillJag);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxJagN);
            this.tabPage3.Controls.Add(this.textBoxJagK);
            this.tabPage3.Controls.Add(this.AddJag);
            this.tabPage3.Controls.Add(this.RandomInputJag);
            this.tabPage3.Controls.Add(this.PrintJag);
            this.tabPage3.Controls.Add(this.MakeJag);
            this.tabPage3.Controls.Add(this.ClearJag);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.outJag);
            this.tabPage3.Controls.Add(this.JagRow);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(660, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Рваный";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SaveFIleJag
            // 
            this.SaveFIleJag.BackColor = System.Drawing.Color.Transparent;
            this.SaveFIleJag.BackgroundImage = global::lab7.Properties.Resources.save;
            this.SaveFIleJag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveFIleJag.FlatAppearance.BorderSize = 0;
            this.SaveFIleJag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFIleJag.Location = new System.Drawing.Point(563, 30);
            this.SaveFIleJag.Name = "SaveFIleJag";
            this.SaveFIleJag.Size = new System.Drawing.Size(51, 54);
            this.SaveFIleJag.TabIndex = 28;
            this.SaveFIleJag.UseVisualStyleBackColor = false;
            this.SaveFIleJag.Click += new System.EventHandler(this.SaveFIleJag_Click);
            // 
            // UzerFillJag
            // 
            this.UzerFillJag.BackColor = System.Drawing.Color.Transparent;
            this.UzerFillJag.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UzerFillJag.Location = new System.Drawing.Point(515, 161);
            this.UzerFillJag.Name = "UzerFillJag";
            this.UzerFillJag.Size = new System.Drawing.Size(139, 58);
            this.UzerFillJag.TabIndex = 27;
            this.UzerFillJag.Text = "Заполнить вручную";
            this.UzerFillJag.UseVisualStyleBackColor = false;
            this.UzerFillJag.Click += new System.EventHandler(this.UzerFillJag_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "С какой строки добавлять?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Сколько строк добавить?";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // textBoxJagN
            // 
            this.textBoxJagN.Font = new System.Drawing.Font("Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxJagN.Location = new System.Drawing.Point(285, 386);
            this.textBoxJagN.Multiline = true;
            this.textBoxJagN.Name = "textBoxJagN";
            this.textBoxJagN.Size = new System.Drawing.Size(43, 33);
            this.textBoxJagN.TabIndex = 24;
            this.textBoxJagN.TextChanged += new System.EventHandler(this.TextBoxJagN_TextChanged);
            // 
            // textBoxJagK
            // 
            this.textBoxJagK.Font = new System.Drawing.Font("Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxJagK.Location = new System.Drawing.Point(285, 353);
            this.textBoxJagK.Multiline = true;
            this.textBoxJagK.Name = "textBoxJagK";
            this.textBoxJagK.Size = new System.Drawing.Size(43, 34);
            this.textBoxJagK.TabIndex = 23;
            this.textBoxJagK.TextChanged += new System.EventHandler(this.TextBoxJagK_TextChanged);
            // 
            // AddJag
            // 
            this.AddJag.BackColor = System.Drawing.Color.Transparent;
            this.AddJag.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddJag.Location = new System.Drawing.Point(334, 353);
            this.AddJag.Name = "AddJag";
            this.AddJag.Size = new System.Drawing.Size(175, 66);
            this.AddJag.TabIndex = 22;
            this.AddJag.Text = "Добавить";
            this.AddJag.UseVisualStyleBackColor = false;
            this.AddJag.Click += new System.EventHandler(this.AddJag_Click);
            // 
            // RandomInputJag
            // 
            this.RandomInputJag.BackColor = System.Drawing.Color.Transparent;
            this.RandomInputJag.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomInputJag.Location = new System.Drawing.Point(515, 97);
            this.RandomInputJag.Name = "RandomInputJag";
            this.RandomInputJag.Size = new System.Drawing.Size(139, 58);
            this.RandomInputJag.TabIndex = 21;
            this.RandomInputJag.Text = "Заполнить рандомно";
            this.RandomInputJag.UseVisualStyleBackColor = false;
            this.RandomInputJag.Click += new System.EventHandler(this.RandomInputJag_Click);
            // 
            // PrintJag
            // 
            this.PrintJag.BackColor = System.Drawing.Color.Transparent;
            this.PrintJag.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintJag.Location = new System.Drawing.Point(515, 289);
            this.PrintJag.Name = "PrintJag";
            this.PrintJag.Size = new System.Drawing.Size(139, 58);
            this.PrintJag.TabIndex = 20;
            this.PrintJag.Text = "Печать";
            this.PrintJag.UseVisualStyleBackColor = false;
            this.PrintJag.Click += new System.EventHandler(this.PrintJag_Click);
            // 
            // MakeJag
            // 
            this.MakeJag.BackColor = System.Drawing.Color.Transparent;
            this.MakeJag.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeJag.Location = new System.Drawing.Point(334, 23);
            this.MakeJag.Name = "MakeJag";
            this.MakeJag.Size = new System.Drawing.Size(174, 68);
            this.MakeJag.TabIndex = 16;
            this.MakeJag.Text = "Создать массив";
            this.MakeJag.UseVisualStyleBackColor = false;
            this.MakeJag.Click += new System.EventHandler(this.MakeJag_Click);
            // 
            // ClearJag
            // 
            this.ClearJag.BackColor = System.Drawing.Color.LightSalmon;
            this.ClearJag.Font = new System.Drawing.Font("Gilroy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearJag.Location = new System.Drawing.Point(515, 353);
            this.ClearJag.Name = "ClearJag";
            this.ClearJag.Size = new System.Drawing.Size(139, 66);
            this.ClearJag.TabIndex = 17;
            this.ClearJag.Text = "Clear";
            this.ClearJag.UseVisualStyleBackColor = false;
            this.ClearJag.Click += new System.EventHandler(this.ClearJag_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(24, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Количество строк:";
            // 
            // outJag
            // 
            this.outJag.BackColor = System.Drawing.Color.White;
            this.outJag.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outJag.Location = new System.Drawing.Point(10, 97);
            this.outJag.Name = "outJag";
            this.outJag.ReadOnly = true;
            this.outJag.Size = new System.Drawing.Size(499, 250);
            this.outJag.TabIndex = 15;
            this.outJag.Text = "";
            // 
            // JagRow
            // 
            this.JagRow.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JagRow.Location = new System.Drawing.Point(221, 34);
            this.JagRow.Multiline = true;
            this.JagRow.Name = "JagRow";
            this.JagRow.Size = new System.Drawing.Size(43, 39);
            this.JagRow.TabIndex = 18;
            this.JagRow.TextChanged += new System.EventHandler(this.JagRow_TextChanged);
            // 
            // ReadFileJag
            // 
            this.ReadFileJag.Location = new System.Drawing.Point(515, 225);
            this.ReadFileJag.Name = "ReadFileJag";
            this.ReadFileJag.Size = new System.Drawing.Size(139, 58);
            this.ReadFileJag.TabIndex = 29;
            this.ReadFileJag.Text = "Заполнить \r\nиз файла";
            this.ReadFileJag.UseVisualStyleBackColor = true;
            this.ReadFileJag.Click += new System.EventHandler(this.ReadFileJag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 491);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная 7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button NewVector;
        private System.Windows.Forms.Button ClearVector;
        private System.Windows.Forms.TextBox SizeOfVector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label ErrorMsg;
        private System.Windows.Forms.Button DeleteElOfVector;
        private System.Windows.Forms.Button RandomInputVector;
        private System.Windows.Forms.Button PrintVector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label ErrorMsg2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddColomn;
        private System.Windows.Forms.Button RandomInputMatrix;
        private System.Windows.Forms.Button PrintMatrix;
        private System.Windows.Forms.Button MakeMatrix;
        private System.Windows.Forms.Button ClearMatrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox OutMatrix;
        private System.Windows.Forms.TextBox textBoxRow;
        private System.Windows.Forms.Label ErrorMatrix;
        private System.Windows.Forms.Button UserFillVector;
        private System.Windows.Forms.Button UserFillMatrix;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button UzerFillJag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxJagN;
        private System.Windows.Forms.TextBox textBoxJagK;
        private System.Windows.Forms.Button AddJag;
        private System.Windows.Forms.Button RandomInputJag;
        private System.Windows.Forms.Button PrintJag;
        private System.Windows.Forms.Button MakeJag;
        private System.Windows.Forms.Button ClearJag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox outJag;
        private System.Windows.Forms.TextBox JagRow;
        private System.Windows.Forms.Button SaveFileVector;
        private System.Windows.Forms.Button SaveFileMatrix;
        private System.Windows.Forms.Button SaveFIleJag;
        private System.Windows.Forms.Button ReadFileVector;
        private System.Windows.Forms.Button ReadFileMatrix;
        private System.Windows.Forms.Button ReadFileJag;
    }
}

