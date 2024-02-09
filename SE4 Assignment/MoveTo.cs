using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_Assignment
{
    public class MoveTo : Command
    {
        protected int x;
        protected int y;

        public MoveTo(string[] array) : base(array)
        {
        }

        public override void runCommand()
        {
            base.runCommand();

            try
            {
                x = int.Parse(parameters[0]);
                y = int.Parse(parameters[1]);
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            if (x <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when x should be Positive"); }
            if (y <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when y should be Positive"); }


        }

    }
}
