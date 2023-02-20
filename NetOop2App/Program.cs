using System.Security;

namespace NetOop2App
{
    abstract class Shape
    {
        public abstract string Title { set; get; }
        public int X { set; get; }
        public int Y { set; get; }

        public Shape()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return $"x = {X}, y = {Y}";
        }
        public virtual void Move()
        {

        }
        public abstract double Perimetr();
    }

    class Line : Shape
    {
        public int DX { set; get; }
        public int DY { set; get; }
        public override string Title { set; get; }

        public Line() : base()
        {
            this.DX = 0;
            this.DY = 0;
        }
        public Line(int x, int y, int dX, int dY) : base(x, y)
        {
            DX = dX;
            DY = dY;
        }
        public override double Perimetr()
        {
            return Math.Sqrt(Math.Pow(X + DX, 2) + Math.Pow(Y + DY, 2));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Line(1, 2, 3, 4);

            Console.WriteLine(shape);
        }
    }
}