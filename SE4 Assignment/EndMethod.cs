namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters that are passed in
    /// </summary>
    /// <example> ENDMETHOD </example>
    public class EndMethod : Shape
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters passed in</param>
        public EndMethod(string[] array) : base(array)
        {
            noOfParameters = 0;
        }

        /// <summary>
        /// Takes the parameters passed in, and proccesses them to make sure they are valid
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="varStorage"></param>
        /// <param name="methodStorage"></param>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);   // checks the number of parameters are correct
        }
    }
}
