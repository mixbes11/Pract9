
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
        public void RectArrayCounter()
        {
            // Arrage
            RectangleArray arr1 = new RectangleArray(2);
            RectangleArray arr2 = new RectangleArray(arr1);
            // Act
            int buf2 = RectangleArray.GetArrayCount;
            // Assert
            Assert.AreEqual(buf2, 10);
        }

        [TestMethod]
        public void RectArrayNewCounter()
        {
            // Arrage
            RectangleArray arr1 = new RectangleArray(2);
            RectangleArray arr2 = new RectangleArray(arr1);
            // Act
            int buf3 = RectangleArray.GetSummator;
            // Assert
            Assert.AreEqual(buf3, 28);
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
    }
}