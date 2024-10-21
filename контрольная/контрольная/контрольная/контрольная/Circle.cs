using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace контрольная
{
    public class Circle : Figure
    {
        public double radius;
        public double Radius
        {
            get { return radius; } 
            set { radius = value; }
        }

        public override double CalculatedArea(double[] value)
        {
            if(value.Length < 1)
                throw new Exception("Для рассчета площади круга необходимо хотя бы 1 значение");
            else if(value.Length>1)
                Console.WriteLine("Расчет произведен по первому значению");
            
            Radius = value[0];

            return Math.PI * Math.Pow(Radius, 2);

        }
    }
}
