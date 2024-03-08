namespace SE4_Assignment
{
    public class Rectangle : Shape
    {
        protected int width;
        protected int height;


        public Rectangle(string[] array) : base(array)
        {
            noOfParameters = 2;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);

            string tempW;
            string tempH;

            if (varStorage.GetVariable(parameters[0]) != null)      // checks if variable is referenced
            {
                tempW = varStorage.GetVariable(parameters[0]);
            }
            else
            {
                tempW = parameters[0];                // if it isnt referenced sets tempW to the parameter passed
            }
            if (varStorage.GetVariable(parameters[1]) != null)      // checks if variable is referenced
            {
                tempH = varStorage.GetVariable(parameters[0]);
            }
            else
            {
                tempH = parameters[0];                // if it isnt referenced sets tempH to the parameter passed
            }

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

            draw.drawRectangle(width, height);

        }

    }
}
