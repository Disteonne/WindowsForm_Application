using System.Windows.Forms;

namespace labs_forms
{
    partial class DataBaseWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameReceipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByNameClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByPhoneClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSearchNext = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Правка = new System.Windows.Forms.TabControl();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Правка.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.nameClient,
            this.phoneClient,
            this.nameReceipt,
            this.address,
            this.date,
            this.Index});
            this.dataGridView1.Location = new System.Drawing.Point(22, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Имя товара";
            this.name.MinimumWidth = 20;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "Стоимость товара";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // nameClient
            // 
            this.nameClient.HeaderText = "Имя клиента";
            this.nameClient.MinimumWidth = 6;
            this.nameClient.Name = "nameClient";
            this.nameClient.ReadOnly = true;
            this.nameClient.Width = 150;
            // 
            // phoneClient
            // 
            this.phoneClient.HeaderText = "Номер тлф";
            this.phoneClient.MinimumWidth = 6;
            this.phoneClient.Name = "phoneClient";
            this.phoneClient.ReadOnly = true;
            this.phoneClient.Width = 150;
            // 
            // nameReceipt
            // 
            this.nameReceipt.HeaderText = "Ломбард";
            this.nameReceipt.MinimumWidth = 6;
            this.nameReceipt.Name = "nameReceipt";
            this.nameReceipt.ReadOnly = true;
            this.nameReceipt.Width = 150;
            // 
            // address
            // 
            this.address.HeaderText = "Адрес";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Visible = false;
            this.Index.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1311, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.отобразитьToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.viewToolStripMenuItem.Text = "Вид";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByNameClientToolStripMenuItem,
            this.sortByPhoneClientToolStripMenuItem,
            this.sortByPriceToolStripMenuItem,
            this.sortByDateToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.sortToolStripMenuItem.Text = "Сортировать";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // sortByNameClientToolStripMenuItem
            // 
            this.sortByNameClientToolStripMenuItem.Name = "sortByNameClientToolStripMenuItem";
            this.sortByNameClientToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.sortByNameClientToolStripMenuItem.Text = "По имени клиента";
            this.sortByNameClientToolStripMenuItem.Click += new System.EventHandler(this.sortByNameClientToolStripMenuItem_Click);
            // 
            // sortByPhoneClientToolStripMenuItem
            // 
            this.sortByPhoneClientToolStripMenuItem.Name = "sortByPhoneClientToolStripMenuItem";
            this.sortByPhoneClientToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.sortByPhoneClientToolStripMenuItem.Text = "По телефону клиента";
            this.sortByPhoneClientToolStripMenuItem.Click += new System.EventHandler(this.sortByPhoneClientToolStripMenuItem_Click);
            // 
            // sortByPriceToolStripMenuItem
            // 
            this.sortByPriceToolStripMenuItem.Name = "sortByPriceToolStripMenuItem";
            this.sortByPriceToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.sortByPriceToolStripMenuItem.Text = "По цене сделки";
            this.sortByPriceToolStripMenuItem.Click += new System.EventHandler(this.sortByPriceToolStripMenuItem_Click);
            // 
            // sortByDateToolStripMenuItem
            // 
            this.sortByDateToolStripMenuItem.Name = "sortByDateToolStripMenuItem";
            this.sortByDateToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.sortByDateToolStripMenuItem.Text = "По дате сделки";
            this.sortByDateToolStripMenuItem.Click += new System.EventHandler(this.sortByDateToolStripMenuItem_Click);
            // 
            // отобразитьToolStripMenuItem
            // 
            this.отобразитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.priceToolStripMenuItem,
            this.nameClientToolStripMenuItem,
            this.phoneClientToolStripMenuItem,
            this.nameReceiptToolStripMenuItem,
            this.addressToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.отобразитьToolStripMenuItem.Name = "отобразитьToolStripMenuItem";
            this.отобразитьToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.отобразитьToolStripMenuItem.Text = "Вкл/выкл отображение";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.nameToolStripMenuItem.Text = "Имя клиента";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.priceToolStripMenuItem.Text = "Цена сделки";
            this.priceToolStripMenuItem.Click += new System.EventHandler(this.priceToolStripMenuItem_Click);
            // 
            // nameClientToolStripMenuItem
            // 
            this.nameClientToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.nameClientToolStripMenuItem.Name = "nameClientToolStripMenuItem";
            this.nameClientToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.nameClientToolStripMenuItem.Text = "Имя клиента";
            this.nameClientToolStripMenuItem.Click += new System.EventHandler(this.nameClientToolStripMenuItem_Click);
            // 
            // phoneClientToolStripMenuItem
            // 
            this.phoneClientToolStripMenuItem.Name = "phoneClientToolStripMenuItem";
            this.phoneClientToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.phoneClientToolStripMenuItem.Text = "Телефон клиента";
            this.phoneClientToolStripMenuItem.Click += new System.EventHandler(this.phoneClientToolStripMenuItem_Click);
            // 
            // nameReceiptToolStripMenuItem
            // 
            this.nameReceiptToolStripMenuItem.Name = "nameReceiptToolStripMenuItem";
            this.nameReceiptToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.nameReceiptToolStripMenuItem.Text = "Ломбард";
            this.nameReceiptToolStripMenuItem.Click += new System.EventHandler(this.nameReceiptToolStripMenuItem_Click);
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.addressToolStripMenuItem.Text = "Адрес местонахождения";
            this.addressToolStripMenuItem.Click += new System.EventHandler(this.addressToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.dateToolStripMenuItem.Text = "Дата";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Location = new System.Drawing.Point(831, 29);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(1108, 303);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Дата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Дата";
            this.label7.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(8, 178);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(281, 27);
            this.textBox7.TabIndex = 0;
            this.textBox7.Text = "01/01/21";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Номер телефона";
            this.label4.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.saveAsToolStripMenuItem.Text = "Сохранить как ...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1297, 319);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Запрос";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(1099, 312);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя товара";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Стоимость товара";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя клиента";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер тлф";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ломбард";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(1115, 5);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(170, 50);
            this.button7.TabIndex = 1;
            this.button7.Text = "Вызвать помошника для запросов";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AllowDrop = true;
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1297, 319);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Правка";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.buttonDel);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.buttonSearchNext);
            this.groupBox2.Controls.Add(this.buttonReplace);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Location = new System.Drawing.Point(1121, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(163, 303);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(8, 29);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(147, 35);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.Location = new System.Drawing.Point(8, 74);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(147, 35);
            this.buttonDel.TabIndex = 0;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(8, 118);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(147, 35);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSearchNext
            // 
            this.buttonSearchNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchNext.Location = new System.Drawing.Point(8, 163);
            this.buttonSearchNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearchNext.Name = "buttonSearchNext";
            this.buttonSearchNext.Size = new System.Drawing.Size(147, 35);
            this.buttonSearchNext.TabIndex = 0;
            this.buttonSearchNext.Text = "Найти далее";
            this.buttonSearchNext.UseVisualStyleBackColor = true;
            this.buttonSearchNext.Click += new System.EventHandler(this.buttonSearchNext_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Location = new System.Drawing.Point(8, 208);
            this.buttonReplace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(147, 35);
            this.buttonReplace.TabIndex = 0;
            this.buttonReplace.Text = "Заменить";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(8, 252);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(147, 35);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Очистить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1108, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные для ввода, поиска и редактирования";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.textBox8);
            this.groupBox7.Location = new System.Drawing.Point(864, 30);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(250, 257);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Дата";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Дата обращения";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 119);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(238, 27);
            this.textBox8.TabIndex = 0;
            this.textBox8.Text = "01/01/21";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(8, 30);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(275, 264);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Контактные данные клиента";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Номер тлф-на";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя клиента";
            this.label3.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 89);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(257, 27);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Имя клиента";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 178);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(257, 27);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "88005553535";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Location = new System.Drawing.Point(283, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(267, 265);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация о товаре";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование товара";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена товара";
            this.label2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(0, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Наименование товара";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 178);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 27);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "100.0";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Location = new System.Drawing.Point(557, 29);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(299, 265);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Информация о ломбарде";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ломбард";
            this.label5.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Адрес";
            this.label6.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 89);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(281, 27);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Название Ломбарда";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(8, 178);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(281, 27);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "пр.Гагарина 23";
            // 
            // Правка
            // 
            this.Правка.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Правка.Controls.Add(this.tabPage3);
            this.Правка.Controls.Add(this.tabPage1);
            this.Правка.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Правка.Location = new System.Drawing.Point(5, 310);
            this.Правка.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Правка.Multiline = true;
            this.Правка.Name = "Правка";
            this.Правка.SelectedIndex = 0;
            this.Правка.Size = new System.Drawing.Size(1305, 352);
            this.Правка.TabIndex = 2;
            this.Правка.SelectedIndexChanged += new System.EventHandler(this.Правка_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить как...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataBaseWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 665);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Правка);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DataBaseWorker";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Правка.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;

        public void PleaseClose()
        {
            checkNotSaveData();
            this.Close();
        }

        public void checkNotSaveData()
        {
            // add checkto unsave data
        }
        private System.Windows.Forms.GroupBox groupBox6;//дата сделки
        private System.Windows.Forms.Label label7;//data
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ToolStripMenuItem с;
        private System.Windows.Forms.ToolStripMenuItem sortByPhoneClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByAddressМестонахожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByDateToolStripMenuItem;
        private Label label4;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn nameClient;
        private DataGridViewTextBoxColumn phoneClient;
        private DataGridViewTextBoxColumn nameReceipt;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Index;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TabPage tabPage1;
        public DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Button button7;
        private TabPage tabPage3;
        private GroupBox groupBox2;
        private Button buttonAdd;
        private Button buttonDel;
        private Button buttonSearch;
        private Button buttonSearchNext;
        private Button buttonReplace;
        private Button buttonDelete;
        private GroupBox groupBox1;
        private GroupBox groupBox7;
        private Label label10;
        private TextBox textBox8;
        private GroupBox groupBox3;
        private Label label8;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox4;
        private Label label9;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox5;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private TabControl Правка;
        private ToolStripMenuItem sortByNameClientToolStripMenuItem;
        private Button button2;
    }
}

