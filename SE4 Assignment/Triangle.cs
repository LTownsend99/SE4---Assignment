﻿namespace SE4_Assignment
{
    public class Triangle : Shape
    {
        protected int width;
        protected int height;

        public Triangle(String[] array) : base(array)
        {
            noOfParameters = 2;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);

            string tempW;
            string tempH;

            tempW = varStorage.GetVariableOrDefault(parameters[0]);

            tempH = varStorage.GetVariableOrDefault(parameters[1]);

            try
            {
                width = int.Parse(tempW);   // tries to parse the width as an int if not then an exception is thrown
                height = int.Parse(tempH);  // tries to parse the height as an int if not then an exception is thrown
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }
            // throws an exception if the height or width isnt positive 
            if (width <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when Width should be Positive"); }
            if (height <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when Height should be Positive"); }

            draw.drawTriangle(width, height);
        }
    }
}
