namespace SE4_Assignment
{
    public class Clear : Shape
    {
        public Clear(string[] array) : base(array)
        {
            noOfParameters = 0;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);

            draw.clear();
        }

    }
}
