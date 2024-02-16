using System.Drawing;
using System.Windows.Forms;

namespace SE4_Assignment
{
    public class Colour : Shape
    {
        protected string name;

        public Colour(string[] array) : base(array)
        {
            noOfParameters = 1;
        }

        public override void runCommand(Draw draw)
        {
            base.runCommand(draw);
            Color colour;
            name  = parameters[0];
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
