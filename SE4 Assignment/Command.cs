namespace SE4_Assignment
{
    /// <summary>
    /// Abstract class that shape class extend off
    /// </summary>
    abstract public class Command
    {
        protected string[] parameters;
        protected int noOfParameters;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters passed in</param>
        public Command(String[] array)
        {
            parameters = array;
        }
        /// <summary>
        /// Checks the no of Parameters are valid, if not returns an exception
        /// </summary>
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
        virtual public void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            if (parameters.Length != noOfParameters)
            {
                throw new ArgumentException("Invalid Number of Parmeters");
            }
        }

    }
}
