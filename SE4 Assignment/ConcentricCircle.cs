namespace SE4_Assignment
{
    /// <summary>
    /// Validates the ConcentricCircle paramaters that are passed in 
    /// </summary>
    /// <example> CONCIRCLE 100 </example>
    public class ConcentricCircle : Shape
    {
        protected int radius;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array">the parameters that are passed in </param>
        public ConcentricCircle(string[] array) : base(array) { noOfParameters = 1; }

        /// <summary>
        /// Takes the parameters passed in, proccesses them to make sure they are valid and passes it to the draw class to draw the shape
        /// </summary>
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        /// <exception cref="ArgumentException"> Catches the exception and returns the relevant message to the Terminal</exception>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);   // checks the number of paramaters are correct

            string value;

            value = varStorage.GetVariableOrDefault(parameters[0]);

            try
            {
                radius = int.Parse(value);      // tries to parse the radius as an int if not then an exception is thrown
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            if (radius <= 0)
            {
                // throws an exception if the radius isnt positive 
                throw new ArgumentException("Invalid data - Provided a Negative Number when Radius should be Positive");
            }

            draw.drawConcentricCircle(radius);

        }

    }
}
