namespace SE4_Assignment
{
    public class Rectangle : Shape
    {
        protected int width;
        protected int height;


        public Rectangle(string[] array) : base(array)
        {
            noOfParameters = 2;
        }

        public override void runCommand()
        {
            base.runCommand();

            try
            {
                width = int.Parse(parameters[0]);   // tries to parse the width as an int if not then an exception is thrown
                height = int.Parse(parameters[1]);  // tries to parse the height as an int if not then an exception is thrown
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            // throws an exception if the height or width isnt positive 
            if (width <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when Width should be Positive"); }
            if (height <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when Height should be Positive"); }



        }

    }
}
