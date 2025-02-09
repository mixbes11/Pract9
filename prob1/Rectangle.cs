using Microsoft.CSharp.RuntimeBinder;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prob1
{
    public class Rectangle
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

        public static Rectangle operator +(double r, Rectangle rect1)
        {
            rect1.Width += r;
            rect1.Height += r;
            return rect1;
        }

        public static Rectangle operator -(double r, Rectangle rect1)
        {
            rect1.Width -= r;
            rect1.Height -= r;
            return rect1;
        }

        public double Sum()
        {
            return (double)(Width * Height);   
        }

        public static double Summa(Rectangle rectangle)
        {
            return (double)(rectangle.Width * rectangle.Height);

        }

        public static Rectangle Resulted(Rectangle rect1, int N)
        {
            rect1.Width *= N;
            rect1.Height *= N;
            return rect1;
        }

        public Rectangle Result(Rectangle rect1, int N)
        {
            rect1.Width *= N;
            rect1.Height *= N;
            return rect1;
        }

        public string Show()
        {
            double resultString = Sum();
            return $"Длина = {Width}, Ширина = {Height}, Результат умножения {resultString}";
        }

        public static explicit operator double(Rectangle rect1)
        {
            double buf = (rect1.Width * rect1.Width + rect1.Height * rect1.Height);
            double result = 0.5 * Math.Pow(buf, 0.5);
            return result;
        }

        public static implicit operator bool(Rectangle rect1)
        {
            if (rect1.Width == rect1.Height)
                return true;
            else
                return false;
        }

        public override bool Equals(object? obj)
        {
            Rectangle rect = obj as Rectangle;
            if (rect == null) return false;

            return Width == rect.Width && Height == rect.Height;
        }


        public static int GetCount => count;
    }
    
}