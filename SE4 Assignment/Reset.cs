namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters passed in 
    /// </summary>
    public class Reset : Shape
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters passed in </param>
        public Reset(string[] array) : base(array)
        {
            noOfParameters = 0;
        }

        /// <summary>
        /// Takes the parameters passed in, proccesses them to make sure they are valid and passes it to the draw class
        /// </summary>
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);   // checks the number of parameters are correct

            draw.reset();
        }
    }
}
