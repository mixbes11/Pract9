
namespace Laba9
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

        }
    }
}