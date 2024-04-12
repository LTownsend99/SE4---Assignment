namespace SE4_Assignment
{
    public class Method : Shape
    {
        protected string name;
        protected List<string> value = new List<string>();
        public Method(string[] array) : base(array)
        {

        }

        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            name = parameters[0];

            for(int i = 1; i < parameters.Length; i++)
            {
                if (parameters[i] != "ENDMETHOD")
                {
                    value.Add(parameters[i]);
                }
            }
        }
    }
}
