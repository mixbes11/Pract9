
using System.Reflection;

namespace prob1
{
    public class RectangleArray
    {
        Rectangle[] array;
        public Rectangle element;
        public static int collectCount = 0;
        public static int summator = 0;
        public RectangleArray() : this(10)
        {
            array = new Rectangle[10];
            QuickChoice();
            int vout;
            vout = 1;
            switch (vout)
            {
                case 1:
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = new Rectangle(WriteRandomNumber(), WriteRandomNumber());
                    }
                    break;
                case 2:
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = new Rectangle();
                    }
                    break;
            }
            collectCount++;
            summator += 10;
        }

        public static void QuickChoice()
        {
            Console.WriteLine("Каким образом хотите ввести массив");
            Console.WriteLine("1 - рандомно");
            Console.WriteLine("2 - с клавиатуры");
        }

        

        public static double WriteRandomNumber(double left = 0, double right = 1000000) /// Ввести рандомное число 
        {
            Random rnd = new Random();
            double value = rnd.NextDouble() * 46340;
            return value;
        }

        public RectangleArray(int numberElements, int vout=1, Array massive = null) 
        {
            array = new Rectangle[numberElements];
            QuickChoice();
            switch (vout)
            {
                case 1:
                    
                    for (int i = 0; i < numberElements; i++)
                    {
                        array[i] = new Rectangle(WriteRandomNumber(), WriteRandomNumber());
                    }
                    break;
                case 2: 
                    
                    for (int i = 0; i < numberElements; i++)
                    {
                        array[i] = new Rectangle();
                    }
                    break;
            }
            collectCount++;
            summator += numberElements;
        }
        
        public RectangleArray(RectangleArray rectArray)
        {
            this.array = rectArray.array;
            for (int i = 0; i < rectArray.array.Length; i++)
                rectArray[i] = rectArray[i];
            collectCount++;
            summator += rectArray.array.Length;
        }

        public void Show()
        {
            for (int i = 0;i < array.Length;i++)
                array[i].ToString();
        }

        public string ToString()
        {
            string resultString = string.Empty;
            Show();
            return resultString;
        }

        public Rectangle this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                array[index] = value;
            }
        }
        public static int GetArrayCount => collectCount;
        public static int GetSummator => summator;
    }
}