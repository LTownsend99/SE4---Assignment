namespace SE4_Assignment
{
    public class Circle : Shape
    {
        protected int radius;

        public Circle(string[] array) : base(array) { noOfParameters = 1; }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            base.runCommand(draw, varStorage);

            string value;

            if (varStorage.GetVariable(parameters[0]) != null)      // checks if variable is referenced
            {
                value = varStorage.GetVariable(parameters[0]);
            }
            else
            {
                value = parameters[0];      // if it isnt referenced sets value to the parameter passed
            }

            try
            {
                radius = int.Parse(value);      // tries to parse the radius as an int if not then an exception is thrown
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            if (radius <= 0)
            {
                // throws an exception if the radius isnt positive 
                throw new ArgumentException("Invalid data - Provided a Negative Number when Radius should be Positive");
            }

            draw.drawCircle(radius);

        }

    }
}
