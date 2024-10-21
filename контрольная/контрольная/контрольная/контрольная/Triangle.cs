using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace контрольная
{
    public class Triangle : Figure
    {
        public double firstMagnitude;
        public double secondMagnitude;
        public double thirdMagnitude;

        public double FirstMagnitude
        {
            get { return firstMagnitude; }
            set { firstMagnitude = value; }
        }

        public double SecondMagnitude
        {
            get { return secondMagnitude; }
            set { secondMagnitude = value; }
        }
        public double ThirdMagnitude
        {
            get { return thirdMagnitude; }
            set { thirdMagnitude = value; }
        }

        public override double CalculatedArea(double[] value)
        {
            
            try
            {
                FirstMagnitude = value[0];
                SecondMagnitude = value[1];
                ThirdMagnitude = value[2];
            }
            catch (Exception ex) { Console.WriteLine("Недопустимое количество значений для измерения, необходимо хотя бы 3"); }

            //проверка существования треугольника
            bool isTriangleExist = IsTriangleExist(firstMagnitude, secondMagnitude, thirdMagnitude);
            //полуение полупериметра
            double semiPerimetr = (firstMagnitude + secondMagnitude + thirdMagnitude) / 2;
            //расчет площади
            double area = Math.Sqrt(semiPerimetr*(semiPerimetr-firstMagnitude)*(semiPerimetr-secondMagnitude)*(semiPerimetr-thirdMagnitude));

            return isTriangleExist ? area : 0;
        }

        public bool IsTriangleExist (double first, double second, double third)
        {
            if (first>0 && second>0 && third > 0)
            {
                if(first+second>third && first + third > second && second + third > first)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
