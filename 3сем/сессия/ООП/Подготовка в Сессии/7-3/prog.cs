using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    public class Button
    {
        public string caption;
        public int startpoint;
        public double w;
        public double h;
    }

    public class CheckButton : Button
    {
        public CheckButton() { }
        public CheckButton(string cap, double _w, double _h) 
        {
            caption = cap;
            w = _w;
            h = _h;
        }
        public enum stateList
        {
            Checked,
            Uncheched
        }
        public stateList State = stateList.Uncheched;

        public override string ToString()
        {
            return $"{w}+{h}+{caption}";
        }
        public override bool Equals(object? obj)
        {
            if ($"{w}+{h}+{caption}" == obj.ToString())
                return true;
            else
                return false;
        }
        public void Check()
        {
            if(State == stateList.Checked)
            {
                State = stateList.Uncheched;
                Console.WriteLine("Unchecked");
            }
            else
            {
                State = stateList.Checked;
                Console.WriteLine("Checked");
            }
        }
        public void Zoom()
        {
            w = w * 0.75;
            h = h * 0.75;
            Console.WriteLine("Zoom");
        }
    }

    public class User
    {
        //https://habr.com/ru/post/213809/
        //https://metanit.com/sharp/tutorial/3.14.php
        public delegate void MethodContainer();

        public event MethodContainer Resize;
        public event MethodContainer Click;

        public void res()
        {
            Resize();
        }
        public void click()
        {
            Click();
        }
    }

    public class Prog
    {
        public static void Main()
        {
            User user = new User();

            CheckButton checkButton = new CheckButton("asd", 5, 5);

            CheckButton checkButton2 = new CheckButton("aFAS", 7, 8);
            CheckButton checkButton3 = new CheckButton("asd", 5, 5);
            CheckButton checkButton4 = new CheckButton("asd", 3, 3);

            Button btn = new Button();
            btn.caption = "btn0";

            user.Resize += checkButton.Zoom;
            user.Click += checkButton.Check;

            user.click();
            user.res();

            checkButton.Check();

            LinkedList<Button> Buttons = new LinkedList<Button>();
            Buttons.AddLast(checkButton);
            Buttons.AddLast(btn);
            Buttons.AddLast(checkButton2);
            Buttons.AddLast(checkButton3);
            Buttons.AddLast(checkButton4);

            var buttons = from p in Buttons
                          where p.GetType() == typeof(Button)
                          select p;
            foreach (var elem in buttons)
                Console.WriteLine(elem.caption);
        }
    }
}
