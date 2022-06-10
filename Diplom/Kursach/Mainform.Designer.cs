namespace Kursach
{
    partial class Mainform
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.addavt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автомобилиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursdbDataSet1 = new Kursach.kursdbDataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыполненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодМеханикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодКлиентаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотовыйТелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.кодМеханикаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотовыйТелефонDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.механикиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.кодУслугиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursdbDataSet = new Kursach.kursdbDataSet();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.механикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобилиTableAdapter = new Kursach.kursdbDataSetTableAdapters.АвтомобилиTableAdapter();
            this.заказыTableAdapter = new Kursach.kursdbDataSetTableAdapters.ЗаказыTableAdapter();
            this.клиентыTableAdapter = new Kursach.kursdbDataSetTableAdapters.КлиентыTableAdapter();
            this.механикиTableAdapter = new Kursach.kursdbDataSetTableAdapters.МеханикиTableAdapter();
            this.услугиTableAdapter = new Kursach.kursdbDataSetTableAdapters.УслугиTableAdapter();
            this.автомобилиTableAdapter1 = new Kursach.kursdbDataSet1TableAdapters.АвтомобилиTableAdapter();
            this.kursdbDataSet11 = new Kursach.kursdbDataSet1();
            this.услугиTableAdapter1 = new Kursach.kursdbDataSet1TableAdapters.УслугиTableAdapter();
            this.заказыTableAdapter1 = new Kursach.kursdbDataSet1TableAdapters.ЗаказыTableAdapter();
            this.заказыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter1 = new Kursach.kursdbDataSet1TableAdapters.КлиентыTableAdapter();
            this.механикиTableAdapter1 = new Kursach.kursdbDataSet1TableAdapters.МеханикиTableAdapter();
            this.button10 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursdbDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.механикиBindingSource1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.механикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursdbDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.addavt);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(877, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автомобили";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(87, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addavt
            // 
            this.addavt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.addavt.FlatAppearance.BorderSize = 0;
            this.addavt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addavt.ForeColor = System.Drawing.SystemColors.Window;
            this.addavt.Location = new System.Drawing.Point(6, 354);
            this.addavt.Name = "addavt";
            this.addavt.Size = new System.Drawing.Size(75, 23);
            this.addavt.TabIndex = 1;
            this.addavt.Text = "Добавить";
            this.addavt.UseVisualStyleBackColor = false;
            this.addavt.Click += new System.EventHandler(this.addavt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАвтомобиляDataGridViewTextBoxColumn,
            this.маркаАвтомобиляDataGridViewTextBoxColumn,
            this.модельАвтомобиляDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.автомобилиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(865, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодАвтомобиляDataGridViewTextBoxColumn
            // 
            this.кодАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Код автомобиля";
            this.кодАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Код автомобиля";
            this.кодАвтомобиляDataGridViewTextBoxColumn.Name = "кодАвтомобиляDataGridViewTextBoxColumn";
            // 
            // маркаАвтомобиляDataGridViewTextBoxColumn
            // 
            this.маркаАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Марка автомобиля";
            this.маркаАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Марка автомобиля";
            this.маркаАвтомобиляDataGridViewTextBoxColumn.Name = "маркаАвтомобиляDataGridViewTextBoxColumn";
            // 
            // модельАвтомобиляDataGridViewTextBoxColumn
            // 
            this.модельАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Модель автомобиля";
            this.модельАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Модель автомобиля";
            this.модельАвтомобиляDataGridViewTextBoxColumn.Name = "модельАвтомобиляDataGridViewTextBoxColumn";
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // автомобилиBindingSource1
            // 
            this.автомобилиBindingSource1.DataMember = "Автомобили";
            this.автомобилиBindingSource1.DataSource = this.kursdbDataSet1;
            // 
            // kursdbDataSet1
            // 
            this.kursdbDataSet1.DataSetName = "kursdbDataSet1";
            this.kursdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(877, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(84, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(3, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗаказаDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.датаВыполненияDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn1,
            this.кодМеханикаDataGridViewTextBoxColumn,
            this.кодУслугиDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.заказыBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(865, 343);
            this.dataGridView2.TabIndex = 0;
            // 
            // кодЗаказаDataGridViewTextBoxColumn
            // 
            this.кодЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Код заказа";
            this.кодЗаказаDataGridViewTextBoxColumn.HeaderText = "Код заказа";
            this.кодЗаказаDataGridViewTextBoxColumn.Name = "кодЗаказаDataGridViewTextBoxColumn";
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            // 
            // датаВыполненияDataGridViewTextBoxColumn
            // 
            this.датаВыполненияDataGridViewTextBoxColumn.DataPropertyName = "Дата выполнения";
            this.датаВыполненияDataGridViewTextBoxColumn.HeaderText = "Дата выполнения";
            this.датаВыполненияDataGridViewTextBoxColumn.Name = "датаВыполненияDataGridViewTextBoxColumn";
            // 
            // кодКлиентаDataGridViewTextBoxColumn1
            // 
            this.кодКлиентаDataGridViewTextBoxColumn1.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn1.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn1.Name = "кодКлиентаDataGridViewTextBoxColumn1";
            // 
            // кодМеханикаDataGridViewTextBoxColumn
            // 
            this.кодМеханикаDataGridViewTextBoxColumn.DataPropertyName = "Код механика";
            this.кодМеханикаDataGridViewTextBoxColumn.HeaderText = "Код механика";
            this.кодМеханикаDataGridViewTextBoxColumn.Name = "кодМеханикаDataGridViewTextBoxColumn";
            // 
            // кодУслугиDataGridViewTextBoxColumn
            // 
            this.кодУслугиDataGridViewTextBoxColumn.DataPropertyName = "Код услуги";
            this.кодУслугиDataGridViewTextBoxColumn.HeaderText = "Код услуги";
            this.кодУслугиDataGridViewTextBoxColumn.Name = "кодУслугиDataGridViewTextBoxColumn";
            // 
            // заказыBindingSource1
            // 
            this.заказыBindingSource1.DataMember = "Заказы";
            this.заказыBindingSource1.DataSource = this.kursdbDataSet1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Клиенты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(87, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(6, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКлиентаDataGridViewTextBoxColumn2,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.сотовыйТелефонDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.клиентыBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(868, 343);
            this.dataGridView3.TabIndex = 0;
            // 
            // кодКлиентаDataGridViewTextBoxColumn2
            // 
            this.кодКлиентаDataGridViewTextBoxColumn2.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn2.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn2.Name = "кодКлиентаDataGridViewTextBoxColumn2";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // сотовыйТелефонDataGridViewTextBoxColumn
            // 
            this.сотовыйТелефонDataGridViewTextBoxColumn.DataPropertyName = "Сотовый телефон";
            this.сотовыйТелефонDataGridViewTextBoxColumn.HeaderText = "Сотовый телефон";
            this.сотовыйТелефонDataGridViewTextBoxColumn.Name = "сотовыйТелефонDataGridViewTextBoxColumn";
            // 
            // клиентыBindingSource1
            // 
            this.клиентыBindingSource1.DataMember = "Клиенты";
            this.клиентыBindingSource1.DataSource = this.kursdbDataSet1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(877, 385);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Механики";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.Location = new System.Drawing.Point(84, 347);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.Window;
            this.button7.Location = new System.Drawing.Point(3, 347);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодМеханикаDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn1,
            this.отчествоDataGridViewTextBoxColumn1,
            this.сотовыйТелефонDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.механикиBindingSource1;
            this.dataGridView4.Location = new System.Drawing.Point(6, -2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(865, 343);
            this.dataGridView4.TabIndex = 0;
            // 
            // кодМеханикаDataGridViewTextBoxColumn1
            // 
            this.кодМеханикаDataGridViewTextBoxColumn1.DataPropertyName = "Код механика";
            this.кодМеханикаDataGridViewTextBoxColumn1.HeaderText = "Код механика";
            this.кодМеханикаDataGridViewTextBoxColumn1.Name = "кодМеханикаDataGridViewTextBoxColumn1";
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            // 
            // отчествоDataGridViewTextBoxColumn1
            // 
            this.отчествоDataGridViewTextBoxColumn1.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.Name = "отчествоDataGridViewTextBoxColumn1";
            // 
            // сотовыйТелефонDataGridViewTextBoxColumn1
            // 
            this.сотовыйТелефонDataGridViewTextBoxColumn1.DataPropertyName = "Сотовый телефон";
            this.сотовыйТелефонDataGridViewTextBoxColumn1.HeaderText = "Сотовый телефон";
            this.сотовыйТелефонDataGridViewTextBoxColumn1.Name = "сотовыйТелефонDataGridViewTextBoxColumn1";
            // 
            // механикиBindingSource1
            // 
            this.механикиBindingSource1.DataMember = "Механики";
            this.механикиBindingSource1.DataSource = this.kursdbDataSet1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button8);
            this.tabPage5.Controls.Add(this.button9);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(877, 385);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Услуги";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.Window;
            this.button8.Location = new System.Drawing.Point(87, 355);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.Window;
            this.button9.Location = new System.Drawing.Point(6, 355);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Добавить";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодУслугиDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.услугиBindingSource1;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(865, 343);
            this.dataGridView5.TabIndex = 0;
            // 
            // кодУслугиDataGridViewTextBoxColumn1
            // 
            this.кодУслугиDataGridViewTextBoxColumn1.DataPropertyName = "Код услуги";
            this.кодУслугиDataGridViewTextBoxColumn1.HeaderText = "Код услуги";
            this.кодУслугиDataGridViewTextBoxColumn1.Name = "кодУслугиDataGridViewTextBoxColumn1";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // услугиBindingSource1
            // 
            this.услугиBindingSource1.DataMember = "Услуги";
            this.услугиBindingSource1.DataSource = this.kursdbDataSet1;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.kursdbDataSet;
            // 
            // kursdbDataSet
            // 
            this.kursdbDataSet.DataSetName = "kursdbDataSet";
            this.kursdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.kursdbDataSet;
            // 
            // механикиBindingSource
            // 
            this.механикиBindingSource.DataMember = "Механики";
            this.механикиBindingSource.DataSource = this.kursdbDataSet;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.kursdbDataSet;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.kursdbDataSet;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // механикиTableAdapter
            // 
            this.механикиTableAdapter.ClearBeforeFill = true;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // автомобилиTableAdapter1
            // 
            this.автомобилиTableAdapter1.ClearBeforeFill = true;
            // 
            // kursdbDataSet11
            // 
            this.kursdbDataSet11.DataSetName = "kursdbDataSet1";
            this.kursdbDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // услугиTableAdapter1
            // 
            this.услугиTableAdapter1.ClearBeforeFill = true;
            // 
            // заказыTableAdapter1
            // 
            this.заказыTableAdapter1.ClearBeforeFill = true;
            // 
            // заказыBindingSource2
            // 
            this.заказыBindingSource2.DataMember = "Заказы";
            this.заказыBindingSource2.DataSource = this.kursdbDataSet1;
            // 
            // клиентыTableAdapter1
            // 
            this.клиентыTableAdapter1.ClearBeforeFill = true;
            // 
            // механикиTableAdapter1
            // 
            this.механикиTableAdapter1.ClearBeforeFill = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.Window;
            this.button10.Location = new System.Drawing.Point(818, 429);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "Выйти";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 491);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mainform";
            this.Text = "Зона ремонта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursdbDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.механикиBindingSource1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.механикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursdbDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TabPage tabPage2;
        public kursdbDataSet kursdbDataSet;
        public System.Windows.Forms.BindingSource автомобилиBindingSource;
        public kursdbDataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn кодАвтомобиляDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn маркаАвтомобиляDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn модельАвтомобиляDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource заказыBindingSource;
        public kursdbDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn кодЗаказаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn датаВыполненияDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn кодМеханикаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn кодУслугиDataGridViewTextBoxColumn;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.DataGridView dataGridView4;
        public System.Windows.Forms.BindingSource клиентыBindingSource;
        public kursdbDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn сотовыйТелефонDataGridViewTextBoxColumn;
        public System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.BindingSource механикиBindingSource;
        public kursdbDataSetTableAdapters.МеханикиTableAdapter механикиTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn кодМеханикаDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn сотовыйТелефонDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridView dataGridView5;
        public System.Windows.Forms.BindingSource услугиBindingSource;
        private kursdbDataSetTableAdapters.УслугиTableAdapter услугиTableAdapter;
        private System.Windows.Forms.Button addavt;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодУслугиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        public kursdbDataSet1 kursdbDataSet1;
        public System.Windows.Forms.BindingSource автомобилиBindingSource1;
        public kursdbDataSet1TableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter1;
        public kursdbDataSet1 kursdbDataSet11;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.BindingSource услугиBindingSource1;
        public kursdbDataSet1TableAdapters.УслугиTableAdapter услугиTableAdapter1;
        public System.Windows.Forms.BindingSource заказыBindingSource1;
        public kursdbDataSet1TableAdapters.ЗаказыTableAdapter заказыTableAdapter1;
        public System.Windows.Forms.BindingSource заказыBindingSource2;
        public System.Windows.Forms.BindingSource клиентыBindingSource1;
        public kursdbDataSet1TableAdapters.КлиентыTableAdapter клиентыTableAdapter1;
        public System.Windows.Forms.BindingSource механикиBindingSource1;
        public kursdbDataSet1TableAdapters.МеханикиTableAdapter механикиTableAdapter1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

