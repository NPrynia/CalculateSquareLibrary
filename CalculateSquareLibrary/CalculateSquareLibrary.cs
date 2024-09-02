namespace CalculateSquareLibrary
{
    abstract public class Figure
    {
        //Абстрактный метод на вычисление площади
        public abstract double getArea();
    }

    public class Circle : Figure 
    { 
        private double Radius {get; set;}

        //Конструктор класса, с проверкой данных
        public  Circle(double r)
        {
            if (r <= 0 )
            {
                throw new ArgumentException("Радиус круга не может быть меньше 0");
            }
            Radius = r;
        }

        //Метод вычисления площади круга
        public override double getArea() 
        { 
            return Math.Round(Math.PI * Math.Pow(Radius,2),2); 
        }
    }
    public class Triangle : Figure
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }
        private double Perimeter { get; set; }


        //Конструктор класса, с проверкой данных
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 | b <= 0 | c <= 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть меньше 0");
            }

            if (a + b > c & a + c > b & b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException("Такой треугольник не существует");
            }
    
           
        }
        //Метод для поулчения периметра треугольника
        private void getPerimeter() 
        {
            Perimeter = A + B + C;  
        }

        //Метод вычисления площади треугольника
        public override double getArea()
        {
            if (Perimeter == 0)
            {
                getPerimeter();
            }

            return Math.Round((Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - A) * (Perimeter / 2 - B) * (Perimeter / 2 - C))),2);
        }

        //Метод для проверки является ли треугольник прямоугольным
        public bool isRight()
        {
            double max =A;
            double otherSide =B;
            double otherSideTwo = C;
            
            if (B>max)
            { 
                max = B;
                otherSide = A;
                otherSideTwo = C;
            }
            if (C > max)
            {
                max = C;
                otherSide = B;
                otherSideTwo = A;
            }

            if (Math.Pow(max, 2) == Math.Pow(otherSide, 2) + Math.Pow(otherSideTwo, 2))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }

}
