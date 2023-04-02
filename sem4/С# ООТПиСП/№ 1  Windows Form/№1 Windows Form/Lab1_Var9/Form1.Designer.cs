namespace Lab1_Var9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.InputStrLabel = new System.Windows.Forms.Label();
            this.InputStr2Label = new System.Windows.Forms.Label();
            this.EditStrBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SubStr2Label = new System.Windows.Forms.Label();
            this.DeleteSubStr = new System.Windows.Forms.Button();
            this.FIndSumblIndxButn = new System.Windows.Forms.Button();
            this.StrLenBtn = new System.Windows.Forms.Button();
            this.AmountLetOne = new System.Windows.Forms.Button();
            this.AmountLetTwo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountDotBtn = new System.Windows.Forms.Button();
            this.AmountWordsBtn = new System.Windows.Forms.Button();
            this.IndexLable = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(440, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // InputStrLabel
            // 
            this.InputStrLabel.AutoSize = true;
            this.InputStrLabel.Location = new System.Drawing.Point(12, 19);
            this.InputStrLabel.Name = "InputStrLabel";
            this.InputStrLabel.Size = new System.Drawing.Size(68, 15);
            this.InputStrLabel.TabIndex = 2;
            this.InputStrLabel.Text = "Main String";
            this.InputStrLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputStr2Label
            // 
            this.InputStr2Label.AutoSize = true;
            this.InputStr2Label.Location = new System.Drawing.Point(12, 67);
            this.InputStr2Label.Name = "InputStr2Label";
            this.InputStr2Label.Size = new System.Drawing.Size(64, 15);
            this.InputStr2Label.TabIndex = 3;
            this.InputStr2Label.Text = "Find String";
            // 
            // EditStrBtn
            // 
            this.EditStrBtn.Location = new System.Drawing.Point(12, 241);
            this.EditStrBtn.Name = "EditStrBtn";
            this.EditStrBtn.Size = new System.Drawing.Size(200, 50);
            this.EditStrBtn.TabIndex = 4;
            this.EditStrBtn.Text = "Замена строки";
            this.EditStrBtn.UseVisualStyleBackColor = true;
            this.EditStrBtn.Click += new System.EventHandler(this.EditStrBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(440, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SubStr2Label
            // 
            this.SubStr2Label.AutoSize = true;
            this.SubStr2Label.Location = new System.Drawing.Point(12, 119);
            this.SubStr2Label.Name = "SubStr2Label";
            this.SubStr2Label.Size = new System.Drawing.Size(61, 15);
            this.SubStr2Label.TabIndex = 8;
            this.SubStr2Label.Text = "Sub String";
            // 
            // DeleteSubStr
            // 
            this.DeleteSubStr.Location = new System.Drawing.Point(252, 241);
            this.DeleteSubStr.Name = "DeleteSubStr";
            this.DeleteSubStr.Size = new System.Drawing.Size(200, 50);
            this.DeleteSubStr.TabIndex = 9;
            this.DeleteSubStr.Text = "Удаление подстроки";
            this.DeleteSubStr.UseVisualStyleBackColor = true;
            this.DeleteSubStr.Click += new System.EventHandler(this.DeleteSubStr_Click);
            // 
            // FIndSumblIndxButn
            // 
            this.FIndSumblIndxButn.Location = new System.Drawing.Point(12, 308);
            this.FIndSumblIndxButn.Name = "FIndSumblIndxButn";
            this.FIndSumblIndxButn.Size = new System.Drawing.Size(200, 50);
            this.FIndSumblIndxButn.TabIndex = 10;
            this.FIndSumblIndxButn.Text = "Поиск символа по индексу";
            this.FIndSumblIndxButn.UseVisualStyleBackColor = true;
            this.FIndSumblIndxButn.Click += new System.EventHandler(this.FIndSumblIndxButn_Click);
            // 
            // StrLenBtn
            // 
            this.StrLenBtn.Location = new System.Drawing.Point(252, 308);
            this.StrLenBtn.Name = "StrLenBtn";
            this.StrLenBtn.Size = new System.Drawing.Size(200, 50);
            this.StrLenBtn.TabIndex = 11;
            this.StrLenBtn.Text = "Длинна строки";
            this.StrLenBtn.UseVisualStyleBackColor = true;
            this.StrLenBtn.Click += new System.EventHandler(this.StrLenBtn_Click);
            // 
            // AmountLetOne
            // 
            this.AmountLetOne.Location = new System.Drawing.Point(12, 375);
            this.AmountLetOne.Name = "AmountLetOne";
            this.AmountLetOne.Size = new System.Drawing.Size(200, 50);
            this.AmountLetOne.TabIndex = 12;
            this.AmountLetOne.Text = "Количество гласных";
            this.AmountLetOne.UseVisualStyleBackColor = true;
            this.AmountLetOne.Click += new System.EventHandler(this.AmountLetOne_Click);
            // 
            // AmountLetTwo
            // 
            this.AmountLetTwo.Location = new System.Drawing.Point(252, 375);
            this.AmountLetTwo.Name = "AmountLetTwo";
            this.AmountLetTwo.Size = new System.Drawing.Size(200, 50);
            this.AmountLetTwo.TabIndex = 13;
            this.AmountLetTwo.Text = "Количество согласных";
            this.AmountLetTwo.UseVisualStyleBackColor = true;
            this.AmountLetTwo.Click += new System.EventHandler(this.AmountLetTwo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sub String";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AmountDotBtn
            // 
            this.AmountDotBtn.Location = new System.Drawing.Point(12, 441);
            this.AmountDotBtn.Name = "AmountDotBtn";
            this.AmountDotBtn.Size = new System.Drawing.Size(200, 50);
            this.AmountDotBtn.TabIndex = 15;
            this.AmountDotBtn.Text = "Количество прдложений";
            this.AmountDotBtn.UseVisualStyleBackColor = true;
            this.AmountDotBtn.Click += new System.EventHandler(this.AmountDotBtn_Click);
            // 
            // AmountWordsBtn
            // 
            this.AmountWordsBtn.Location = new System.Drawing.Point(252, 441);
            this.AmountWordsBtn.Name = "AmountWordsBtn";
            this.AmountWordsBtn.Size = new System.Drawing.Size(200, 50);
            this.AmountWordsBtn.TabIndex = 16;
            this.AmountWordsBtn.Text = "Количество слов";
            this.AmountWordsBtn.UseVisualStyleBackColor = true;
            this.AmountWordsBtn.Click += new System.EventHandler(this.AmountWordsBtn_Click);
            // 
            // IndexLable
            // 
            this.IndexLable.AutoSize = true;
            this.IndexLable.Location = new System.Drawing.Point(12, 172);
            this.IndexLable.Name = "IndexLable";
            this.IndexLable.Size = new System.Drawing.Size(50, 15);
            this.IndexLable.TabIndex = 17;
            this.IndexLable.Text = "IndxBox";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(440, 23);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.IndexLable);
            this.Controls.Add(this.AmountWordsBtn);
            this.Controls.Add(this.AmountDotBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountLetTwo);
            this.Controls.Add(this.AmountLetOne);
            this.Controls.Add(this.StrLenBtn);
            this.Controls.Add(this.FIndSumblIndxButn);
            this.Controls.Add(this.DeleteSubStr);
            this.Controls.Add(this.SubStr2Label);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.EditStrBtn);
            this.Controls.Add(this.InputStr2Label);
            this.Controls.Add(this.InputStrLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Текстовый калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label InputStrLabel;
        private Label InputStr2Label;
        private Button EditStrBtn;
        private TextBox textBox3;
        private Label SubStr2Label;
        private Button DeleteSubStr;
        private Button FIndSumblIndxButn;
        private Button StrLenBtn;
        private Button AmountLetOne;
        private Button AmountLetTwo;
        private Label label1;
        private Button AmountDotBtn;
        private Button AmountWordsBtn;
        private Label IndexLable;
        private TextBox textBox4;
    }
}