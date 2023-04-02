using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace __2_Windows_Forms.Элементы_управления
{
    public partial class Form2 : Form
    {
        Adress adr = new Adress();
        [MinLength(2, ErrorMessage = "Incorrect index")]
        int buff;
        public Form2()
        {
            InitializeComponent();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //CreateAdress
        private async void button1_Click(object sender, EventArgs e)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(adr);
            if (!Validator.TryValidateObject(adr, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);

                }
                return;
            }
            using (FileStream fs = new FileStream(textBox7.Text + ".json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Adress>(fs, adr);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            adr.City= textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                buff = Convert.ToInt32(textBox2.Text);
                adr.index = buff;
            }
            catch(Exception ex)
            {
                textBox2.Text = ex.Message.ToString();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            adr.street= textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adr.house_num = Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                textBox4.Text = "Incorrect value";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adr.flat_num = Convert.ToInt32(textBox5.Text);
            }
            catch
            {
                textBox5.Text = "Incorrect value";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
