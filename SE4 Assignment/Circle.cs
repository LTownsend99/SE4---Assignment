using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_Assignment
{
    public class Circle : Shape
    {
        protected int radius;

        public Circle(string[] array) : base(array) { }

        public override void runCommand()
        {
            base.runCommand();

            try
            { 
            radius = int.Parse(parameters[0]);
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            if (radius <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when Radius should be Positive"); }

        }
    }
}
