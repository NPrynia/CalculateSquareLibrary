namespace CalculateSquareLibraryTest
{
    public class UnitTestForCalculateSquareLibrary
    {
        [Fact]
        public void TestMethodGetAreaCircleR5()
        {
            //Arange
            CalculateSquareLibrary.Circle circle = new CalculateSquareLibrary.Circle(5);
            double ex = 78.54;
            //act
            double result = circle.getArea();
            //Assert
            Assert.Equal(ex, result);
        }
        [Fact]
        public void TestMethodGetAreaCircleR16()
        {
            //Arange
            CalculateSquareLibrary.Circle circle = new CalculateSquareLibrary.Circle(16);
            double ex = 804.25;
            //act
            double result = circle.getArea();
            //Assert
            Assert.Equal(ex, result);
        }
        [Fact] 
        public void TestMethodGetAreaTriangleA16B10C7()
        {
            //Arange
            CalculateSquareLibrary.Triangle triangle = new CalculateSquareLibrary.Triangle(16,10,7);
            double ex = 22.57;
            //act
            double result = triangle.getArea();
            //Assert
            Assert.Equal(ex, result);
        }
        [Fact]
        public void TestMethodGetAreaTriangleA8B5C7()
        {
            //Arange
            CalculateSquareLibrary.Triangle triangle = new CalculateSquareLibrary.Triangle(8,5,7);
            double ex = 17.32;
            //act
            double result = triangle.getArea();
            //Assert
            Assert.Equal(ex, result);
        }
        [Fact]
        public void TestMethodisRightTriangleA8B5C7()
        {
            //Arange
            CalculateSquareLibrary.Triangle triangle = new CalculateSquareLibrary.Triangle(8, 5, 7);
            bool ex = false;
            //act
            bool result = triangle.isRight();
            //Assert
            Assert.Equal(ex, result);
        }
        [Fact]
        public void TestMethodisRightTriangleA7B24C25()
        {
            //Arange
            CalculateSquareLibrary.Triangle triangle = new CalculateSquareLibrary.Triangle(7, 24, 25);
            bool ex = true;
            //act
            bool result = triangle.isRight();
            //Assert
            Assert.Equal(ex, result);
        }
        [Fact]
        public void TestMethodisRightTriangleA25B24C7()
        {
            //Arange
            CalculateSquareLibrary.Triangle triangle = new CalculateSquareLibrary.Triangle(25, 24,7);
            bool ex = true;
            //act
            bool result = triangle.isRight();
            //Assert
            Assert.Equal(ex, result);
        }
    }
}