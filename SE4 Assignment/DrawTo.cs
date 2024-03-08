namespace SE4_Assignment
{
    public class DrawTo : Shape
    {

        protected int x;
        protected int y;

        public DrawTo(string[] array) : base(array)
        {
            noOfParameters = 2;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);

            string tempX;
            string tempY;

            tempX = varStorage.GetVariableOrDefault(parameters[0]);
            tempY = varStorage.GetVariableOrDefault(parameters[1]);


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

            draw.drawTo(x, y);
        }
    }
}
