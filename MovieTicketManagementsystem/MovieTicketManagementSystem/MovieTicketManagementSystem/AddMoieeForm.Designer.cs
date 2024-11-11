namespace MovieTicketManagementSystem
{
    partial class AddMoieeForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.clearMovie_Btn = new System.Windows.Forms.Button();
            this.deleteMovie_Btn = new System.Windows.Forms.Button();
            this.updateMovie_Btn = new System.Windows.Forms.Button();
            this.addMovie_Btn = new System.Windows.Forms.Button();
            this.capacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addMovie_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.ComboBox();
            this.movieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMovie_movieID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(24, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 282);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 212);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "All Movies";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.clearMovie_Btn);
            this.panel2.Controls.Add(this.deleteMovie_Btn);
            this.panel2.Controls.Add(this.updateMovie_Btn);
            this.panel2.Controls.Add(this.addMovie_Btn);
            this.panel2.Controls.Add(this.capacity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addMovie_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.genre);
            this.panel2.Controls.Add(this.movieName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addMovie_movieID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(24, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 463);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(580, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Status:";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Available",
            "Unavailable",
            "Deleted"});
            this.status.Location = new System.Drawing.Point(665, 220);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(216, 28);
            this.status.TabIndex = 25;
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
            // 
            // clearMovie_Btn
            // 
            this.clearMovie_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.clearMovie_Btn.FlatAppearance.BorderSize = 0;
            this.clearMovie_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.clearMovie_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.clearMovie_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearMovie_Btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearMovie_Btn.ForeColor = System.Drawing.Color.White;
            this.clearMovie_Btn.Location = new System.Drawing.Point(814, 341);
            this.clearMovie_Btn.Name = "clearMovie_Btn";
            this.clearMovie_Btn.Size = new System.Drawing.Size(129, 45);
            this.clearMovie_Btn.TabIndex = 24;
            this.clearMovie_Btn.Text = "CLEAR";
            this.clearMovie_Btn.UseVisualStyleBackColor = false;
            this.clearMovie_Btn.Click += new System.EventHandler(this.clearMovie_Btn_Click);
            // 
            // deleteMovie_Btn
            // 
            this.deleteMovie_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.deleteMovie_Btn.FlatAppearance.BorderSize = 0;
            this.deleteMovie_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.deleteMovie_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.deleteMovie_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMovie_Btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMovie_Btn.ForeColor = System.Drawing.Color.White;
            this.deleteMovie_Btn.Location = new System.Drawing.Point(648, 341);
            this.deleteMovie_Btn.Name = "deleteMovie_Btn";
            this.deleteMovie_Btn.Size = new System.Drawing.Size(129, 45);
            this.deleteMovie_Btn.TabIndex = 23;
            this.deleteMovie_Btn.Text = "DELETE";
            this.deleteMovie_Btn.UseVisualStyleBackColor = false;
            this.deleteMovie_Btn.Click += new System.EventHandler(this.deleteMovie_Btn_Click);
            // 
            // updateMovie_Btn
            // 
            this.updateMovie_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.updateMovie_Btn.FlatAppearance.BorderSize = 0;
            this.updateMovie_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.updateMovie_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.updateMovie_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateMovie_Btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMovie_Btn.ForeColor = System.Drawing.Color.White;
            this.updateMovie_Btn.Location = new System.Drawing.Point(413, 341);
            this.updateMovie_Btn.Name = "updateMovie_Btn";
            this.updateMovie_Btn.Size = new System.Drawing.Size(129, 45);
            this.updateMovie_Btn.TabIndex = 22;
            this.updateMovie_Btn.Text = "UPDATE";
            this.updateMovie_Btn.UseVisualStyleBackColor = false;
            this.updateMovie_Btn.Click += new System.EventHandler(this.updateMovie_Btn_Click);
            // 
            // addMovie_Btn
            // 
            this.addMovie_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_Btn.FlatAppearance.BorderSize = 0;
            this.addMovie_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_Btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_Btn.ForeColor = System.Drawing.Color.White;
            this.addMovie_Btn.Location = new System.Drawing.Point(246, 341);
            this.addMovie_Btn.Name = "addMovie_Btn";
            this.addMovie_Btn.Size = new System.Drawing.Size(129, 45);
            this.addMovie_Btn.TabIndex = 21;
            this.addMovie_Btn.Text = "ADD";
            this.addMovie_Btn.UseVisualStyleBackColor = false;
            this.addMovie_Btn.Click += new System.EventHandler(this.addMovie_Btn_Click);
            // 
            // capacity
            // 
            this.capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.Location = new System.Drawing.Point(665, 153);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(216, 27);
            this.capacity.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(560, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Capacity:";
            // 
            // addMovie_importBtn
            // 
            this.addMovie_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_importBtn.FlatAppearance.BorderSize = 0;
            this.addMovie_importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_importBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_importBtn.ForeColor = System.Drawing.Color.White;
            this.addMovie_importBtn.Location = new System.Drawing.Point(1010, 242);
            this.addMovie_importBtn.Name = "addMovie_importBtn";
            this.addMovie_importBtn.Size = new System.Drawing.Size(140, 34);
            this.addMovie_importBtn.TabIndex = 18;
            this.addMovie_importBtn.Text = "Import";
            this.addMovie_importBtn.UseVisualStyleBackColor = false;
            this.addMovie_importBtn.Click += new System.EventHandler(this.addMovie_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1010, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 157);
            this.panel3.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(665, 92);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(216, 27);
            this.price.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(586, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(217, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Genre:";
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.FormattingEnabled = true;
            this.genre.Items.AddRange(new object[] {
            "Educational",
            "Comedy",
            "Drama",
            "Action",
            "Horror"});
            this.genre.Location = new System.Drawing.Point(320, 220);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(216, 28);
            this.genre.TabIndex = 13;
            // 
            // movieName
            // 
            this.movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieName.Location = new System.Drawing.Point(320, 157);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(216, 27);
            this.movieName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(179, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Movie Name:";
            // 
            // addMovie_movieID
            // 
            this.addMovie_movieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_movieID.Location = new System.Drawing.Point(320, 92);
            this.addMovie_movieID.Name = "addMovie_movieID";
            this.addMovie_movieID.Size = new System.Drawing.Size(216, 27);
            this.addMovie_movieID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(204, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Movie ID:";
            // 
            // AddMoieeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddMoieeForm";
            this.Size = new System.Drawing.Size(1294, 804);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addMovie_movieID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.TextBox movieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addMovie_importBtn;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearMovie_Btn;
        private System.Windows.Forms.Button deleteMovie_Btn;
        private System.Windows.Forms.Button updateMovie_Btn;
        private System.Windows.Forms.Button addMovie_Btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox status;
    }
}
