using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_Circle_Class
{
    class Circle
    {
        private double radius;


        //constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }


        //Methods
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public double CalculateCircumference()
        {
            double circumference = 2 * (Math.PI) * radius;
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            double circumference = CalculateCircumference();
            string formattedCircumference = FormatNumber(circumference);
            return formattedCircumference;
        }
        public double CalculateArea()
        {
            double area = (Math.PI) * radius * radius;
            return area;
        }
        public string CalculateFormattedArea()
        {
            double area = CalculateArea();
            string formattedArea = FormatNumber(area);
            return formattedArea;
        }
        private string FormatNumber(double x)
        {
            x = (Math.Truncate(x* 100) / 100);
            string formatted = x.ToString();
            return formatted;
        }
    }
}
