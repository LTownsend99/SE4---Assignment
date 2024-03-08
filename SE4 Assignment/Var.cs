namespace SE4_Assignment
{
    public class Var : Shape
    {
        string name;
        string value;

        public Var(string[] array) : base(array)
        {
            noOfParameters = 3;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);

            name = parameters[0];
            value = parameters[2];
            // parameters[1] will be the = that is used to declare a variable. We dont need this in the program and is skipped
            // The split is done within the shape factor on ' ' so = will become its own parameter in a sense.

            varStorage.AddVariable(name, value);        // store the varaiable and its value in the varStorage class
        }
    }

}
