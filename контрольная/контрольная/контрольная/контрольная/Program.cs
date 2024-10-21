namespace контрольная
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var areaCalculator = new AreaCalculator();
           double[] radius = { 5 };
           double circleArea = areaCalculator.CalculatedArea(areaCalculator.CreateFigure("Круг"), radius);
           Console.WriteLine($"Площадь круга: {circleArea}");


            double[] value = { 3, 9, 10};
            double triangleArea = areaCalculator.CalculatedArea(areaCalculator.CreateFigure("треугольник"), value);
            Console.WriteLine($"Площадь треугольника: {triangleArea}");
        }
    }
}
