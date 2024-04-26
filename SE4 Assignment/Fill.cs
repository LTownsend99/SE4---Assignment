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
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
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
