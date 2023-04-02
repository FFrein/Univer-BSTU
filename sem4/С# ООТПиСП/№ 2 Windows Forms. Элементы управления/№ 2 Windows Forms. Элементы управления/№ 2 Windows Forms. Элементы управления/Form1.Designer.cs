namespace __2_Windows_Forms.Элементы_управления
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FIO_Lbl = new System.Windows.Forms.Label();
            this.CrtStudBtn = new System.Windows.Forms.Button();
            this.FIO_tb = new System.Windows.Forms.TextBox();
            this.Age_tb = new System.Windows.Forms.TextBox();
            this.Age_lbl = new System.Windows.Forms.Label();
            this.Spec_lbl = new System.Windows.Forms.Label();
            this.Birthday_lbl = new System.Windows.Forms.Label();
            this.course_tb = new System.Windows.Forms.TextBox();
            this.Course_lbl = new System.Windows.Forms.Label();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.Group_tb = new System.Windows.Forms.TextBox();
            this.Group_lbl = new System.Windows.Forms.Label();
            this.AvgMark_tb = new System.Windows.Forms.TextBox();
            this.AvgMark_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Male_Rbtn = new System.Windows.Forms.RadioButton();
            this.Female_Rbtn = new System.Windows.Forms.RadioButton();
            this.Spec_CB = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Adress_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FIO_Lbl
            // 
            this.FIO_Lbl.AutoSize = true;
            this.FIO_Lbl.BackColor = System.Drawing.Color.White;
            this.FIO_Lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO_Lbl.Location = new System.Drawing.Point(17, 28);
            this.FIO_Lbl.Name = "FIO_Lbl";
            this.FIO_Lbl.Size = new System.Drawing.Size(25, 16);
            this.FIO_Lbl.TabIndex = 0;
            this.FIO_Lbl.Text = "FIO";
            this.FIO_Lbl.Click += new System.EventHandler(this.FIO_Lbl_Click);
            // 
            // CrtStudBtn
            // 
            this.CrtStudBtn.Location = new System.Drawing.Point(13, 389);
            this.CrtStudBtn.Name = "CrtStudBtn";
            this.CrtStudBtn.Size = new System.Drawing.Size(200, 49);
            this.CrtStudBtn.TabIndex = 1;
            this.CrtStudBtn.Text = "Create Student";
            this.CrtStudBtn.UseVisualStyleBackColor = true;
            this.CrtStudBtn.Click += new System.EventHandler(this.CrtStudBtn_Click);
            // 
            // FIO_tb
            // 
            this.FIO_tb.Location = new System.Drawing.Point(13, 44);
            this.FIO_tb.Name = "FIO_tb";
            this.FIO_tb.Size = new System.Drawing.Size(200, 20);
            this.FIO_tb.TabIndex = 2;
            this.FIO_tb.TextChanged += new System.EventHandler(this.FIO_tb_TextChanged);
            // 
            // Age_tb
            // 
            this.Age_tb.Location = new System.Drawing.Point(14, 82);
            this.Age_tb.Name = "Age_tb";
            this.Age_tb.Size = new System.Drawing.Size(199, 20);
            this.Age_tb.TabIndex = 4;
            this.Age_tb.TextChanged += new System.EventHandler(this.Age_tb_TextChanged);
            // 
            // Age_lbl
            // 
            this.Age_lbl.AutoSize = true;
            this.Age_lbl.BackColor = System.Drawing.Color.White;
            this.Age_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age_lbl.Location = new System.Drawing.Point(17, 66);
            this.Age_lbl.Name = "Age_lbl";
            this.Age_lbl.Size = new System.Drawing.Size(28, 16);
            this.Age_lbl.TabIndex = 3;
            this.Age_lbl.Text = "Age";
            this.Age_lbl.Click += new System.EventHandler(this.Age_lbl_Click);
            // 
            // Spec_lbl
            // 
            this.Spec_lbl.AutoSize = true;
            this.Spec_lbl.BackColor = System.Drawing.Color.White;
            this.Spec_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spec_lbl.Location = new System.Drawing.Point(17, 104);
            this.Spec_lbl.Name = "Spec_lbl";
            this.Spec_lbl.Size = new System.Drawing.Size(79, 16);
            this.Spec_lbl.TabIndex = 5;
            this.Spec_lbl.Text = "Specialization";
            this.Spec_lbl.Click += new System.EventHandler(this.Spec_lbl_Click);
            // 
            // Birthday_lbl
            // 
            this.Birthday_lbl.AllowDrop = true;
            this.Birthday_lbl.AutoSize = true;
            this.Birthday_lbl.BackColor = System.Drawing.Color.White;
            this.Birthday_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday_lbl.Location = new System.Drawing.Point(18, 144);
            this.Birthday_lbl.Name = "Birthday_lbl";
            this.Birthday_lbl.Size = new System.Drawing.Size(51, 16);
            this.Birthday_lbl.TabIndex = 7;
            this.Birthday_lbl.Text = "Birthday";
            this.Birthday_lbl.Click += new System.EventHandler(this.Birthday_lbl_Click);
            // 
            // course_tb
            // 
            this.course_tb.Location = new System.Drawing.Point(13, 198);
            this.course_tb.Name = "course_tb";
            this.course_tb.Size = new System.Drawing.Size(200, 20);
            this.course_tb.TabIndex = 10;
            this.course_tb.TextChanged += new System.EventHandler(this.course_tb_TextChanged);
            // 
            // Course_lbl
            // 
            this.Course_lbl.AllowDrop = true;
            this.Course_lbl.AutoSize = true;
            this.Course_lbl.BackColor = System.Drawing.Color.White;
            this.Course_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Course_lbl.Location = new System.Drawing.Point(18, 182);
            this.Course_lbl.Name = "Course_lbl";
            this.Course_lbl.Size = new System.Drawing.Size(43, 16);
            this.Course_lbl.TabIndex = 9;
            this.Course_lbl.Text = "Course";
            this.Course_lbl.Click += new System.EventHandler(this.Course_lbl_Click);
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Location = new System.Drawing.Point(13, 160);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(200, 20);
            this.BirthdayPicker.TabIndex = 11;
            this.BirthdayPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Group_tb
            // 
            this.Group_tb.Location = new System.Drawing.Point(13, 236);
            this.Group_tb.Name = "Group_tb";
            this.Group_tb.Size = new System.Drawing.Size(200, 20);
            this.Group_tb.TabIndex = 13;
            this.Group_tb.TextChanged += new System.EventHandler(this.Group_tb_TextChanged);
            // 
            // Group_lbl
            // 
            this.Group_lbl.AllowDrop = true;
            this.Group_lbl.AutoEllipsis = true;
            this.Group_lbl.AutoSize = true;
            this.Group_lbl.BackColor = System.Drawing.Color.White;
            this.Group_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group_lbl.Location = new System.Drawing.Point(17, 220);
            this.Group_lbl.Name = "Group_lbl";
            this.Group_lbl.Size = new System.Drawing.Size(40, 16);
            this.Group_lbl.TabIndex = 12;
            this.Group_lbl.Text = "Group";
            this.Group_lbl.Click += new System.EventHandler(this.Group_lbl_Click);
            // 
            // AvgMark_tb
            // 
            this.AvgMark_tb.Location = new System.Drawing.Point(13, 274);
            this.AvgMark_tb.Name = "AvgMark_tb";
            this.AvgMark_tb.Size = new System.Drawing.Size(200, 20);
            this.AvgMark_tb.TabIndex = 15;
            this.AvgMark_tb.TextChanged += new System.EventHandler(this.AvgMark_tb_TextChanged);
            // 
            // AvgMark_lbl
            // 
            this.AvgMark_lbl.AllowDrop = true;
            this.AvgMark_lbl.AutoEllipsis = true;
            this.AvgMark_lbl.AutoSize = true;
            this.AvgMark_lbl.BackColor = System.Drawing.Color.White;
            this.AvgMark_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgMark_lbl.Location = new System.Drawing.Point(17, 258);
            this.AvgMark_lbl.Name = "AvgMark_lbl";
            this.AvgMark_lbl.Size = new System.Drawing.Size(79, 16);
            this.AvgMark_lbl.TabIndex = 14;
            this.AvgMark_lbl.Text = "Average mark";
            this.AvgMark_lbl.Click += new System.EventHandler(this.AvgMark_lbl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Male_Rbtn);
            this.groupBox1.Controls.Add(this.Female_Rbtn);
            this.groupBox1.Location = new System.Drawing.Point(15, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Male_Rbtn
            // 
            this.Male_Rbtn.AutoSize = true;
            this.Male_Rbtn.Location = new System.Drawing.Point(6, 19);
            this.Male_Rbtn.Name = "Male_Rbtn";
            this.Male_Rbtn.Size = new System.Drawing.Size(48, 17);
            this.Male_Rbtn.TabIndex = 22;
            this.Male_Rbtn.Text = "Male";
            this.Male_Rbtn.UseVisualStyleBackColor = true;
            // 
            // Female_Rbtn
            // 
            this.Female_Rbtn.AutoSize = true;
            this.Female_Rbtn.Location = new System.Drawing.Point(60, 19);
            this.Female_Rbtn.Name = "Female_Rbtn";
            this.Female_Rbtn.Size = new System.Drawing.Size(59, 17);
            this.Female_Rbtn.TabIndex = 21;
            this.Female_Rbtn.Text = "Female";
            this.Female_Rbtn.UseVisualStyleBackColor = true;
            this.Female_Rbtn.CheckedChanged += new System.EventHandler(this.Female_Rbtn_CheckedChanged);
            // 
            // Spec_CB
            // 
            this.Spec_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Spec_CB.FormattingEnabled = true;
            this.Spec_CB.Items.AddRange(new object[] {
            "ПОИТ",
            "ДЭВИ",
            "ИСИТ"});
            this.Spec_CB.Location = new System.Drawing.Point(13, 120);
            this.Spec_CB.Name = "Spec_CB";
            this.Spec_CB.Size = new System.Drawing.Size(200, 21);
            this.Spec_CB.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Adress_btn
            // 
            this.Adress_btn.Location = new System.Drawing.Point(13, 360);
            this.Adress_btn.Name = "Adress_btn";
            this.Adress_btn.Size = new System.Drawing.Size(56, 23);
            this.Adress_btn.TabIndex = 25;
            this.Adress_btn.Text = "Adress";
            this.Adress_btn.UseVisualStyleBackColor = true;
            this.Adress_btn.Click += new System.EventHandler(this.Adress_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 363);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "FileName.json";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Adress_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Spec_CB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AvgMark_tb);
            this.Controls.Add(this.AvgMark_lbl);
            this.Controls.Add(this.Group_tb);
            this.Controls.Add(this.Group_lbl);
            this.Controls.Add(this.BirthdayPicker);
            this.Controls.Add(this.course_tb);
            this.Controls.Add(this.Course_lbl);
            this.Controls.Add(this.Birthday_lbl);
            this.Controls.Add(this.Spec_lbl);
            this.Controls.Add(this.Age_tb);
            this.Controls.Add(this.Age_lbl);
            this.Controls.Add(this.FIO_tb);
            this.Controls.Add(this.CrtStudBtn);
            this.Controls.Add(this.FIO_Lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "LR2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIO_Lbl;
        private System.Windows.Forms.Button CrtStudBtn;
        private System.Windows.Forms.TextBox FIO_tb;
        private System.Windows.Forms.TextBox Age_tb;
        private System.Windows.Forms.Label Age_lbl;
        private System.Windows.Forms.Label Spec_lbl;
        private System.Windows.Forms.Label Birthday_lbl;
        private System.Windows.Forms.TextBox course_tb;
        private System.Windows.Forms.Label Course_lbl;
        private System.Windows.Forms.DateTimePicker BirthdayPicker;
        private System.Windows.Forms.TextBox Group_tb;
        private System.Windows.Forms.Label Group_lbl;
        private System.Windows.Forms.TextBox AvgMark_tb;
        private System.Windows.Forms.Label AvgMark_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Male_Rbtn;
        private System.Windows.Forms.RadioButton Female_Rbtn;
        private System.Windows.Forms.ComboBox Spec_CB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Adress_btn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

