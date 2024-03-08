namespace SE4_Assignment
{
    public class ColourRGB : Shape
    {
        protected int red;
        protected int blue;
        protected int green;

        public ColourRGB(string[] array) : base(array)
        {
            noOfParameters = 3;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);

            string tempRed;
            string tempBlue;
            string tempGreen;


            tempRed = varStorage.GetVariableOrDefault(parameters[0]);
            tempGreen = varStorage.GetVariableOrDefault(parameters[1]);
            tempBlue = varStorage.GetVariableOrDefault(parameters[2]);


            try
            {
                red = int.Parse(tempRed);   // tries to parse the red as an int if not then an exception is thrown
                green = int.Parse(tempGreen);  // tries to parse the green as an int if not then an exception is thrown
                blue = int.Parse(tempBlue); // tries to parse the blue as an int if not then an exception is thrown
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            // throws an exception if the height or width isnt positive 
            if (red < 0 || red > 255) { throw new ArgumentException("Invalid data - Provided a Number out the range when Red should be between 0 and 255"); }
            if (blue < 0 || blue > 255) { throw new ArgumentException("Invalid data - Provided a Number out the range when Blue should be between 0 and 255"); }
            if (green < 0 || green > 255) { throw new ArgumentException("Invalid data - Provided a Number out the range when Green should be between 0 and 255"); }

            draw.setColour(red, green, blue);
        }
    }
}
