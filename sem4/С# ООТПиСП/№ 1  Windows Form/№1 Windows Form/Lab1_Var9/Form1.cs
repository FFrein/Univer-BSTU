using System.Diagnostics.Metrics;

namespace Lab1_Var9
{
    interface TextCalculator
    {
        private void EditStrBtn_Click(object sender, EventArgs e) { }
        private void DeleteSubStr_Click(object sender, EventArgs e) { }
        private void FIndSumblIndxButn_Click(object sender, EventArgs e) { }
        private void StrLenBtn_Click(object sender, EventArgs e) { }
    }
    public partial class Form1 : Form, TextCalculator
    {
        private string MainStr;
        private string FindStr;
        private string EditStr;
        private int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Result
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        //MainsStr
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MainStr = textBox1.Text;
        }
        //FindString
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FindStr = textBox2.Text;
        }
        //SubStr
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            EditStr = textBox3.Text;
        }
        //IndexBox
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                index = Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                textBox4.Text = "Incorrect Value";
            }
        }
        private void EditStrBtn_Click(object sender, EventArgs e)
        {
            label1.Text = MainStr = MainStr.Replace(FindStr, EditStr);
        }

        private void DeleteSubStr_Click(object sender, EventArgs e)
        {
            label1.Text = MainStr = MainStr.Replace(FindStr, "");
        }
        private void FIndSumblIndxButn_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Convert.ToString(MainStr[index]);
            }
            catch
            {
                textBox4.Text = "Incorrect Value";
            }
        }

        private void StrLenBtn_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(MainStr.Length);
        }

        private void AmountLetOne_Click(object sender, EventArgs e)
        {
            char[] letters = { 'a', 'i', 'e', 'o', 'y', 'u', 'A', 'I', 'E', 'O', 'Y', 'U' };
            int counter = 0;
            for (int j = 0; j < MainStr.Length; j++)
                for (int i = 0; i < letters.Length; i++)
                    if (letters[i] == MainStr[j])
                        counter++;
            label1.Text = Convert.ToString(counter);
        }

        private void AmountLetTwo_Click(object sender, EventArgs e)
        {
            char[] letters = {'q','w','r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v',
            'b','n','m','Q','W','R','T','P','S','D','F','G','H','J','K','L','Z','X','C','V','B','N','M'};
            int counter = 0;
            for (int j = 0; j < MainStr.Length; j++)
                for (int i = 0; i < letters.Length; i++)
                    if (letters[i] == MainStr[j])
                        counter++;

            label1.Text = Convert.ToString(counter);
        }

        private void AmountDotBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int j = 0; j < MainStr.Length; j++)
                    if ('.' == MainStr[j])
                        counter++;

            label1.Text = Convert.ToString(counter);
        }

        private void AmountWordsBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int j = 0; j < MainStr.Length; j++)
                if (' ' == MainStr[j])
                    counter++;

            label1.Text = Convert.ToString(counter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}