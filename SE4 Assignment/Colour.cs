namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parmaters that are passed in
    /// </summary>
    /// <example> COLOUR RED </example>
    public class Colour : Shape
    {
        protected string name;
        protected Color colour;
        protected Color colour1;
        protected Color colour2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters that are passed in </param>
        public Colour(string[] array) : base(array)
        {
            noOfParameters = 1;
        }

        /// <summary>
        /// Takes the parameters passed in, proccesses them to make sure they are valid and passes it to the draw class to Change the colour of the Pen and Brush
        /// </summary>
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal</exception>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);   // checks the number of parameter are correct


            name = varStorage.GetVariableOrDefault(parameters[0]);
            
            // if any of these Colours are used then its a multiColour

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
