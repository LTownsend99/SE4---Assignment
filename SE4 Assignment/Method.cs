namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters passed in
    /// </summary>
    /// <example> METHOD myMethod(a,b,c) </example>
    public class Method : Shape
    {
        protected string name;
        protected List<string> method = new List<string>();
        protected List<string> methodParameters = new List<string>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"></param>
        public Method(string[] array) : base(array)
        {

        }

        /// <summary>
        /// Takes the parameters passed in, and proccesses them to make sure they are valid
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="varStorage"></param>
        /// <param name="methodStorage"></param>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            name = parameters[0].Split("(")[0]; // sets the first param to the method name

            int noOfParam = parameters[0].Split(',').Length;

            if (noOfParam > 1)
            {
                for (int i = 1; i <= noOfParam; i++)
                {
                    //runs through the parameters[] and split it down to the relevant commands
                    // these are then added to methodParamaters
                    methodParameters.Add(parameters[0].Split("(")[1].Split(',')[i - 1].Replace(")", ""));
                }
            }


            methodStorage.AddMethod(name, this);    // adds the method to the methodStorage
        }

        /// <summary>
        /// Sets the commands for the Method
        /// </summary>
        /// <param name="method"></param>
        public void setCommands(List<string> method)
        {
            this.method = method;
        }

        /// <summary>
        /// Gets the commands for the Method
        /// </summary>
        /// <returns> Commands for the Method </returns>
        public List<string> getCommands()
        {
            return method;
        }

        /// <summary>
        /// Gets the Parameters for the Method
        /// </summary>
        /// <returns> Parameters for the Method </returns>
        public List<string> getParameters()
        {
            return methodParameters;
        }
    }
}
