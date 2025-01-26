
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
            Console.WriteLine("����� ������� ������ ������ ������");
            Console.WriteLine("1 - ��������");
            Console.WriteLine("2 - � ����������");
            int vout;
            vout = WriteNumber();
            switch (vout)
            {
                case 1:
                    Console.WriteLine("���� ��������");
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = new Rectangle(WriteRandomNumber(), WriteRandomNumber());
                    }
                    break;
                case 2:
                    Console.WriteLine("���� � ����������");
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = new Rectangle(WriteNumber(), WriteNumber());
                    }
                    break;
            }
            collectCount++;
            summator += 10;
        }

        public static int WriteNumber() /// ���� ����� � ���������� � ���������
        {
            bool isConvert = false;
            string bufInput;
            int result = 0;

            while (!isConvert)
            {
                Console.WriteLine("������� �����");
                bufInput = Console.ReadLine();
                isConvert = int.TryParse(bufInput, out result);

                if (!isConvert)
                {
                    Console.WriteLine("������ �����(������� �������� ��������)");
                }
            }
            return result;
        }

        public static double WriteRandomNumber(double left = 0, double right = 1000000) /// ������ ��������� ����� 
        {
            Random rnd = new Random();

            double value = rnd.NextDouble() * 46340;
            return value;
        }

        public RectangleArray(int numberElements) 
        {
            array = new Rectangle[numberElements];
            Console.WriteLine("����� ������� ������ ������ ������");
            Console.WriteLine("1 - ��������");
            Console.WriteLine("2 - � ����������");
            int vout;
            vout = WriteNumber();
            switch (vout)
            {
                case 1:
                    Console.WriteLine("���� ��������");
                    for (int i = 0; i < numberElements; i++)
                    {
                        array[i] = new Rectangle(WriteRandomNumber(), WriteRandomNumber());
                    }
                    break;
                case 2: Console.WriteLine("���� � ����������");
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

                    Console.WriteLine("������ �� ��������� �������, ��������� ������ �������");
                    return array[0];
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                    Console.WriteLine("������ �� ��������� �������, ��������� ������ �������");
                    array[index] = array[0];
                }
                array[index] = value;
            }
        }
        public static int GetArrayCount => collectCount;
        public static int GetSummator => summator;
    }
}