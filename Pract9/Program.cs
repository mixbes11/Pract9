using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    internal class Money
    {
        int rub;
        int kop;
        static int count = 0;
        public int Rub
        {
            get { return rub; }
            set
            {
                if (value < 0)
                {
                    rub = 0;
                    Console.WriteLine("Ошибка, рубли не могут быть отрицательными.");
                }
                else
                    rub = value;
            }
        }
        public int Kop
        {
            get => kop;
            set
            {
                if (value < 0)
                {
                    kop = 0;
                    Console.WriteLine("Ошибка, копейки не могут быть отрицательными.");
                }
                else
                {
                    if (value > 99)
                    {
                        Rub += value / 100;
                        kop = value % 100;
                    }
                    else
                        kop = value;
                }
            }

        }
        public Money()
        {
            Rub = 0;
            Kop = 0;
            count++;
        }
        public Money(int r, int k)
        {
            Rub = r;
            Kop = k;
            count++;
        }
        public void Show()
        {
            Console.WriteLine($"{Rub} р., {Kop} к.");
        }
        public static int GetCount
        {
            get => count;
        }
        public void AddKop(int sum)
        {
            Kop = Kop + sum;
        }
        public static void AddKop2(Money m, int sum)
        {
            m.Kop = m.Kop + sum;
        }
    }
}
