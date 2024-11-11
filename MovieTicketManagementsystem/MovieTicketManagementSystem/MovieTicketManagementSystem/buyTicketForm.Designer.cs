namespace MovieTicketManagementSystem
{
    partial class buyTicketForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buyTicket_clear = new System.Windows.Forms.Button();
            this.buyTicket_selectMovie = new System.Windows.Forms.Button();
            this.buyTicket_regularPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buyTicket_genre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buyTicket_movieName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buyTicket_moiveID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buyTicket_clearFields = new System.Windows.Forms.Button();
            this.buyTicket_receiptBtn = new System.Windows.Forms.Button();
            this.buyTicket_buyBtn = new System.Windows.Forms.Button();
            this.buyTicket_change = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buyTicket_amount = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buyTicket_totalPrice = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buyTicket_drinks = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buyTicket_foods = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buyTicket_availableChairs = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buyTicket_seatType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(21, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 359);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(23, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 274);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Available Movies";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buyTicket_clear);
            this.panel2.Controls.Add(this.buyTicket_selectMovie);
            this.panel2.Controls.Add(this.buyTicket_regularPrice);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.buyTicket_genre);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buyTicket_movieName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buyTicket_moiveID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(21, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 386);
            this.panel2.TabIndex = 1;
            // 
            // buyTicket_clear
            // 
            this.buyTicket_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_clear.FlatAppearance.BorderSize = 0;
            this.buyTicket_clear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_clear.ForeColor = System.Drawing.Color.White;
            this.buyTicket_clear.Location = new System.Drawing.Point(576, 312);
            this.buyTicket_clear.Name = "buyTicket_clear";
            this.buyTicket_clear.Size = new System.Drawing.Size(186, 45);
            this.buyTicket_clear.TabIndex = 23;
            this.buyTicket_clear.Text = "CLEAR";
            this.buyTicket_clear.UseVisualStyleBackColor = false;
            // 
            // buyTicket_selectMovie
            // 
            this.buyTicket_selectMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_selectMovie.FlatAppearance.BorderSize = 0;
            this.buyTicket_selectMovie.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_selectMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_selectMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_selectMovie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_selectMovie.ForeColor = System.Drawing.Color.White;
            this.buyTicket_selectMovie.Location = new System.Drawing.Point(329, 312);
            this.buyTicket_selectMovie.Name = "buyTicket_selectMovie";
            this.buyTicket_selectMovie.Size = new System.Drawing.Size(186, 45);
            this.buyTicket_selectMovie.TabIndex = 22;
            this.buyTicket_selectMovie.Text = "SELECT MOVIE";
            this.buyTicket_selectMovie.UseVisualStyleBackColor = false;
            // 
            // buyTicket_regularPrice
            // 
            this.buyTicket_regularPrice.AutoSize = true;
            this.buyTicket_regularPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_regularPrice.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_regularPrice.Location = new System.Drawing.Point(509, 214);
            this.buyTicket_regularPrice.Name = "buyTicket_regularPrice";
            this.buyTicket_regularPrice.Size = new System.Drawing.Size(27, 19);
            this.buyTicket_regularPrice.TabIndex = 17;
            this.buyTicket_regularPrice.Text = "---";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(355, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Regular Price:";
            // 
            // buyTicket_genre
            // 
            this.buyTicket_genre.AutoSize = true;
            this.buyTicket_genre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_genre.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_genre.Location = new System.Drawing.Point(509, 170);
            this.buyTicket_genre.Name = "buyTicket_genre";
            this.buyTicket_genre.Size = new System.Drawing.Size(27, 19);
            this.buyTicket_genre.TabIndex = 15;
            this.buyTicket_genre.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(410, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Genre:";
            // 
            // buyTicket_movieName
            // 
            this.buyTicket_movieName.AutoSize = true;
            this.buyTicket_movieName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_movieName.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_movieName.Location = new System.Drawing.Point(509, 125);
            this.buyTicket_movieName.Name = "buyTicket_movieName";
            this.buyTicket_movieName.Size = new System.Drawing.Size(27, 19);
            this.buyTicket_movieName.TabIndex = 13;
            this.buyTicket_movieName.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(366, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Movie Name:";
            // 
            // buyTicket_moiveID
            // 
            this.buyTicket_moiveID.AutoSize = true;
            this.buyTicket_moiveID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_moiveID.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_moiveID.Location = new System.Drawing.Point(509, 79);
            this.buyTicket_moiveID.Name = "buyTicket_moiveID";
            this.buyTicket_moiveID.Size = new System.Drawing.Size(27, 19);
            this.buyTicket_moiveID.TabIndex = 11;
            this.buyTicket_moiveID.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(393, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Movie ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(44, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 309);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buyTicket_clearFields);
            this.panel3.Controls.Add(this.buyTicket_receiptBtn);
            this.panel3.Controls.Add(this.buyTicket_buyBtn);
            this.panel3.Controls.Add(this.buyTicket_change);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.buyTicket_amount);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.buyTicket_totalPrice);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.buyTicket_drinks);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.buyTicket_foods);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.buyTicket_availableChairs);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.buyTicket_seatType);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(847, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 765);
            this.panel3.TabIndex = 2;
            // 
            // buyTicket_clearFields
            // 
            this.buyTicket_clearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_clearFields.FlatAppearance.BorderSize = 0;
            this.buyTicket_clearFields.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_clearFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_clearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_clearFields.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_clearFields.ForeColor = System.Drawing.Color.White;
            this.buyTicket_clearFields.Location = new System.Drawing.Point(62, 691);
            this.buyTicket_clearFields.Name = "buyTicket_clearFields";
            this.buyTicket_clearFields.Size = new System.Drawing.Size(297, 45);
            this.buyTicket_clearFields.TabIndex = 39;
            this.buyTicket_clearFields.Text = "CLEAR";
            this.buyTicket_clearFields.UseVisualStyleBackColor = false;
            // 
            // buyTicket_receiptBtn
            // 
            this.buyTicket_receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_receiptBtn.FlatAppearance.BorderSize = 0;
            this.buyTicket_receiptBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_receiptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_receiptBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicket_receiptBtn.Location = new System.Drawing.Point(62, 616);
            this.buyTicket_receiptBtn.Name = "buyTicket_receiptBtn";
            this.buyTicket_receiptBtn.Size = new System.Drawing.Size(297, 45);
            this.buyTicket_receiptBtn.TabIndex = 38;
            this.buyTicket_receiptBtn.Text = "RECEIPT ";
            this.buyTicket_receiptBtn.UseVisualStyleBackColor = false;
            // 
            // buyTicket_buyBtn
            // 
            this.buyTicket_buyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_buyBtn.FlatAppearance.BorderSize = 0;
            this.buyTicket_buyBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_buyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buyTicket_buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_buyBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_buyBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicket_buyBtn.Location = new System.Drawing.Point(62, 536);
            this.buyTicket_buyBtn.Name = "buyTicket_buyBtn";
            this.buyTicket_buyBtn.Size = new System.Drawing.Size(297, 45);
            this.buyTicket_buyBtn.TabIndex = 26;
            this.buyTicket_buyBtn.Text = "BUY";
            this.buyTicket_buyBtn.UseVisualStyleBackColor = false;
            // 
            // buyTicket_change
            // 
            this.buyTicket_change.AutoSize = true;
            this.buyTicket_change.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_change.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_change.Location = new System.Drawing.Point(180, 461);
            this.buyTicket_change.Name = "buyTicket_change";
            this.buyTicket_change.Size = new System.Drawing.Size(50, 19);
            this.buyTicket_change.TabIndex = 37;
            this.buyTicket_change.Text = "$0.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(79, 461);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 19);
            this.label20.TabIndex = 36;
            this.label20.Text = "Change:";
            // 
            // buyTicket_amount
            // 
            this.buyTicket_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_amount.Location = new System.Drawing.Point(184, 400);
            this.buyTicket_amount.Name = "buyTicket_amount";
            this.buyTicket_amount.Size = new System.Drawing.Size(211, 27);
            this.buyTicket_amount.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(81, 408);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 19);
            this.label19.TabIndex = 34;
            this.label19.Text = "Amount:";
            // 
            // buyTicket_totalPrice
            // 
            this.buyTicket_totalPrice.AutoSize = true;
            this.buyTicket_totalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_totalPrice.ForeColor = System.Drawing.Color.Black;
            this.buyTicket_totalPrice.Location = new System.Drawing.Point(151, 338);
            this.buyTicket_totalPrice.Name = "buyTicket_totalPrice";
            this.buyTicket_totalPrice.Size = new System.Drawing.Size(60, 21);
            this.buyTicket_totalPrice.TabIndex = 33;
            this.buyTicket_totalPrice.Text = "$0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(28, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 21);
            this.label17.TabIndex = 32;
            this.label17.Text = "Total Price :";
            // 
            // buyTicket_drinks
            // 
            this.buyTicket_drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_drinks.FormattingEnabled = true;
            this.buyTicket_drinks.Items.AddRange(new object[] {
            "Orange Juice",
            "Softdrink",
            "Cocacola"});
            this.buyTicket_drinks.Location = new System.Drawing.Point(184, 264);
            this.buyTicket_drinks.Name = "buyTicket_drinks";
            this.buyTicket_drinks.Size = new System.Drawing.Size(211, 28);
            this.buyTicket_drinks.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(91, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 19);
            this.label16.TabIndex = 30;
            this.label16.Text = "Drinks:";
            // 
            // buyTicket_foods
            // 
            this.buyTicket_foods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_foods.FormattingEnabled = true;
            this.buyTicket_foods.Items.AddRange(new object[] {
            "Popcom",
            "Fries"});
            this.buyTicket_foods.Location = new System.Drawing.Point(184, 208);
            this.buyTicket_foods.Name = "buyTicket_foods";
            this.buyTicket_foods.Size = new System.Drawing.Size(211, 28);
            this.buyTicket_foods.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(91, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 19);
            this.label15.TabIndex = 28;
            this.label15.Text = "Foods:";
            // 
            // buyTicket_availableChairs
            // 
            this.buyTicket_availableChairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_availableChairs.FormattingEnabled = true;
            this.buyTicket_availableChairs.Items.AddRange(new object[] {
            "1st Class Seat",
            "2nd Class Seat",
            "Normal Seat"});
            this.buyTicket_availableChairs.Location = new System.Drawing.Point(184, 110);
            this.buyTicket_availableChairs.Name = "buyTicket_availableChairs";
            this.buyTicket_availableChairs.Size = new System.Drawing.Size(211, 28);
            this.buyTicket_availableChairs.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(19, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 19);
            this.label14.TabIndex = 26;
            this.label14.Text = "Available Chairs:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(29, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "Available Foods";
            // 
            // buyTicket_seatType
            // 
            this.buyTicket_seatType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_seatType.FormattingEnabled = true;
            this.buyTicket_seatType.Items.AddRange(new object[] {
            "1st Class Seat",
            "2nd Class Seat",
            "Normal Seat"});
            this.buyTicket_seatType.Location = new System.Drawing.Point(184, 59);
            this.buyTicket_seatType.Name = "buyTicket_seatType";
            this.buyTicket_seatType.Size = new System.Drawing.Size(211, 28);
            this.buyTicket_seatType.TabIndex = 25;
            this.buyTicket_seatType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(58, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Seat Type :";
            // 
            // buyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buyTicketForm";
            this.Size = new System.Drawing.Size(1294, 804);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label buyTicket_regularPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label buyTicket_genre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label buyTicket_movieName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label buyTicket_moiveID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buyTicket_clear;
        private System.Windows.Forms.Button buyTicket_selectMovie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox buyTicket_seatType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox buyTicket_drinks;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox buyTicket_foods;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox buyTicket_availableChairs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label buyTicket_totalPrice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buyTicket_buyBtn;
        private System.Windows.Forms.Label buyTicket_change;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox buyTicket_amount;
        private System.Windows.Forms.Button buyTicket_clearFields;
        private System.Windows.Forms.Button buyTicket_receiptBtn;
    }
}
