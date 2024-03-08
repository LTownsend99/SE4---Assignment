namespace SE4_Assignment
{
    public class Colour : Shape
    {
        protected string name;

        public Colour(string[] array) : base(array)
        {
            noOfParameters = 1;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);
            Color colour;

            if (varStorage.GetVariable(parameters[0]) != null)      // checks if variable is referenced
            {
                name = varStorage.GetVariable(parameters[0]);
            }
            else
            {
                name = parameters[0];                // if it isnt referenced sets name to the parameter passed
            }
            try
            {
                colour = Color.FromName(name);  //tries to set to the colour with that name provided
            }
            catch (Exception e)
            {
                throw new ArgumentException("Invalid Data - Invalid Colour name ");
            }

            if (colour.IsKnownColor == false)       // if it isnt a known colour an exception is given
            {
                throw new ArgumentException("Invalid Data - Not a known colour ");
            }

            draw.setColour(colour);
        }
    }
}
