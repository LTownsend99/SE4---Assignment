namespace SE4_Assignment
{
    /// <summary>
    /// Validates the Polygons parameters that are passed in
    /// </summary>
    public class Polygon : Shape
    {
        public Polygon(string[] array) : base(array)
        {
            _ = noOfParameters > 2;
        }
        /// <summary>
        /// Takes the parameters passed in, proccesses them to make sure they are valid and passes it to the draw class to draw the shape
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="varStorage"></param>
        /// <param name="methodStorage"></param>
        /// <exception cref="ArgumentException"></exception>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            string temp;
            int tempInt;
            List<int> points = new List<int>();



            for (int i = 0; i < parameters.Length; i++)
            {
                // checks if the variable is already created and fetchs its value, if not uses the default passed in
                temp = varStorage.GetVariableOrDefault(parameters[i]);

                try
                {
                    tempInt = int.Parse(temp);  // tries to parse temp to an int
                }
                catch (FormatException e)
                {
                    throw new ArgumentException("Invalid Data - Cannot convert to Integer");

                }

                if (tempInt < 0) // only positive numbers allowed
                { throw new ArgumentException("Invalid data - Provided a Negative Number when points should be Positive"); }

                points.Add(tempInt);
            }


            draw.drawPolygon(points);

        }
    }
}
