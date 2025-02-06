using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
        internal class Program
        {
        public static void QuickChoice()
        {
            Console.WriteLine("Каким образом хотите ввести массив");
            Console.WriteLine("1 - рандомно");
            Console.WriteLine("2 - с клавиатуры");
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
        static void Main(string[] args)
            {
            Console.WriteLine("Задание 1 и 2");
            double SummaS = 0;
                Rectangle rect1 = new Rectangle(0.0000000000001, 4); // 1 пример, заведомо не подходящий по критериям
                Console.WriteLine(rect1.Show());
                rect1++; // инкримент
                Console.WriteLine(rect1.Show());
            Console.WriteLine("Работа инкремента ВЫШЕ");
                Rectangle rect2 = new Rectangle(140, 140); // 2 пример
                Console.WriteLine(rect2.Show());
                rect2--; // декримент
                Console.WriteLine(rect2.Show());
            Console.WriteLine("Работа декримента ВЫШЕ");
            Rectangle rect3 = new Rectangle(rect2); // 3 пример 
                Console.WriteLine(rect3.Show());
                rect3.Result(rect3, 2); // увеличение в n раз объекта rect3
                Console.WriteLine(rect3.Show());
            Console.WriteLine("Работа умножения ВЫШЕ");

            Rectangle result = rect1 + 6; // увеличение на n
            Console.WriteLine(result.Show());
            Console.WriteLine("увеличение на n ВЫШЕ");
            Rectangle result1 = rect1 - 6; // уменьшение на n
            Console.WriteLine(result1.Show());
            Console.WriteLine("уменьшение на n ВЫШЕ");
            Rectangle res23 = 6 + result1;
            Console.WriteLine(res23.Show());
            Console.WriteLine("Правосторонняя функция ВЫШЕ");
            Console.WriteLine("Сравнения");
            Console.WriteLine(rect1.Equals(rect2)); // пример работы функции сравнения
            Console.WriteLine(rect1.Equals(rect1)); // пример работы функции сравнения
            bool buff;
            Console.WriteLine(buff = rect2); // пример приведения типа bool 
            Console.WriteLine((double)rect2); // пример приведения типа double
            rect1 = rect1.Result(rect1, 2);

            Console.WriteLine("Приведения типов ВЫШЕ");
            int buf1 = Rectangle.GetCount; // работа счетчика
            Console.WriteLine(buf1);
            Console.WriteLine("Счетчик");

            QuickChoice();
            RectangleArray arr = new RectangleArray(10, WriteNumber()); // точно ошибочный пример на функции 
            Console.WriteLine(arr.TooString());
            try
            {
                Console.WriteLine(arr[22].Show());
            }
            catch {
                Console.WriteLine("Индекс за границами массива");
            }
            
            int buf2 = RectangleArray.GetArrayCount; // работа счетчика на arrayях
            Console.WriteLine(buf2);
            int buf3 = RectangleArray.GetSummator;
            Console.WriteLine(buf3);


            Console.WriteLine("Введите число элементов");
            int NativeN = WriteNumber();
            QuickChoice();
            RectangleArray arr1 = new RectangleArray(NativeN, WriteNumber()); // возможность попробовать ввод данных самостоятельно
            
            Console.WriteLine(arr1.TooString());

            Console.WriteLine("Проверяемый элемент - 1, сам элемент:");
            try
            {
                Console.WriteLine(arr1[0].Show());
            }

            catch {
                Console.WriteLine("Индекс за границами массива");
            }
            RectangleArray arrayNew = new RectangleArray(arr1); // Копирование коллекции
            Console.WriteLine(arrayNew.TooString());
            for (int i = 0; i < NativeN; i++) // Вариантное задание
            {
                SummaS += (double)arrayNew[i];
            }
            Console.WriteLine(SummaS);
        }   
    }
}
