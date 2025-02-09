
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
            
            for (int i = 0; i < 10; i++)
                {
                    array[i] = new Rectangle(WriteRandomNumber(), WriteRandomNumber());
                }
                    
            collectCount++;
            summator += 10;
        }

        public static double WriteRandomNumber(double left = 0, double right = 1000000) /// ¬вести рандомное число 
        {
            Random rnd = new Random();
            double value = rnd.NextDouble() * 46340;
            return value;
        }

        public RectangleArray(int numberElements, int vote=1, Array massive = null) 
        {
            array = new Rectangle[numberElements];
            
            switch (vote)
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

        public string TooString()
        {
            string resultOfShow = string.Empty;
            for (int i = 0; i < array.Length; i++)
                resultOfShow += array[i].Show();
            return resultOfShow;
        }

        public double FindArifm()
        { 
            double result = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                result += (double)array[i];
            }

            return (result / array.Length);
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