namespace ConsoleApp1
{
    interface IShape
    {
        double Area();
        double Size();
    }

   
    class Square : IShape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double Area()
        {
            return side * side;
        }

        public double Size()
        {
            return side * 4;
        }
    }

    
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public double Size()
        {
            return 2 * Math.PI * radius;
        }
    }

   
    class Rectangle : IShape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Area()
        {
            return length * width;
        }

        public double Size()
        {
            return 2 * (length + width);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Square(2);
            IShape s2 = new Circle(22);
            IShape s3 = new Rectangle(4, 2);

            Console.WriteLine("Square Area:" +s1.Area() +" "+"Size:"+s1.Size());
            Console.WriteLine("Circle Area:" + s2.Area() + " " + "Size:" + s2.Size());
            Console.WriteLine("Rectangle Area:" + s3.Area() + " " + "Size:" + s3.Size());
        }
    }
}