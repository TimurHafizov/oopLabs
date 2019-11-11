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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.White;
            this.outputBox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(10, 124);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(499, 216);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // NewVector
            // 
            this.NewVector.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewVector.Location = new System.Drawing.Point(208, 66);
            this.NewVector.Name = "NewVector";
            this.NewVector.Size = new System.Drawing.Size(167, 39);
            this.NewVector.TabIndex = 1;
            this.NewVector.Text = "Создать массив";
            this.NewVector.UseVisualStyleBackColor = true;
            this.NewVector.Click += new System.EventHandler(this.NewMas);
            // 
            // ClearVector
            // 
            this.ClearVector.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearVector.Location = new System.Drawing.Point(407, 355);
            this.ClearVector.Name = "ClearVector";
            this.ClearVector.Size = new System.Drawing.Size(102, 58);
            this.ClearVector.TabIndex = 2;
            this.ClearVector.Text = "Clear";
            this.ClearVector.UseVisualStyleBackColor = true;
            this.ClearVector.Click += new System.EventHandler(this.Clear);
            // 
            // SizeOfVector
            // 
            this.SizeOfVector.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeOfVector.Location = new System.Drawing.Point(160, 66);
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
            this.label1.Location = new System.Drawing.Point(167, 36);
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
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(526, 599);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(518, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.label2.Font = new System.Drawing.Font("Gilroy Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "С какого элемента удалять?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сколько элементов удалить?";
            // 
            // textBoxK
            // 
            this.textBoxK.Font = new System.Drawing.Font("Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxK.Location = new System.Drawing.Point(237, 483);
            this.textBoxK.Multiline = true;
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(43, 37);
            this.textBoxK.TabIndex = 10;
            this.textBoxK.TextChanged += new System.EventHandler(this.TextBoxK_TextChanged);
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(237, 439);
            this.textBoxN.Multiline = true;
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(43, 37);
            this.textBoxN.TabIndex = 9;
            this.textBoxN.TextChanged += new System.EventHandler(this.TextBoxN_TextChanged);
            // 
            // DeleteElOfVector
            // 
            this.DeleteElOfVector.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteElOfVector.Location = new System.Drawing.Point(301, 439);
            this.DeleteElOfVector.Name = "DeleteElOfVector";
            this.DeleteElOfVector.Size = new System.Drawing.Size(208, 81);
            this.DeleteElOfVector.TabIndex = 8;
            this.DeleteElOfVector.Text = "Удалить элементы";
            this.DeleteElOfVector.UseVisualStyleBackColor = true;
            this.DeleteElOfVector.Click += new System.EventHandler(this.DeleteElOfVector_Click);
            // 
            // RandomInputVector
            // 
            this.RandomInputVector.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomInputVector.Location = new System.Drawing.Point(10, 355);
            this.RandomInputVector.Name = "RandomInputVector";
            this.RandomInputVector.Size = new System.Drawing.Size(270, 58);
            this.RandomInputVector.TabIndex = 7;
            this.RandomInputVector.Text = "Заполнить рандомно";
            this.RandomInputVector.UseVisualStyleBackColor = true;
            this.RandomInputVector.Click += new System.EventHandler(this.RandomInputVector_Click);
            // 
            // PrintVector
            // 
            this.PrintVector.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintVector.Location = new System.Drawing.Point(301, 355);
            this.PrintVector.Name = "PrintVector";
            this.PrintVector.Size = new System.Drawing.Size(100, 58);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(518, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ErrorMatrix
            // 
            this.ErrorMatrix.AutoSize = true;
            this.ErrorMatrix.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMatrix.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorMatrix.Location = new System.Drawing.Point(239, 7);
            this.ErrorMatrix.Name = "ErrorMatrix";
            this.ErrorMatrix.Size = new System.Drawing.Size(0, 19);
            this.ErrorMatrix.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Количество столбцов";
            // 
            // textBoxCol
            // 
            this.textBoxCol.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCol.Location = new System.Drawing.Point(222, 97);
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
            this.label4.Location = new System.Drawing.Point(176, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 26;
            // 
            // AddColomn
            // 
            this.AddColomn.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddColomn.Location = new System.Drawing.Point(11, 471);
            this.AddColomn.Name = "AddColomn";
            this.AddColomn.Size = new System.Drawing.Size(499, 81);
            this.AddColomn.TabIndex = 21;
            this.AddColomn.Text = "Добавить стобцы после чётных столбцов";
            this.AddColomn.UseVisualStyleBackColor = true;
            this.AddColomn.Click += new System.EventHandler(this.AddColomn_Click);
            // 
            // RandomInputMatrix
            // 
            this.RandomInputMatrix.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomInputMatrix.Location = new System.Drawing.Point(11, 402);
            this.RandomInputMatrix.Name = "RandomInputMatrix";
            this.RandomInputMatrix.Size = new System.Drawing.Size(270, 58);
            this.RandomInputMatrix.TabIndex = 20;
            this.RandomInputMatrix.Text = "Заполнить рандомно";
            this.RandomInputMatrix.UseVisualStyleBackColor = true;
            this.RandomInputMatrix.Click += new System.EventHandler(this.RandomInputMatrix_Click);
            // 
            // PrintMatrix
            // 
            this.PrintMatrix.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintMatrix.Location = new System.Drawing.Point(293, 402);
            this.PrintMatrix.Name = "PrintMatrix";
            this.PrintMatrix.Size = new System.Drawing.Size(100, 58);
            this.PrintMatrix.TabIndex = 19;
            this.PrintMatrix.Text = "Печать";
            this.PrintMatrix.UseVisualStyleBackColor = true;
            this.PrintMatrix.Click += new System.EventHandler(this.PrintMatrix_Click);
            // 
            // MakeMatrix
            // 
            this.MakeMatrix.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeMatrix.Location = new System.Drawing.Point(327, 52);
            this.MakeMatrix.Name = "MakeMatrix";
            this.MakeMatrix.Size = new System.Drawing.Size(182, 84);
            this.MakeMatrix.TabIndex = 15;
            this.MakeMatrix.Text = "Создать массив";
            this.MakeMatrix.UseVisualStyleBackColor = true;
            this.MakeMatrix.Click += new System.EventHandler(this.MakeMatrix_Click);
            // 
            // ClearMatrix
            // 
            this.ClearMatrix.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearMatrix.Location = new System.Drawing.Point(408, 402);
            this.ClearMatrix.Name = "ClearMatrix";
            this.ClearMatrix.Size = new System.Drawing.Size(102, 58);
            this.ClearMatrix.TabIndex = 16;
            this.ClearMatrix.Text = "Clear";
            this.ClearMatrix.UseVisualStyleBackColor = true;
            this.ClearMatrix.Click += new System.EventHandler(this.ClearMatrix_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gilroy Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 62);
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
            this.OutMatrix.Location = new System.Drawing.Point(11, 172);
            this.OutMatrix.Name = "OutMatrix";
            this.OutMatrix.ReadOnly = true;
            this.OutMatrix.Size = new System.Drawing.Size(499, 216);
            this.OutMatrix.TabIndex = 14;
            this.OutMatrix.Text = "";
            // 
            // textBoxRow
            // 
            this.textBoxRow.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRow.Location = new System.Drawing.Point(223, 52);
            this.textBoxRow.Multiline = true;
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.Size = new System.Drawing.Size(43, 39);
            this.textBoxRow.TabIndex = 17;
            this.textBoxRow.TextChanged += new System.EventHandler(this.TextBoxRow_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 610);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

