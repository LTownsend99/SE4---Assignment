namespace SE4_Assignment
{
    public class MoveTo : Shape
    {
        protected int x;
        protected int y;

        public MoveTo(string[] array) : base(array)
        {
            noOfParameters = 2;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);

            string tempX;
            string tempY;

            if (varStorage.GetVariable(parameters[0]) != null)      // checks if variable is referenced
            {
                tempX = varStorage.GetVariable(parameters[0]);
            }
            else
            {
                tempX = parameters[0];                // if it isnt referenced sets tempx to the parameter passed
            }
            if (varStorage.GetVariable(parameters[1]) != null)      // checks if variable is referenced
            {
                tempY = varStorage.GetVariable(parameters[0]);
            }
            else
            {
                tempY = parameters[0];                // if it isnt referenced sets tempx to the parameter passed
            }

            try
            {
                x = int.Parse(tempX);   // tries to parse the x as an int if not then an exception is thrown
                y = int.Parse(tempY);   // tries to parse the y as an int if not then an exception is thrown
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            // throws an exception if x or y arn not positive 
            if (x <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when x should be Positive"); }
            if (y <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when y should be Positive"); }

            draw.moveTo(x, y);
        }

    }
}
