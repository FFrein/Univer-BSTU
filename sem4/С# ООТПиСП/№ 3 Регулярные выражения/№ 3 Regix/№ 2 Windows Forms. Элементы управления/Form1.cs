using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace __2_Windows_Forms.Элементы_управления
{
    public partial class Form1 : Form
    {
        //https://professorweb.ru/my/ADO_NET/base/level1/1_7.php

        //https://www.youtube.com/watch?v=f-ymKWyoBc8&ab_channel=%D0%90%D0%B9%D1%82%D0%B8%D1%88%D0%BD%D1%8B%D0%B9%D0%94%D0%BE%D0%BC%D0%BE%D1%81%D0%B5%D0%B4
        private string BD_KEY = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\MyFile\\Универ\\4sem\\С# ООТПиСП\\№ 3 Регулярные выражения\\№ 3 Regix\\№ 2 Windows Forms. Элементы управления\\Database1.mdf\";Integrated Security=True";
        private SqlConnection connect = null;

        private string FIO = null;
        private int age;
        private string special = null;
        private DateTime? birthday = null;
        private int course;
        private int gropu;
        private int avg_mark;
        private string gender = null;
        private Adress adress = null;
        private string work = "";
        private Student student = null;
        Timer timer;

        List<string[]> data;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer() { Interval = 1000 };
            timer.Tick += toolStripStatusLabel1_Click;
            timer.Start();
        }

        private bool ValidateUser(Student student)
        {
            Type type = typeof(Student);
            // получаем все атрибуты класса Person
            object[] attributes = type.GetCustomAttributes(false);

            // проходим по всем атрибутам
            foreach (Attribute attr in attributes)
            {
                // если атрибут представляет тип AgeValidationAttribute
                if (attr is AgeValidationAttribute ageAttribute)
                    // возвращаем результат проверки по возрасту
                    return student.age >= ageAttribute.Age;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private async void CrtStudBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(textBox1.Text, FileMode.OpenOrCreate))
                {
                    adress = await JsonSerializer.DeserializeAsync<Adress>(fs);
                }

                student = new Student(FIO, age, special, (DateTime.Parse(BirthdayPicker.Text)).ToString(), gropu, course, avg_mark, gender, adress, null);

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

        private void FIO_Lbl_Click(object sender, EventArgs e) { }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }

        private void Gender_lbl_Click(object sender, EventArgs e) { }

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

        private void AvgMark_lbl_Click(object sender, EventArgs e) { }

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

        private void Group_lbl_Click(object sender, EventArgs e) { }

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

        private void Course_lbl_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Birthday_lbl.Text = BirthdayPicker.Text;
        }

        private void Birthday_lbl_Click(object sender, EventArgs e) { }

        private void Spec_tb_TextChanged(object sender, EventArgs e) { }
        private void Spec_lbl_Click(object sender, EventArgs e) { }

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

        private void Age_lbl_Click(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void Female_Rbtn_CheckedChanged(object sender, EventArgs e) { }

        private void Adress_btn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); //где Form2 - название вашей формы
            frm2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void FIO_tb_TextChanged_1(object sender, EventArgs e)
        {
            FIO = FIO_tb.Text.ToString();
        }

        private void Age_tb_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                age = Convert.ToInt32(Age_tb.Text);
            }
            catch
            {
                Age_tb.Text = "0";
            }
        }

        private void BirthdayPicker_ValueChanged(object sender, EventArgs e) {

        }

        private void course_tb_TextChanged_1(object sender, EventArgs e)
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

        private void Group_tb_TextChanged_1(object sender, EventArgs e)
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

        private void AvgMark_tb_TextChanged_1(object sender, EventArgs e)
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

        private void Male_Rbtn_CheckedChanged(object sender, EventArgs e) {
            gender = "m";
        }
        private void Female_Rbtn_CheckedChanged_1(object sender, EventArgs e) {
            gender = "f";
        }
        private void groupBox1_Enter_1(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void Adress_btn_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); //где Form2 - название вашей формы
            frm2.Show();
        }

        private async void CrtStudBtn_Click_1(object sender, EventArgs e)
        {
            LastTask.Text = "Последнее действие: Создать";
            try
            {
                try
                {
                    using (FileStream fs = new FileStream(textBox1.Text, FileMode.OpenOrCreate))
                    {
                        adress = await JsonSerializer.DeserializeAsync<Adress>(fs);
                    }

                }
                catch { }
                
                student = new Student(FIO, age, special, (DateTime.Parse(BirthdayPicker.Text)).ToString(), gropu, course, avg_mark, gender, adress, null);

                var results = new List<ValidationResult>();
                var context = new ValidationContext(student);
                if (!Validator.TryValidateObject(student, context, results, true))
                {
                    foreach (var error in results)
                    {
                        MessageBox.Show(error.ErrorMessage);

                    }
                    return;
                }

                bool CheckValidCustom = ValidateUser(student);
                if (!CheckValidCustom)
                {
                    MessageBox.Show("Студент не подходит по возрасту");
                    return;
                }


                using (FileStream fs = new FileStream("Result.json", FileMode.OpenOrCreate))
                {
                    await JsonSerializer.SerializeAsync<Student>(fs, student);
                }
            }
            catch
            {

            }

            try
            {
                connect = new SqlConnection(BD_KEY);
                connect.Open();

                // Оператор SQL
                string sql = string.Format(
                       "Insert Into STUDENT" +
                       "(FIO, COURSE, [GROUP], AGE, SPECIAL, WORK, BIRTHDAY, GENDER, AVG_MARK)" +
                       "Values(@FIO, @COURSE, @GROUP, @AGE, @SPECIAL, @WORK, @BIRTHDAY, @GENDER, @AVG_MARK)"
                       );

                using (SqlCommand cmd = new SqlCommand(sql, this.connect))
                {
                    // Добавить параметры
                    cmd.Parameters.AddWithValue("@FIO", FIO);
                    cmd.Parameters.AddWithValue("@COURSE", course);
                    cmd.Parameters.AddWithValue("@GROUP", gropu);
                    cmd.Parameters.AddWithValue("@AGE", age);
                    cmd.Parameters.AddWithValue("@SPECIAL", special);
                    cmd.Parameters.AddWithValue("@BIRTHDAY", DateTime.Parse(BirthdayPicker.Text));
                    cmd.Parameters.AddWithValue("@GENDER", gender);
                    cmd.Parameters.AddWithValue("@WORK", work);
                    cmd.Parameters.AddWithValue("@AVG_MARK", avg_mark);


                    cmd.ExecuteNonQuery(); 
                }
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Spec_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            special = Spec_CB.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //FIND
        private void button1_Click(object sender, EventArgs e)
        {
            LastTask.Text = "Последнее действие: Поиск";
            ObjtcntAmout_Click(sender, e);
            try
            {
                connect = new SqlConnection(BD_KEY);
                connect.Open();

                string query = "SELECT * FROM STUDENT ";

                if (SpecFind.Text.Length != 0)
                    query += "WHERE SPECIAL = '" + SpecFind.Text + "' ";
                else
                    query += "WHERE SPECIAL = SPECIAL ";

                if (CourseFind.Text.Length != 0)
                    query += "AND COURSE = '" + CourseFind.Text + "' ";
                else
                    query += "AND COURSE = COURSE ";

                if (AVG_Find.Text.Length != 0)
                    query += "AND AVG_MARK >= '" + AVG_Find.Text + "' ";
                else
                    query += "AND AVG_MARK = AVG_MARK ";

                data = new List<string[]>();


                SqlCommand command = new SqlCommand(query, connect);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data.Add(new string[10]);
                    data[data.Count - 1][0] = reader[0].ToString();//ID
                    data[data.Count - 1][1] = reader[1].ToString();//FIO
                    data[data.Count - 1][2] = reader[2].ToString();//COURSE
                    data[data.Count - 1][3] = reader[3].ToString();//GROUP
                    data[data.Count - 1][4] = reader[4].ToString();//AGE
                    data[data.Count - 1][5] = reader[5].ToString();//SPECIAL
                    data[data.Count - 1][6] = reader[6].ToString();//WORK
                    data[data.Count - 1][7] = reader[7].ToString();//BIRTHDAY
                    data[data.Count - 1][8] = reader[8].ToString();//GENDER
                    data[data.Count - 1][9] = reader[9].ToString();//AVG_MARK
                }

                reader.Close();
                connect.Close();

                var SelectedStudents = from stud in data
                                       select stud;

                //age fio spec
                if (RB_AGE.Checked)
                {
                    SelectedStudents = from stud in data
                                       orderby stud[4]
                                       select stud;
                }
                if (RB_FIO.Checked)
                {
                    SelectedStudents = from stud in data
                                       orderby stud[1]
                                       select stud;
                }
                if (RB_SPEC.Checked)
                {
                    SelectedStudents = from stud in data
                                       orderby stud[5]
                                       select stud;
                }


                dataGridView1.Rows.Clear();

                //REGEX
                Regex regex = new Regex($@"{RegixFio.Text}(\w*)");
                

                foreach (string[] str in SelectedStudents)
                {
                    if (RegixFio.Text.Length != 0)
                    {
                        if (regex.Matches(str[1]).Count > 0)
                            dataGridView1.Rows.Add(str);
                    }
                    else
                        dataGridView1.Rows.Add(str);
                }

            }
            catch
            {

            }


        }

        private void RegixFio_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Save_btn_Click(object sender, EventArgs e)
        {
            LastTask.Text = "Последнее действие: Сохранить";

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string[]>));
            TextWriter writer = new StreamWriter("SerrializeXML.txt");
            xmlSerializer.Serialize(writer, data);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Текущая дата и время: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            
        }

        private void ObjtcntAmout_Click(object sender, EventArgs e)
        {
            LastTask.Text = "Последнее действие: Кол объектов";
            try
            {
                connect = new SqlConnection(BD_KEY);
                connect.Open();

                string query = "SELECT COUNT(*) FROM STUDENT";

                data = new List<string[]>();

                SqlCommand command = new SqlCommand(query, connect);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data.Add(new string[1]);
                    data[data.Count - 1][0] = reader[0].ToString();

                }

                reader.Close();
                connect.Close();

                ObjtcntAmout.Text = "Всего объектов: " + data[0][0];
            }
            catch { }
        }

        delegate void Message();

        private void toolStripFind_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            LastTask.Text = "Последнее действие: Очистить";
            dataGridView1.Rows.Clear();
        }

        private void LastTask_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
