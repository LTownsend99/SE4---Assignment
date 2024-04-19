namespace SE4_Assignment
{
    public class Colour : Shape
    {
        protected string name;
        protected Color colour1;
        protected Color colour2;


        public Colour(string[] array) : base(array)
        {
            noOfParameters = 1;
        }

        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);
            Color colour;


            name = varStorage.GetVariableOrDefault(parameters[0]);

            if (name.Equals("REDGREEN"))
            {
                colour1 = Color.Red;
                colour2 = Color.Green;
                draw.setMultiColour(colour1, colour2);

            }
            else if (name.Equals("BLUEYELLOW"))
            {
                colour1 = Color.Blue;
                colour2 = Color.Yellow;
                draw.setMultiColour(colour1, colour2);

            }
            else if (name.Equals("BLACKWHITE"))
            {
                colour1 = Color.Black;
                colour2 = Color.White;
                draw.setMultiColour(colour1, colour2);

            }
            else
            {
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
}
