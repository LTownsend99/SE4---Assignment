namespace SE4_Assignment
{
    /// <summary>
    /// Validates the Rectangles parameters that are passed in
    /// </summary>
    /// <example> RECTANGLE 50 100</example>
    public class Rectangle : Shape
    {
        protected int width;
        protected int height;


        public Rectangle(string[] array) : base(array)
        {
            noOfParameters = 2;
        }

        /// <summary>
        /// Takes the parameters passed in, proccess them to make sure they are valid and passes it to the draw class to draw the shape
        /// </summary>
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            base.runCommand(draw, varStorage, methodStorage);   // checks the no of parameters are correct

            string tempW;
            string tempH;

            tempW = varStorage.GetVariableOrDefault(parameters[0]);     //checks if a variable has been declared if no uses what is passed in

            tempH = varStorage.GetVariableOrDefault(parameters[1]);


            try
            {
                width = int.Parse(tempW);   // tries to parse the width as an int if not then an exception is thrown
                height = int.Parse(tempH);  // tries to parse the height as an int if not then an exception is thrown
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            // throws an exception if the height or width isnt positive 
            if (width <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when Width should be Positive"); }
            if (height <= 0) { throw new ArgumentException("Invalid data - Provided a Negative Number when Height should be Positive"); }

            draw.drawRectangle(width, height);

        }

    }
}
