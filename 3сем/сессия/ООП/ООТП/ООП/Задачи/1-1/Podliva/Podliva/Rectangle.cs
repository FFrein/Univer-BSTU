using System;
using System.Collections.Generic;
using System.Text;

namespace Podliva
{
    interface Figure
    {
        string Print(Rectangle t);
    }
    [Serializable]
    class Rectangle : Figure
    {
        public int x { get; set; }
        public int y { get; set; }
        public int l { get; set; }
        public int h { get; set; }
        public string color { get; set; }
        public Rectangle() { }
        public Rectangle(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        public Rectangle(int x, int y, int l, int h, string color) : this(x,y,color)
        {
            
            this.h = h;
            this.l = l;
            
        }
        public static Rectangle operator +(Rectangle H, int i)
        {

            H.h = H.h + i;
            H.h = H.l + i;
            return H;
        }

        public int Sqr(Rectangle pl)
        {
            return pl.h * pl.l;
        }

        public  string Print(Rectangle t)
        {
            return   t.x + " " + t.y + " " + t.l + " " + t.h + " " + t.color;
        }
        public string ToString()
        {
            return base.ToString() + " " + l + " " + y + " " + l;
        }
    }
}
