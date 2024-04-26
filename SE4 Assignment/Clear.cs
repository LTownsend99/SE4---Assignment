namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters that are passed in 
    /// </summary>
    /// <example> CLEAR </example>
    public class Clear : Shape
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> parameters that are passed in </param>
        public Clear(string[] array) : base(array)
        {
            noOfParameters = 0;
        }

        /// <summary>
        /// Calls the draw class and the relevant method
        /// </summary>
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);   // checks the no of parameters are correct

            draw.clear();
        }

    }
}
