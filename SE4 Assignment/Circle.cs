namespace SE4_Assignment
{
    /// <summary>
    /// Validates the circle paramaters that are passed in 
    /// </summary>
    /// <example> CIRCLE 100 </example>
    public class Circle : Shape
    {
        protected int radius;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array">the parameters that are passed in </param>
        public Circle(string[] array) : base(array) { noOfParameters = 1; }

        /// <summary>
        /// Takes the parameters passed in, proccesses them to make sure they are valid and passes it to the draw class to draw the shape
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="varStorage"></param>
        /// <param name="methodStorage"></param>
        /// <exception cref="ArgumentException"></exception>
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

            draw.drawCircle(radius);

        }

    }
}
