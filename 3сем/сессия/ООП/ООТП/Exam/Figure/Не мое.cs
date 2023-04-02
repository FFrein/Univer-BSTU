using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Patsey
{

    interface iFigure
    {
        void Print();
    }
    [Serializable]
    class Rectangle : iFigure
    {
        [NonSerialized]
        private int x;
        [NonSerialized]
        private int z;
        private int y;
        private string color;

        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
        public int X { get => x; set => x = value; }

        public Rectangle()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;

        }
        public Rectangle(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Rectangle(int x, int y, int z, string color) : this(x, y, z)
        {
            this.color = color;
        }

        public void Print()
        {
            Console.WriteLine($"Rectangle {X} {Y} {Z} {color}");
        }
        public override string ToString()
        {
            return $"Rectangle {X} {Y} {Z} {color}";
        }
        public static Rectangle operator +(Rectangle rectangle, Rectangle rectangle1)
        {
            return new Rectangle(rectangle.X + rectangle1.X, rectangle.Y + rectangle1.Y, rectangle.Z + rectangle1.Z);
        }
        public int Square()
        {
            return this.X * this.Y * this.Z;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> recs = new List<Rectangle>();
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(1, 4, 5);
            Rectangle r3 = new Rectangle(3, 4, 1, "red");
            Rectangle r4 = new Rectangle(5, 2, 1, "red");
            Rectangle r5 = new Rectangle(12, 33, 1, "red");
            Rectangle r6 = new Rectangle(53, 12, 1, "red");
            recs.Add(r6);
            recs.Add(r5);
            recs.Add(r4);
            recs.Add(r3);
            recs.Add(r2);
            recs.Add(r1);
            (r2 + r3).Print();
            var ordered = recs.OrderBy(t => t.X).ThenBy(t => t.Y).ThenBy(t => t.Square());
            Console.WriteLine(ordered.First());
            Console.WriteLine(ordered.Last());
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, recs);

                Console.WriteLine("Объект сериализован");
            }

        }
    }
}