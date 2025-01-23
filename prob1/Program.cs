using Microsoft.CSharp.RuntimeBinder;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace prob1
{
    internal class Rectangle
    {
        double width;
        double height;
        static int count = 0;

        public double Width
        {
            get { return width; }
            set {
                if ((value < 0.0001) || (value > 46340.9499))
                {
                    width = 0;
                    Console.WriteLine("Ошибка, ширина не может быть меньше 0.0001 или больше 46340,9499");
                }
                width = value;
            }
        }


        public double Height
        {
            get { return height; }
            set
            {
                if ((value < 0.0001) || (value > 46340.9499))
                {
                    height = 0;
                    Console.WriteLine("Ошибка, длина не может быть меньше 0.0001 или больше 46340,9499");
                }
                height = value;
            }
        }
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
            count++;

        }

        public Rectangle(Rectangle zero)
        {
            this.Width = zero.Width;
            this.Height = zero.Height;
            count++;

        }

        public Rectangle()
        {
            this.Width = Width;
            this.Height = Height;
            count++;

        }

        public static Rectangle operator ++(Rectangle rect1)
        {
            rect1.Width = rect1.Width + 1;
            rect1.Height = rect1.Height + 1;
            return rect1;
        }

        public static Rectangle operator --(Rectangle rect1)
        {
            rect1.Width = rect1.Width - 1;
            rect1.Height = rect1.Height - 1;
            return rect1;
        }

        public static Rectangle operator +(Rectangle rect1, double r)
        {
            rect1.Width += r;
            rect1.Height += r;
            return rect1;
        }

        public static Rectangle operator -(Rectangle rect1, double r)
        {
            rect1.Width -= r;
            rect1.Height -= r;
            return rect1;
        }

        //public void Double(double Width, double Height)
        //{
        //    double buf = (Width * Width + Height * Height);
        //    double result = 0.5 * Math.Pow(buf, 2);
        //    Console.WriteLine("Площадь описанной окружности равна", result);
        //}

        
        public double Sum(double Width, double Height)
        {
            return (double)(Width * Height);   
        }

        public static double Summa(double Width, double Height)
        {
            return (double)(Width * Height);

        }

        
        public void Show()
        {
            Console.WriteLine($"{Width}, {Height}");
            double result = Summa(Width, Height);
          
            Console.WriteLine(Sum(Width, Height));
        }

        public void Double(double Width, double Height)
        {
            double buf = (Width * Width + Height * Height);
            double result = 0.5 * Math.Pow(buf, 2);
            Console.WriteLine("Площадь описанной окружности равна", result);
        }

        public bool Bool(double Width, double Height)
        {
            if (Width < Height)
                return true;
            else
                return false;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }


        public static int GetCount => count;
    }
    
}