namespace SE4_Assignment
{
    abstract public class Command
    {
        protected string[] parameters;
        protected int noOfParameters;

        public Command(String[] array)
        {
            parameters = array;
        }
        virtual public void runCommand(Draw draw, VarStorage varStorage)
        {
            if (parameters.Length != noOfParameters)
            {
                throw new ArgumentException("Invalid Number of Parmeters");
            }
        }



    }
}
