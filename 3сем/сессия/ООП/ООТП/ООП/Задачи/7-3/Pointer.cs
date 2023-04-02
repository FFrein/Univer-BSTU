namespace taska7_3
{
    public class Pointer
    {
        double x;
        double y;

        public Pointer(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }


    }
}