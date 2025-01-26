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
            Console.WriteLine("Работа инкремента");
                Rectangle rect2 = new Rectangle(140, 140); // 2 пример
                rect2.Show();
                rect2--; // декримент
                rect2.Show();
            Console.WriteLine("Работа декримента");
            Rectangle rect3 = new Rectangle(rect2); // 3 пример 
                rect3.Show();
                rect3.Result(rect3, 2); // увеличение в n раз объекта rect3
                rect3.Show();
            Console.WriteLine("Работа умножения");

            Rectangle result = rect1 + 6; // увеличение на n
            result.Show();
            Console.WriteLine("увеличение на n");
            Rectangle result1 = rect1 - 6; // уменьшение на n
            result1.Show();
            Console.WriteLine("уменьшение на n");

            Console.WriteLine(rect1.Equals(rect1)); // пример работы функции сравнения
            Console.WriteLine((bool)rect2); // пример приведения типа bool 
            Console.WriteLine((double)rect2); // пример приведения типа double
            rect1 = rect1.Result(rect1, 2);

            Console.WriteLine("Приведения типов");
            int buf1 = Rectangle.GetCount; // работа счетчика
            Console.WriteLine(buf1);
            Console.WriteLine("Счетчик");

            RectangleArray arr = new RectangleArray(10); // точно ошибочный пример на функции 
            arr.Show();
            Console.WriteLine(arr[22]);
            
            int buf2 = RectangleArray.GetArrayCount; // работа счетчика на arrayях
            Console.WriteLine(buf2);
            int buf3 = RectangleArray.GetSummator;
            Console.WriteLine(buf3);


            Console.WriteLine("Введите число элементов");
            int NativeN = WriteNumber();
            RectangleArray arr1 = new RectangleArray(NativeN); // возможность попробовать ввод данных самостоятельно
            arr1.Show();

            Console.WriteLine("Проверяемый элемент - 1, наличие ошибок:");
            Console.WriteLine(arr1[0]);
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
