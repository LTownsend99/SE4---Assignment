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

        public Circle(string[] array) : base(array) { noOfParameters = 1; }

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

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Circle other = (Circle)obj;
            return this.radius == other.radius;
        }
    }
}
