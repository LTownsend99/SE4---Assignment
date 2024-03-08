namespace SE4_Assignment
{
    public class Reset : Shape
    {
        public Reset(string[] array) : base(array)
        {
            noOfParameters = 0;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);

            draw.reset();
        }
    }
}
