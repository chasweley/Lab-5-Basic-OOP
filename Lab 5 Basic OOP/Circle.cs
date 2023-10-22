using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Basic_OOP
{
    internal class Circle //Creating circle class
    {
        public double Radius { get; set; } //Creating property for radius

        public Circle(double radius) //Constructor for radius to make it a required input
        {
            Radius = radius;
        }

        public double GetArea(double radius) //Method to calculate area and return answer rounded to two decimals
        {
            return Math.Round(radius * radius * Math.PI, 2);
        }

        public double GetVolume(double radius) //Method to calculate volume and return answer rounded to two decimals
        {
            return Math.Round(radius * radius * radius * 4 * Math.PI / 3, 2);
        }

        public double GetCircumference(double radius) //Method to calculate circumference and return answer rounded to two decimals
        {
            return Math.Round(radius * 2 * Math.PI, 2);
        }
    }
}
