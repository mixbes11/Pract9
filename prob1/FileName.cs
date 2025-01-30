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
            double SummaS = 0;
                Rectangle rect1 = new Rectangle(0.0000000000001, 4); // 1 пример, заведомо не подходящий по критериям
                rect1.Show();
                rect1++; // инкримент
                rect1.Show();
            Console.WriteLine("Работа инкремента ВЫШЕ");
                Rectangle rect2 = new Rectangle(140, 140); // 2 пример
                rect2.Show();
                rect2--; // декримент
                rect2.Show();
            Console.WriteLine("Работа декримента ВЫШЕ");
            Rectangle rect3 = new Rectangle(rect2); // 3 пример 
                rect3.Show();
                rect3.Result(rect3, 2); // увеличение в n раз объекта rect3
                rect3.Show();
            Console.WriteLine("Работа умножения ВЫШЕ");

            Rectangle result = rect1 + 6; // увеличение на n
            result.Show();
            Console.WriteLine("увеличение на n ВЫШЕ");
            Rectangle result1 = rect1 - 6; // уменьшение на n
            result1.Show();
            Console.WriteLine("уменьшение на n ВЫШЕ");
            Rectangle res23 = 6 + result1;
            res23.Show();
            Console.WriteLine("Правосторонняя функция ВЫШЕ");
            Console.WriteLine("Сравнения");
            Console.WriteLine(rect1.Equals(rect2)); // пример работы функции сравнения
            Console.WriteLine(rect1.Equals(rect1)); // пример работы функции сравнения
            bool buff;
            Console.WriteLine(buff = rect2); // пример приведения типа bool 
            Console.WriteLine((double)rect2); // пример приведения типа double
            rect1 = rect1.Result(rect1, 2);

            Console.WriteLine("Приведения типов");
            int buf1 = Rectangle.GetCount; // работа счетчика
            Console.WriteLine(buf1);
            Console.WriteLine("Счетчик");

            RectangleArray arr = new RectangleArray(10); // точно ошибочный пример на функции 
            arr.Show();
            try
            {
                Console.WriteLine(arr[22]);
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
            RectangleArray arr1 = new RectangleArray(NativeN); // возможность попробовать ввод данных самостоятельно
            arr1.Show();

            Console.WriteLine("Проверяемый элемент - 1, сам элемент:");
            try
            { 
                arr1[0].Show();
            }

            catch {
                Console.WriteLine("Индекс за границами массива");
            }
    RectangleArray arrayNew = new RectangleArray(arr1); // Копирование коллекции
            arrayNew.Show();
            for (int i = 0; i < NativeN; i++) // Вариантное задание
            {
                SummaS += (double)arrayNew[i];
            }
            Console.WriteLine(SummaS);
        }   
    }
}
