using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9___classes
{
    class Circle
    {
        private double radius;
        private double pi = Math.PI;
        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {
            double x = pi * 2 * radius;
            return x;
        }

        public string GetFormattedCircumference()
        {
            string x = "\nThe circumference of your circle is: " + FormatNumber(GetCircumference());
            return x;
        }

        public double GetArea()
        {
            double x = pi * radius * radius;
            return x;
        }

        public string GetFormattedArea()
        {
            string x = "\nThe area of your circle is: " + FormatNumber(GetArea());
            return x;
        }

        private string FormatNumber (double x)
        {
            x = Math.Round(x, 2, MidpointRounding.AwayFromZero);
            string y = x.ToString();
            return y;
        }
    }
}