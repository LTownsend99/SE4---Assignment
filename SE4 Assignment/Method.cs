namespace SE4_Assignment
{
    public class Method : Shape
    {
        protected string name;
        protected List<string> method = new List<string>();
        protected List<string> methodParameters = new List<string>();

        public Method(string[] array) : base(array)
        {

        }

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


            methodStorage.AddMethod(name, this);
        }

        public void setCommands(List<string> method)
        {
            this.method = method;
        }

        public List<string> getCommands()
        {
            return method;
        }

        public List<string> getParameters()
        {
            return methodParameters;
        }
    }
}
