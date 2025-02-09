
namespace prob1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WidthTest()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Width = 1000;
            // Act
            rect1.Width = 1000;
            // Assert
            Assert.AreEqual(Width, rect1.Width);
        }
        [TestMethod]
        public void HeightTest()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            // Act
            rect1.Height = 30;
            // Assert
            Assert.AreEqual(Height, rect1.Height);
        }

        [TestMethod]
        public void RectSecondChance()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 30;
            Rectangle rect2 = new Rectangle(rect1);
            // Act
            rect1.Height = 30;
            rect2.Height = 30;
            rect2.Width = 30;
            rect1.Width = 30;
            // Assert
            Assert.AreEqual(rect1, rect2);
        }

        [TestMethod]
        public void RectThirdChance()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 30;
            Rectangle rect2 = new Rectangle(Width, Height);
            // Act
            rect1.Height = 30;
            rect2.Height = 30;
            rect2.Width = 30;
            rect1.Width = 30;
            // Assert
            Assert.AreEqual(rect1, rect2);
        }

        [TestMethod]
        public void EqualsTest()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 10;
            Rectangle rect2 = new Rectangle();
            Height = 30;
            Width = 10;
            // Act
            rect1.Height = 30;
            rect2.Height = 30;
            rect1.Width = 10; rect2.Width = 10;
            // Assert
            Assert.AreEqual(rect1, rect2);
        }
        [TestMethod]
        public void ResultSum()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 10;
            // Act
            rect1.Height = 30;
            rect1.Width = 10;
            double res = rect1.Sum();
            // Assert
            Assert.AreEqual(res, Height * Width);
        }
        [TestMethod]
        public void ResultSumma()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 10;
            // Act
            rect1.Height = 30;
            rect1.Width = 10;
            double res = Rectangle.Summa(rect1);
            // Assert
            Assert.AreEqual(res, Height * Width);
        }

        [TestMethod]
        public void ResultTestN()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 10;
            int N = 8;
            Rectangle rect2 = new Rectangle();
            // Act
            rect1.Height = 30;
            rect1.Width = 10;
            rect2.Height = 30 * N;
            rect2.Width = 10 * N;
            Rectangle result = rect1.Result(rect1, N);
            // Assert
            Assert.AreEqual(result, rect2);
        }
        [TestMethod]
        public void ResultTestPlus()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 10;
            int N = 8;
            Rectangle rect2 = new Rectangle();
            // Act
            rect1.Height = 30;
            rect1.Width = 10;
            rect2.Width = 10 + N;
            rect2.Height = 30 + N;
            Rectangle result = rect1 + N;
            // Assert
            Assert.AreEqual(result, rect2);
        }

        [TestMethod]
        public void ResultTestPlusLeft()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 10;
            int N = 8;
            Rectangle rect2 = new Rectangle();
            // Act
            rect1.Height = 30;
            rect1.Width = 10;
            rect2.Width = 10 + N;
            rect2.Height = 30 + N;
            Rectangle result = N + rect1;
            // Assert
            Assert.AreEqual(result, rect2);
        }

        [TestMethod]
        public void ResultTestMinus()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 10;
            int N = 8;
            Rectangle rect2 = new Rectangle();
            // Act
            rect1.Height = 30;
            rect1.Width = 10;
            rect2.Width = 10 - N;
            rect2.Height = 30 - N;
            Rectangle result = rect1 - N;
            // Assert
            Assert.AreEqual(result, rect2);
        }

        [TestMethod]
        public void ResultTestMinusLeft()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 10;
            int N = 8;
            Rectangle rect2 = new Rectangle();
            // Act
            rect1.Height = 30;
            rect1.Width = 10;
            rect2.Width = 10 - N;
            rect2.Height = 30 - N;
            Rectangle result = N - rect1;
            // Assert
            Assert.AreEqual(result, rect2);
        }

        [TestMethod]
        public void ResultTestDoubleMinus()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 10;
            Rectangle rect2 = new Rectangle();
            // Act
            rect1.Height = 30;
            rect1.Width = 10;
            rect2.Width = 9;
            rect2.Height = 29;
            Rectangle result = rect1--;
            // Assert
            Assert.AreEqual(result, rect2);
        }
        [TestMethod]
        public void ResultTestDoublePlus()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Height = 30;
            double Width = 10;
            Rectangle rect2 = new Rectangle();
            // Act
            rect1.Height = 30;
            rect1.Width = 10;
            rect2.Width = 11;
            rect2.Height = 31;
            Rectangle result = rect1++;
            // Assert
            Assert.AreEqual(result, rect2);
        }

        [TestMethod]
        public void RectArrayTest()
        {
            // Arrage
            int N = 10;
            RectangleArray arr1 = new RectangleArray(10);
            double Height = 30;
            double Width = 10;
            RectangleArray arr2 = new RectangleArray(arr1);
            // Act
            arr1[0] = arr2[0];
            // Assert
            Assert.AreEqual(arr1[0], arr2[0]);
        }

        [TestMethod]
        public void RectArrayByNew()
        {
            // Arrage
            RectangleArray arr1 = new RectangleArray(2);

            // Act
            RectangleArray arr2 = new RectangleArray(arr1);
            // Assert
            Assert.AreEqual(arr1[0], arr2[0]);
        }

        [TestMethod]
        public void RectArrayNoParams()
        {
            // Arrage
            RectangleArray arr1 = new RectangleArray();

            // Act
            RectangleArray arr2 = new RectangleArray(arr1);
            // Assert
            Assert.AreEqual(arr1[0], arr2[0]);
        }

        [TestMethod]
        public void RectArrayVariantTrue()
        {
            // Arrage
            RectangleArray arr1 = new RectangleArray(10);
            double SummaS = 0;
            // Act
            
            for (int i = 0; i < 10; i++) // Вариантное задание
            {
                SummaS += (double)arr1[i];
            }
            SummaS /= 10;
            double res = arr1.FindArifm();
            // Assert
            Assert.AreEqual(SummaS, res);
        }

        [TestMethod]
        public void RectArrayFullParams()
        {
            // Arrage
            RectangleArray arr1 = new RectangleArray(2, 2);

            // Act
            RectangleArray arr2 = new RectangleArray(arr1);
            // Assert
            Assert.AreEqual(arr1[0], arr2[0]);
        }


        [TestMethod]
        public void ToStringTests()
        {
            // Arrage
            RectangleArray arr1 = new RectangleArray(2);
            RectangleArray arr2 = new RectangleArray(arr1);
            // Act
            string result = arr1.ToString();
            string result1 = arr2.ToString();
            // Assert
            Assert.AreEqual(result, result1);
        }

        [TestMethod]
        public void DoubleRectangleTrue()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Width = 30;
            double Height = 10;
            // Act
            rect1.Width = Width;
            rect1.Height = Height;
            double buf = (rect1.Width * rect1.Width + rect1.Height * rect1.Height);
            double result = 0.5 * Math.Pow(buf, 0.5);
            // Assert
            Assert.AreEqual(result, (double) rect1);
        }

        [TestMethod]
        public void BoolRectangleFalse()
        {
            // Arrage
            Rectangle rect1 = new Rectangle();
            double Width = 30;
            double Height = 10;
            // Act
            rect1.Width = Width;
            rect1.Height = Height;
            
            // Assert
            Assert.AreEqual(false, (bool) rect1);
        }
    }
}