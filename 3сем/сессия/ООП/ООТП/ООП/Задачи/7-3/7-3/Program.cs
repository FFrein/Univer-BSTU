using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    public class Button: CheckButton
    {
        public string caption;
        (int x, int y) startpoint;
        public int X
        {
            get
            {
                return startpoint.x;
            }
            set
            {
                value = startpoint.x;
            }
        }

        public int Y
        {
            get
            {
                return startpoint.y;
            }
            set
            {
                value = startpoint.y;
            }
        }
        public double w;
        public double h;

        public Button(string caption, int x, int y, double w, double h, State state)
        {
            this.caption = caption;
            this.startpoint.x = x;
            this.startpoint.y = y;
            this.w = w;
            this.h = h;
            this.state = state;
        }

        public override string ToString()
        {
            return $"Caption: {caption} Startpoint: x = {startpoint.x} y = {startpoint.y} Width: {w} Height: {h}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            Button button = (Button)obj;
            return this.caption == button.caption && this.w == button.w && this.h == button.h;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Check()
        {
            if (state == State.check)
                state = State.uncheck;
            else state = State.check;

        }

        public void Zoom(double q)
        {
            this.w = this.w * q;
            this.h = this.h * q;
        }

        double square;
        public double Square()
        {
            square = w * h;
            return square;
        }
    }

    public class CheckButton
    {
        public State state;
        public enum State
        {
            check = 1,
            uncheck
        }
    }

    public class User
    {
        public int Click { get; set; }
        public int Resize { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Button button1 = new Button("try", 12, 45, 12.2, 12.7, CheckButton.State.check);
            Button button2 = new Button("catch", 34, 5, 11.6, 7.8, CheckButton.State.uncheck);
            Button button3 = new Button("finally", 6, 13, 5.6, 7.9, CheckButton.State.uncheck);
            User user = new User();
            Console.WriteLine(button1.ToString());
            Console.WriteLine(button2.ToString());
            Console.WriteLine(button3.ToString());
            button1.Check();
            button2.Check();
            button3.Zoom(0.4);
            Console.WriteLine(button1.Equals(button2));
            Console.WriteLine(button1.ToString());
            Console.WriteLine(button2.ToString());
            Console.WriteLine(button3.ToString());

            LinkedList<Button> list = new LinkedList<Button>();

            list.AddFirst(button1);
            list.AddFirst(button2);
            list.AddFirst(button3);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            button1.w = button1.Square();
            button2.w = button2.Square();
            button3.w = button3.Square();
            Console.WriteLine(button1.w);
            Console.WriteLine(button2.w);
            Console.WriteLine(button3.w);

            double z = Convert.ToDouble(Console.ReadLine());
            var select = from i in list
                         where i.w == z
                         select i;
            foreach (var i in select)
            {
                Console.WriteLine(i.w);
            }
        }
    }
}
