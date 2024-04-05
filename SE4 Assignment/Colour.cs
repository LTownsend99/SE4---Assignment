
using Timer = System.Windows.Forms.Timer;

namespace SE4_Assignment
{
    public class Colour : Shape
    {
        protected string name;
        protected Color color1;
        protected Color color2;
        Timer timer = new Timer();


        public Colour(string[] array) : base(array)
        {
            noOfParameters = 1;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);
            Color colour;

            
            name = varStorage.GetVariableOrDefault(parameters[0]);
            
            if(name.Equals("redGreen"))
            {
                color1 = Color.Red;
                color2 = Color.Green;
            }
            else if (name.Equals("blueYellow"))
            {
                color1 = Color.Blue;
                color2 = Color.Yellow;
            }
            else if (name.Equals("blackWhite"))
            {
                color1 = Color.Black;
                color2 = Color.White;
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
