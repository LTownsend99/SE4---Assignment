namespace SE4_Assignment
{
    /// <summary>
    /// Abstract class that Extends Command. All the command classes extend this class
    /// </summary>
    abstract public class Shape : Command
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters passed in</param>
        protected Shape(string[] array) : base(array)
        {
        }

    }
}
