
using System.Reflection;

namespace prob1
{
    internal class RectangleArray
    {
        Rectangle[] array;
        public Rectangle element;
        public static int collectCount = 0;
        public static int summator = 0;
        public RectangleArray() : this(10)
        {
            array = new Rectangle[10];
            Console.WriteLine("Каким образом хотите ввести массив");
            Console.WriteLine("1 - рандомно");
            Console.WriteLine("2 - с клавиатуры");
            int vout;
            vout = WriteNumber();
            switch (vout)
            {
                case 1:
                    Console.WriteLine("ввод рандомно");
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = new Rectangle(WriteRandomNumber(), WriteRandomNumber());
                    }
                    break;
                case 2:
                    Console.WriteLine("ввод с клавиатуры");
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = new Rectangle(WriteNumber(), WriteNumber());
                    }
                    break;
            }
            collectCount++;
            summator += 10;
        }

        public static int WriteNumber() /// Ввод числа с клавиатуры с проверкой
        {
            bool isConvert = false;
            string bufInput;
            int result = 0;

            while (!isConvert)
            {
                Console.WriteLine("Введите число");
                bufInput = Console.ReadLine();
                isConvert = int.TryParse(bufInput, out result);

                if (!isConvert)
                {
                    Console.WriteLine("Ошибка ввода(введено неверное значение)");
                }
            }
            return result;
        }

        public static double WriteRandomNumber(double left = 0, double right = 1000000) /// Ввести рандомное число 
        {
            Random rnd = new Random();

            double value = rnd.NextDouble() * 46340;
            return value;
        }

        public RectangleArray(int numberElements) 
        {
            array = new Rectangle[numberElements];
            Console.WriteLine("Каким образом хотите ввести массив");
            Console.WriteLine("1 - рандомно");
            Console.WriteLine("2 - с клавиатуры");
            int vout;
            vout = WriteNumber();
            switch (vout)
            {
                case 1:
                    Console.WriteLine("ввод рандомно");
                    for (int i = 0; i < numberElements; i++)
                    {
                        array[i] = new Rectangle(WriteRandomNumber(), WriteRandomNumber());
                    }
                    break;
                case 2: Console.WriteLine("ввод с клавиатуры");
                    for (int i = 0; i < numberElements; i++)
                    {
                        array[i] = new Rectangle(WriteNumber(), WriteNumber());
                    }
                    break;
            }
            collectCount++;
            summator += numberElements;
        }
        
        public RectangleArray(RectangleArray array)
        {
            this.array = array.array;
            for (int i = 0; i < array.array.Length; i++)
                array[i] = array[i];
            collectCount++;
            summator += array.array.Length;
        }

        public void Show()
        {
            for (int i = 0;i < array.Length;i++)
                array[i].Show();
        }

        

        public Rectangle this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                {

                    Console.WriteLine("Индекс за границами массива, возвращаю первый элемент");
                    return array[0];
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                    Console.WriteLine("Индекс за границами массива, возвращаю первый элемент");
                    array[index] = array[0];
                }
                array[index] = value;
            }
        }
        public static int GetArrayCount => collectCount;
        public static int GetSummator => summator;
    }
}