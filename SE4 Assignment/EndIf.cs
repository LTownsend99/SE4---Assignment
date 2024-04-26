namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters passed in. 
    /// </summary>
    /// <example> ENDIF </example>
    public class EndIf : Shape
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters passed in </param>
        public EndIf(string[] array) : base(array)
        {
            noOfParameters = 0;
        }

        /// <summary>
        /// Takes the parameters passed in, and proccesses them to make sure they are valid
        /// </summary>
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);   // checks the no of parameters are correct
        }
    }
}
