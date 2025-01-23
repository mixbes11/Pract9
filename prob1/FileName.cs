using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Rectangle rect1 = new Rectangle(0.0000000000001, 4);
                rect1.Show();

                Rectangle rect2 = new Rectangle(2000.3, 140);
                rect2.Show();
                Rectangle rect3 = new Rectangle();
                rect3.Show();
                rect1++;
            rect2--;
            rect1.Show();
            rect2.Show();
            Rectangle result = rect1 + 6;
            result.Show();
            Rectangle result1 = rect1 - 6;
            result1.Show();
            result1.Double();
        }
        }
}
