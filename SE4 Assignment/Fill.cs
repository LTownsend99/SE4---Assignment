namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters passed in
    /// </summary>
    /// <example> FILL ON </example>
    public class Fill : Shape
    {
        protected bool fill;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters passed in </param>
        public Fill(string[] array) : base(array)
        {
            noOfParameters = 1;
        }

        /// <summary>
        /// Takes the parameters passed in, proccesses them to make sure they are valid and passes it to the draw class
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="varStorage"></param>
        /// <param name="methodStorage"></param>
        /// <exception cref="ArgumentException"></exception>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);

            if (parameters[0].Equals("ON"))
            {
                fill = true;
            }
            else if (parameters[0].Equals("OFF"))
            {
                fill = false;
            }
            else
            {
                // Throws an exception if an ineligible phrase is passed in 
                throw new ArgumentException("Invalid data - Provided a ineligible phrase");
            }

            draw.drawFill(fill);
        }
    }
}
