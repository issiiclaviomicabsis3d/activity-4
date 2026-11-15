namespace CLAVIOMICA_INVENTORY
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            panel1 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            label9 = new Label();
            btn3 = new Button();
            panel4 = new Panel();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            lblWelcome = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            cardCategories = new Panel();
            lblCategoriesValue = new Label();
            pictureBox1 = new PictureBox();
            lblCategoriesCaption = new Label();
            cardLowStock = new Panel();
            lblLowStockValue = new Label();
            lblLowStockCaption = new Label();
            pictureBox4 = new PictureBox();
            cardProducts = new Panel();
            pictureBox3 = new PictureBox();
            lblProductsValue = new Label();
            lblProductsCaption = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            Column12 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            cardCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cardLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            cardProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 78, 121);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cardCategories);
            panel1.Controls.Add(cardLowStock);
            panel1.Controls.Add(cardProducts);
            panel1.Controls.Add(lblSubtitle);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 844);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(51, 550);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1004, 279);
            panel5.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column12, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(2, 2);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1002, 271);
            dataGridView1.TabIndex = 0;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(112, 173, 71);
            btn4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.Lavender;
            btn4.Location = new Point(935, 378);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(180, 40);
            btn4.TabIndex = 16;
            btn4.Text = "View Products";
            btn4.TextImageRelation = TextImageRelation.ImageAboveText;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(192, 80, 77);
            btn5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.ForeColor = Color.Lavender;
            btn5.Location = new Point(935, 434);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(180, 40);
            btn5.TabIndex = 15;
            btn5.Text = "Update";
            btn5.TextImageRelation = TextImageRelation.ImageAboveText;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Goldenrod;
            btn6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.ForeColor = Color.Lavender;
            btn6.Location = new Point(935, 489);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(180, 40);
            btn6.TabIndex = 14;
            btn6.Text = "Delete";
            btn6.TextImageRelation = TextImageRelation.ImageAboveText;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Lavender;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.ForeColor = Color.FromArgb(31, 78, 121);
            label9.Location = new Point(794, 41);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(303, 30);
            label9.TabIndex = 13;
            label9.Text = "Welcome back, Administrator!";
            // 
            // btn3
            // 
            btn3.BackColor = Color.Lavender;
            btn3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.FromArgb(31, 78, 121);
            btn3.Location = new Point(935, 321);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(180, 40);
            btn3.TabIndex = 0;
            btn3.Text = "Add Product";
            btn3.TextImageRelation = TextImageRelation.ImageAboveText;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(comboBox3);
            panel4.Location = new Point(9, 320);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(916, 208);
            panel4.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(609, 145);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 36);
            comboBox1.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textBox4.Location = new Point(609, 85);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(283, 34);
            textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textBox3.Location = new Point(609, 21);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 34);
            textBox3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(31, 78, 121);
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.ForeColor = Color.Lavender;
            label8.Location = new Point(486, 22);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 30);
            label8.TabIndex = 13;
            label8.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(31, 78, 121);
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Lavender;
            label7.Location = new Point(486, 85);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 30);
            label7.TabIndex = 12;
            label7.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(31, 78, 121);
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Lavender;
            label6.Location = new Point(486, 145);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 30);
            label6.TabIndex = 11;
            label6.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(31, 78, 121);
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Lavender;
            label4.Location = new Point(8, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 30);
            label4.TabIndex = 4;
            label4.Text = "Product ID:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textBox2.Location = new Point(171, 84);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 34);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(31, 78, 121);
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Lavender;
            label5.Location = new Point(8, 145);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 30);
            label5.TabIndex = 5;
            label5.Text = "Category:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textBox1.Location = new Point(171, 16);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 34);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(31, 78, 121);
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Lavender;
            label3.Location = new Point(8, 84);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 0;
            label3.Text = "Product Name:";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(171, 145);
            comboBox3.Margin = new Padding(4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(283, 36);
            comboBox3.TabIndex = 10;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10.8F);
            lblWelcome.ForeColor = Color.FromArgb(31, 78, 121);
            lblWelcome.Location = new Point(800, 41);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(297, 30);
            lblWelcome.TabIndex = 11;
            lblWelcome.Text = "Welcome back, Administrator";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(871, 140);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 156);
            panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 31);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(82, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 65);
            label1.TabIndex = 0;
            label1.Text = "4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(76, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 1;
            label2.Text = "Out of Stock";
            // 
            // cardCategories
            // 
            cardCategories.BackColor = Color.Lavender;
            cardCategories.BorderStyle = BorderStyle.Fixed3D;
            cardCategories.Controls.Add(lblCategoriesValue);
            cardCategories.Controls.Add(pictureBox1);
            cardCategories.Controls.Add(lblCategoriesCaption);
            cardCategories.Location = new Point(586, 140);
            cardCategories.Margin = new Padding(4);
            cardCategories.Name = "cardCategories";
            cardCategories.Size = new Size(234, 156);
            cardCategories.TabIndex = 8;
            // 
            // lblCategoriesValue
            // 
            lblCategoriesValue.AutoSize = true;
            lblCategoriesValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCategoriesValue.ForeColor = Color.FromArgb(112, 173, 71);
            lblCategoriesValue.Location = new Point(89, 24);
            lblCategoriesValue.Margin = new Padding(4, 0, 4, 0);
            lblCategoriesValue.Name = "lblCategoriesValue";
            lblCategoriesValue.Size = new Size(84, 65);
            lblCategoriesValue.TabIndex = 0;
            lblCategoriesValue.Text = "12";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 31);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblCategoriesCaption
            // 
            lblCategoriesCaption.AutoSize = true;
            lblCategoriesCaption.Font = new Font("Segoe UI", 10.8F);
            lblCategoriesCaption.ForeColor = Color.DimGray;
            lblCategoriesCaption.Location = new Point(89, 91);
            lblCategoriesCaption.Margin = new Padding(4, 0, 4, 0);
            lblCategoriesCaption.Name = "lblCategoriesCaption";
            lblCategoriesCaption.Size = new Size(110, 30);
            lblCategoriesCaption.TabIndex = 1;
            lblCategoriesCaption.Text = "Low Stock";
            lblCategoriesCaption.Click += lblCategoriesCaption_Click;
            // 
            // cardLowStock
            // 
            cardLowStock.BackColor = Color.Lavender;
            cardLowStock.BorderStyle = BorderStyle.Fixed3D;
            cardLowStock.Controls.Add(lblLowStockValue);
            cardLowStock.Controls.Add(lblLowStockCaption);
            cardLowStock.Controls.Add(pictureBox4);
            cardLowStock.Location = new Point(304, 140);
            cardLowStock.Margin = new Padding(4);
            cardLowStock.Name = "cardLowStock";
            cardLowStock.Size = new Size(234, 156);
            cardLowStock.TabIndex = 7;
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.AutoSize = true;
            lblLowStockValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblLowStockValue.ForeColor = Color.FromArgb(192, 80, 77);
            lblLowStockValue.Location = new Point(80, 24);
            lblLowStockValue.Margin = new Padding(4, 0, 4, 0);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(112, 65);
            lblLowStockValue.TabIndex = 0;
            lblLowStockValue.Text = "218";
            // 
            // lblLowStockCaption
            // 
            lblLowStockCaption.AutoSize = true;
            lblLowStockCaption.Font = new Font("Segoe UI", 10.8F);
            lblLowStockCaption.ForeColor = Color.DimGray;
            lblLowStockCaption.Location = new Point(80, 91);
            lblLowStockCaption.Margin = new Padding(4, 0, 4, 0);
            lblLowStockCaption.Name = "lblLowStockCaption";
            lblLowStockCaption.Size = new Size(89, 30);
            lblLowStockCaption.TabIndex = 1;
            lblLowStockCaption.Text = "In Stock";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(4, 31);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(75, 99);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // cardProducts
            // 
            cardProducts.BackColor = Color.Lavender;
            cardProducts.BorderStyle = BorderStyle.Fixed3D;
            cardProducts.Controls.Add(pictureBox3);
            cardProducts.Controls.Add(lblProductsValue);
            cardProducts.Controls.Add(lblProductsCaption);
            cardProducts.Location = new Point(21, 140);
            cardProducts.Margin = new Padding(4);
            cardProducts.Name = "cardProducts";
            cardProducts.Size = new Size(234, 156);
            cardProducts.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(4, 31);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // lblProductsValue
            // 
            lblProductsValue.AutoSize = true;
            lblProductsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblProductsValue.ForeColor = Color.FromArgb(31, 78, 121);
            lblProductsValue.Location = new Point(74, 24);
            lblProductsValue.Margin = new Padding(4, 0, 4, 0);
            lblProductsValue.Name = "lblProductsValue";
            lblProductsValue.Size = new Size(112, 65);
            lblProductsValue.TabIndex = 0;
            lblProductsValue.Text = "234";
            // 
            // lblProductsCaption
            // 
            lblProductsCaption.AutoSize = true;
            lblProductsCaption.Font = new Font("Segoe UI", 10.8F);
            lblProductsCaption.ForeColor = Color.DimGray;
            lblProductsCaption.Location = new Point(74, 91);
            lblProductsCaption.Margin = new Padding(4, 0, 4, 0);
            lblProductsCaption.Name = "lblProductsCaption";
            lblProductsCaption.Size = new Size(149, 30);
            lblProductsCaption.TabIndex = 1;
            lblProductsCaption.Text = "Total Products";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10.8F);
            lblSubtitle.ForeColor = Color.Lavender;
            lblSubtitle.Location = new Point(31, 79);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(330, 30);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Manage your inventory products";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lavender;
            lblTitle.Location = new Point(21, 16);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(488, 61);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Product Management";
            // 
            // Column12
            // 
            Column12.HeaderText = "Product ID";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Product Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Category";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Price";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Status";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Product";
            Size = new Size(1134, 844);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            cardCategories.ResumeLayout(false);
            cardCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cardLowStock.ResumeLayout(false);
            cardLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            cardProducts.ResumeLayout(false);
            cardProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel cardCategories;
        private Label lblCategoriesValue;
        private Label lblCategoriesCaption;
        private Panel cardLowStock;
        private Label lblLowStockValue;
        private Label lblLowStockCaption;
        private Panel cardProducts;
        private Label lblProductsValue;
        private Label lblProductsCaption;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private TextBox textBox1;
        private Button btn3;
        private Label lblWelcome;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private Button button3;
        private Button button2;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Panel panel5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
