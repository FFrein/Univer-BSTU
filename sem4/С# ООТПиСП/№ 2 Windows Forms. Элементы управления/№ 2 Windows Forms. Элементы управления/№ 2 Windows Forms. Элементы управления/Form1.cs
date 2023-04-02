using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace __2_Windows_Forms.Элементы_управления
{
    public partial class Form1 : Form
    {
        private string FIO;
        private int age;
        private string special;
        private string birthday;
        private int course;
        private int gropu;
        private int avg_mark;
        private string gender;
        private Adress adress;
        private Work work;
        private Student student;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void CrtStudBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(textBox1.Text, FileMode.OpenOrCreate))
                {
                    adress = await JsonSerializer.DeserializeAsync<Adress>(fs);
                }

                student = new Student(FIO, age, special, birthday, gropu, course, avg_mark, gender, adress, work);

                using (FileStream fs = new FileStream("Result.json", FileMode.OpenOrCreate))
                {
                    await JsonSerializer.SerializeAsync<Student>(fs, student);
                }
            }
            catch 
            {
            
            }
        }

        private void FIO_tb_TextChanged(object sender, EventArgs e)
        {
            FIO = FIO_tb.ToString();
        }

        private void FIO_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gender_lbl_Click(object sender, EventArgs e)
        {

        }

        private void AvgMark_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                avg_mark = Convert.ToInt32(AvgMark_tb.Text);
            }
            catch
            {
                AvgMark_tb.Text = "Incorrect value";
            }
        }

        private void AvgMark_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Group_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gropu = Convert.ToInt32(Group_tb.Text);
            }
            catch 
            {
                Group_tb.Text = "Incorrect value";
            }
        }

        private void Group_lbl_Click(object sender, EventArgs e)
        {

        }

        private void course_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                course = Convert.ToInt32(course_tb.Text);
            }
            catch
            {
                course_tb.Text = "Incorrect value";
            }
        }

        private void Course_lbl_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Birthday_lbl.Text = BirthdayPicker.Text;
        }

        private void Birthday_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Spec_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Spec_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Age_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                age = Convert.ToInt32(Age_tb.Text);
            }
            catch 
            {
                Age_tb.Text = "Incorrect value";
            }
        }

        private void Age_lbl_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Female_Rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Adress_btn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); //где Form2 - название вашей формы
            frm2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
