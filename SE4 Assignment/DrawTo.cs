namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters that are passed in
    /// </summary>
    /// <example> DRAWTO 50 100 </example>
    public class DrawTo : Shape
    {

        protected int x;
        protected int y;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters passed in </param>
        public DrawTo(string[] array) : base(array)
        {
            noOfParameters = 2;
        }

        /// <summary>
        /// Takes the parameters passed in, proccesses them to make sure they are valid and passes it to the draw class to draw the shape
        /// </summary>
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>

        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);

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
