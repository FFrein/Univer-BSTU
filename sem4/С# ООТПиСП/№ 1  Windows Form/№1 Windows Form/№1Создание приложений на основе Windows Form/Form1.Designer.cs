namespace _1Создание_приложений_на_основе_Windows_Form
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.UGender = new System.Windows.Forms.TextBox();
            this.UserGender = new System.Windows.Forms.Label();
            this.UserWeight = new System.Windows.Forms.Label();
            this.UserHeight = new System.Windows.Forms.Label();
            this.UserAge = new System.Windows.Forms.Label();
            this.TheGoal = new System.Windows.Forms.Label();
            this.UGoal = new System.Windows.Forms.TextBox();
            this.UWeight = new System.Windows.Forms.TextBox();
            this.UHeight = new System.Windows.Forms.TextBox();
            this.UAge = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.GetResult = new System.Windows.Forms.Button();
            this.RealResult = new System.Windows.Forms.Label();
            this.UserDays = new System.Windows.Forms.Label();
            this.UDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UGender
            // 
            this.UGender.BackColor = System.Drawing.Color.Salmon;
            this.UGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UGender.Location = new System.Drawing.Point(35, 48);
            this.UGender.Name = "UGender";
            this.UGender.Size = new System.Drawing.Size(200, 22);
            this.UGender.TabIndex = 0;
            this.UGender.TextChanged += new System.EventHandler(this.UGender_TextChanged);
            // 
            // UserGender
            // 
            this.UserGender.AutoSize = true;
            this.UserGender.BackColor = System.Drawing.Color.Transparent;
            this.UserGender.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserGender.ForeColor = System.Drawing.Color.Lime;
            this.UserGender.Location = new System.Drawing.Point(35, 22);
            this.UserGender.Name = "UserGender";
            this.UserGender.Size = new System.Drawing.Size(75, 26);
            this.UserGender.TabIndex = 4;
            this.UserGender.Text = "Gender";
            this.UserGender.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserWeight
            // 
            this.UserWeight.AutoSize = true;
            this.UserWeight.BackColor = System.Drawing.Color.Transparent;
            this.UserWeight.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserWeight.ForeColor = System.Drawing.Color.Lime;
            this.UserWeight.Location = new System.Drawing.Point(36, 85);
            this.UserWeight.Name = "UserWeight";
            this.UserWeight.Size = new System.Drawing.Size(73, 26);
            this.UserWeight.TabIndex = 5;
            this.UserWeight.Text = "Weight";
            this.UserWeight.Click += new System.EventHandler(this.UserWeight_Click);
            // 
            // UserHeight
            // 
            this.UserHeight.AutoSize = true;
            this.UserHeight.BackColor = System.Drawing.Color.Transparent;
            this.UserHeight.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserHeight.ForeColor = System.Drawing.Color.Lime;
            this.UserHeight.Location = new System.Drawing.Point(304, 85);
            this.UserHeight.Name = "UserHeight";
            this.UserHeight.Size = new System.Drawing.Size(69, 26);
            this.UserHeight.TabIndex = 6;
            this.UserHeight.Text = "Height";
            this.UserHeight.Click += new System.EventHandler(this.UserHeight_Click);
            // 
            // UserAge
            // 
            this.UserAge.AutoSize = true;
            this.UserAge.BackColor = System.Drawing.Color.Transparent;
            this.UserAge.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserAge.ForeColor = System.Drawing.Color.Lime;
            this.UserAge.Location = new System.Drawing.Point(304, 22);
            this.UserAge.Name = "UserAge";
            this.UserAge.Size = new System.Drawing.Size(45, 26);
            this.UserAge.TabIndex = 7;
            this.UserAge.Text = "Age";
            // 
            // TheGoal
            // 
            this.TheGoal.AutoSize = true;
            this.TheGoal.BackColor = System.Drawing.Color.Transparent;
            this.TheGoal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TheGoal.ForeColor = System.Drawing.Color.Lime;
            this.TheGoal.Location = new System.Drawing.Point(36, 148);
            this.TheGoal.Name = "TheGoal";
            this.TheGoal.Size = new System.Drawing.Size(89, 26);
            this.TheGoal.TabIndex = 9;
            this.TheGoal.Text = "The Goal";
            this.TheGoal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UGoal
            // 
            this.UGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UGoal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UGoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UGoal.Location = new System.Drawing.Point(36, 174);
            this.UGoal.Name = "UGoal";
            this.UGoal.Size = new System.Drawing.Size(200, 22);
            this.UGoal.TabIndex = 10;
            this.UGoal.TextChanged += new System.EventHandler(this.UGoal_TextChanged);
            // 
            // UWeight
            // 
            this.UWeight.BackColor = System.Drawing.Color.Salmon;
            this.UWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UWeight.Location = new System.Drawing.Point(36, 111);
            this.UWeight.Name = "UWeight";
            this.UWeight.Size = new System.Drawing.Size(200, 22);
            this.UWeight.TabIndex = 11;
            this.UWeight.TextChanged += new System.EventHandler(this.UWeight_TextChanged);
            // 
            // UHeight
            // 
            this.UHeight.BackColor = System.Drawing.Color.Salmon;
            this.UHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UHeight.Location = new System.Drawing.Point(304, 111);
            this.UHeight.Name = "UHeight";
            this.UHeight.Size = new System.Drawing.Size(200, 22);
            this.UHeight.TabIndex = 12;
            this.UHeight.TextChanged += new System.EventHandler(this.UHeight_TextChanged);
            // 
            // UAge
            // 
            this.UAge.BackColor = System.Drawing.Color.Salmon;
            this.UAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UAge.Location = new System.Drawing.Point(304, 48);
            this.UAge.Name = "UAge";
            this.UAge.Size = new System.Drawing.Size(200, 22);
            this.UAge.TabIndex = 13;
            this.UAge.TextChanged += new System.EventHandler(this.UAge_TextChanged);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(35, 22);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(469, 225);
            this.Result.TabIndex = 200;
            this.Result.Text = "Result";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Result.Visible = false;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // GetResult
            // 
            this.GetResult.BackColor = System.Drawing.Color.Transparent;
            this.GetResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GetResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetResult.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetResult.Location = new System.Drawing.Point(35, 212);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(155, 35);
            this.GetResult.TabIndex = 15;
            this.GetResult.Text = "GetResult";
            this.GetResult.UseVisualStyleBackColor = false;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // RealResult
            // 
            this.RealResult.BackColor = System.Drawing.Color.Tomato;
            this.RealResult.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RealResult.Location = new System.Drawing.Point(222, 560);
            this.RealResult.Name = "RealResult";
            this.RealResult.Size = new System.Drawing.Size(310, 82);
            this.RealResult.TabIndex = 16;
            this.RealResult.Visible = false;
            this.RealResult.Click += new System.EventHandler(this.RealResult_Click);
            // 
            // UserDays
            // 
            this.UserDays.AutoSize = true;
            this.UserDays.BackColor = System.Drawing.Color.Transparent;
            this.UserDays.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserDays.ForeColor = System.Drawing.Color.Lime;
            this.UserDays.Location = new System.Drawing.Point(305, 148);
            this.UserDays.Name = "UserDays";
            this.UserDays.Size = new System.Drawing.Size(55, 26);
            this.UserDays.TabIndex = 17;
            this.UserDays.Text = "Days";
            this.UserDays.Click += new System.EventHandler(this.UserDays_Click);
            // 
            // UDays
            // 
            this.UDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UDays.Location = new System.Drawing.Point(305, 174);
            this.UDays.Name = "UDays";
            this.UDays.Size = new System.Drawing.Size(200, 22);
            this.UDays.TabIndex = 18;
            this.UDays.TextChanged += new System.EventHandler(this.UDays_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 651);
            this.Controls.Add(this.UDays);
            this.Controls.Add(this.UserDays);
            this.Controls.Add(this.RealResult);
            this.Controls.Add(this.GetResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.UAge);
            this.Controls.Add(this.UHeight);
            this.Controls.Add(this.UWeight);
            this.Controls.Add(this.UGoal);
            this.Controls.Add(this.TheGoal);
            this.Controls.Add(this.UserAge);
            this.Controls.Add(this.UserHeight);
            this.Controls.Add(this.UserWeight);
            this.Controls.Add(this.UserGender);
            this.Controls.Add(this.UGender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Calculator";
            this.Text = "Калькулятор радикального сжигания веса путём ампутации (вивисекции)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UGender;
        private Label UserGender;
        private Label UserWeight;
        private Label UserHeight;
        private Label UserAge;
        private Label TheGoal;
        private TextBox UGoal;
        private TextBox UWeight;
        private TextBox UHeight;
        private TextBox UAge;
        private Label Result;
        private Button GetResult;
        private Label RealResult;
        private Label UserDays;
        private TextBox UDays;
    }
}