using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace _1Создание_приложений_на_основе_Windows_Form
{
    interface ICalculator
    {
        private void Result_Click(object sender, EventArgs e) { }
    }
    public partial class Calculator : Form, ICalculator
    {
        private decimal Height;
        private int Weight;
        private int Age;
        private string Gender;
        private int Goal;
        private int Day;
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e) { }

        private void UserHeight_Click(object sender, EventArgs e) { }

        private void UserWeight_Click(object sender, EventArgs e) { }
        //UGender
        private void UGender_TextChanged(object sender, EventArgs e)
        {
            Gender = UGender.ToString();
        }
        //UAge
        private void UAge_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                Age = Convert.ToInt32(UAge.Text);
            }
            catch
            {
                UAge.Text = "Incorrect";
            }
        }
        //UHeight
        private void UHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Height = Convert.ToDecimal(UHeight.Text);
            }
            catch
            {
                UHeight.Text = "Incorrect";
            }
        }
        //UGoal
        private void UGoal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Goal = Convert.ToInt32(UGoal.Text);
            }
            catch
            {
                UGoal.Text = "Incorrect";
            }

        }
        //UWeight
        private void UWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Weight = Convert.ToInt32(UWeight.Text);
            }
            catch
            {
                UWeight.Text = "Incorrect";
            }
        }
        //GetResult
        private void GetResult_Click(object sender, EventArgs e)
        {
            Result.Text = (Weight - Goal).ToString();
            Result.Text = "Для получения результатов отправте деньги на этот ethereum кошелёк\nАдрес: 0x04086ebFf5D3896e9F9f07E87a7858C2f44cFd64";
            Result.Visible = true;
            GetResult.Visible = false;
            UWeight.Visible = false;
            UGoal.Visible = false;
            UHeight.Visible = false;
            RealResult.Visible = false;
            UserDays.Visible = false;
            UDays.Visible = false;
        }
        private void Result_Click(object sender, EventArgs e)
        {
            Result.Visible = false;

            GetResult.Visible = true;
            UWeight.Visible = true;
            UGoal.Visible = true;
            UHeight.Visible = true;
            RealResult.Visible = true;
            UserDays.Visible = true;
            UDays.Visible = true;
            try
            {
                RealResult.Text = "Требуется изменение на: " + (Weight - Goal).ToString() + "\nРазмер суточных каллорий: \n" + ((Weight - Goal) / Day).ToString();
            }
            catch
            {

            }
        }

        private void RealResult_Click(object sender, EventArgs e) { }
        private void UDays_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Day = Convert.ToInt32(UDays.Text);
            }
            catch
            {
                UDays.Text = "Incorrect";
            }
        }

        private void UserDays_Click(object sender, EventArgs e)
        {

        }
    }
}