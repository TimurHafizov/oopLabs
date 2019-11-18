namespace lab8
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddBusInBase = new System.Windows.Forms.Button();
            this.SaveDB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DeleteZap = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруМаршрутаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруАвтобусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениВодителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteBase = new System.Windows.Forms.Button();
            this.ShowInRoute = new System.Windows.Forms.Button();
            this.dataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(574, 420);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            // 
            // AddBusInBase
            // 
            this.AddBusInBase.BackColor = System.Drawing.Color.Gainsboro;
            this.AddBusInBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBusInBase.Location = new System.Drawing.Point(592, 79);
            this.AddBusInBase.Name = "AddBusInBase";
            this.AddBusInBase.Size = new System.Drawing.Size(86, 62);
            this.AddBusInBase.TabIndex = 7;
            this.AddBusInBase.Text = "+";
            this.AddBusInBase.UseVisualStyleBackColor = false;
            this.AddBusInBase.Click += new System.EventHandler(this.AddBusInBase_Click);
            // 
            // SaveDB
            // 
            this.SaveDB.Location = new System.Drawing.Point(592, 372);
            this.SaveDB.Name = "SaveDB";
            this.SaveDB.Size = new System.Drawing.Size(178, 60);
            this.SaveDB.TabIndex = 8;
            this.SaveDB.Text = "Сохранить БД";
            this.SaveDB.UseVisualStyleBackColor = true;
            this.SaveDB.Click += new System.EventHandler(this.Button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // DeleteZap
            // 
            this.DeleteZap.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteZap.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteZap.Location = new System.Drawing.Point(684, 79);
            this.DeleteZap.Name = "DeleteZap";
            this.DeleteZap.Size = new System.Drawing.Size(86, 62);
            this.DeleteZap.TabIndex = 9;
            this.DeleteZap.Text = "-";
            this.DeleteZap.UseVisualStyleBackColor = false;
            this.DeleteZap.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(592, 156);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(32, 15, 32, 15);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(323, 54);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруМаршрутаToolStripMenuItem,
            this.поНомеруАвтобусаToolStripMenuItem,
            this.поИмениВодителяToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 24);
            this.toolStripMenuItem1.Text = "Сортировать";
            // 
            // поНомеруМаршрутаToolStripMenuItem
            // 
            this.поНомеруМаршрутаToolStripMenuItem.Name = "поНомеруМаршрутаToolStripMenuItem";
            this.поНомеруМаршрутаToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.поНомеруМаршрутаToolStripMenuItem.Text = "По номеру маршрута";
            this.поНомеруМаршрутаToolStripMenuItem.Click += new System.EventHandler(this.ПоНомеруМаршрутаToolStripMenuItem_Click);
            // 
            // поНомеруАвтобусаToolStripMenuItem
            // 
            this.поНомеруАвтобусаToolStripMenuItem.Name = "поНомеруАвтобусаToolStripMenuItem";
            this.поНомеруАвтобусаToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.поНомеруАвтобусаToolStripMenuItem.Text = "По номеру автобуса";
            this.поНомеруАвтобусаToolStripMenuItem.Click += new System.EventHandler(this.ПоНомеруАвтобусаToolStripMenuItem_Click);
            // 
            // поИмениВодителяToolStripMenuItem
            // 
            this.поИмениВодителяToolStripMenuItem.Name = "поИмениВодителяToolStripMenuItem";
            this.поИмениВодителяToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.поИмениВодителяToolStripMenuItem.Text = "По имени водителя";
            this.поИмениВодителяToolStripMenuItem.Click += new System.EventHandler(this.ПоИмениВодителяToolStripMenuItem_Click);
            // 
            // DeleteBase
            // 
            this.DeleteBase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteBase.Location = new System.Drawing.Point(592, 300);
            this.DeleteBase.Name = "DeleteBase";
            this.DeleteBase.Size = new System.Drawing.Size(178, 60);
            this.DeleteBase.TabIndex = 13;
            this.DeleteBase.Text = "Удалить БД";
            this.DeleteBase.UseVisualStyleBackColor = false;
            this.DeleteBase.Click += new System.EventHandler(this.DeleteBase_Click);
            // 
            // ShowInRoute
            // 
            this.ShowInRoute.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ShowInRoute.Location = new System.Drawing.Point(592, 228);
            this.ShowInRoute.Name = "ShowInRoute";
            this.ShowInRoute.Size = new System.Drawing.Size(178, 60);
            this.ShowInRoute.TabIndex = 14;
            this.ShowInRoute.Text = "Водители в маршруте";
            this.ShowInRoute.UseVisualStyleBackColor = false;
            this.ShowInRoute.Click += new System.EventHandler(this.ShowInRoute_Click);
            // 
            // dataBaseBindingSource
            // 
            this.dataBaseBindingSource.DataSource = typeof(lab8.DataBase);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 449);
            this.Controls.Add(this.ShowInRoute);
            this.Controls.Add(this.DeleteBase);
            this.Controls.Add(this.DeleteZap);
            this.Controls.Add(this.SaveDB);
            this.Controls.Add(this.AddBusInBase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная №8";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dataBaseBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddBusInBase;
        private System.Windows.Forms.Button SaveDB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button DeleteZap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поНомеруМаршрутаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНомеруАвтобусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениВодителяToolStripMenuItem;
        private System.Windows.Forms.Button DeleteBase;
        private System.Windows.Forms.Button ShowInRoute;
    }
}

