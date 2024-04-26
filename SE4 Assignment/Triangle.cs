namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters that are passed in
    /// </summary>
    /// <example> TRIANGLE 55 90 </example>
    public class Triangle : Shape
    {
        protected int width;
        protected int height;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters passed in</param>
        public Triangle(String[] array) : base(array)
        {
            noOfParameters = 2;
        }

        /// <summary>
        /// Takes the parameters passed in, proccess them to make sure they are valid and passes it to the draw class to draw the shape
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="varStorage"></param>
        /// <param name="methodStorage"></param>
        /// <exception cref="ArgumentException"></exception>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);       // checks the no of parameters are correct

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
