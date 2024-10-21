using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace контрольная
{
    public class AreaCalculator
    {
        public Figure CreateFigure(string figureType)
        {
            if (figureType.ToLower() == "круг")
            {
                return new Circle();
            }
            else 
                if (figureType.ToLower() == "треугольник")
            {
                return new Triangle();
            }
            else
            {
                throw new ArgumentException($"Неизвестный тип фигуры: {figureType}");
            }
        }

        public double CalculatedArea(Figure figure, double[] value)
        {
            return figure.CalculatedArea(value);
        }
    }
    
}
