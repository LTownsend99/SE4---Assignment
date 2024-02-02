using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_Assignment
{
    public class Rectangle:Shape
    {
        protected int width;
        protected int height;


        public Rectangle(string[] array) : base(array)
        {
            noOfParameters = 2;
        }

        public override void runCommand()
        {
            base.runCommand();

            try
            {
                width = int.Parse(parameters[0]);
                height = int.Parse(parameters[1]);
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            if (width <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when Width should be Positive"); }
            if (height <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when Height should be Positive"); }



        }

    }
}
