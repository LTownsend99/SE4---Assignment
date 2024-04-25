namespace SE4_Assignment
{
    public class Polygon : Shape
    {
        public Polygon(string[] array) : base(array)
        {
            _ = noOfParameters > 2;
        }

        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            string temp;
            int tempInt;
            List<int> points = new List<int>();



            for (int i = 0; i < parameters.Length; i++)
            {
                temp = varStorage.GetVariableOrDefault(parameters[i]);

                try
                {
                    tempInt = int.Parse(temp);
                }
                catch (FormatException e)
                {
                    throw new ArgumentException("Invalid Data - Cannot convert to Integer");

                }

                if (tempInt < 0) 
                { throw new ArgumentException("Invalid data - Provided a Negative Number when points should be Positive"); }

                points.Add(tempInt);
            }


            draw.drawPolygon(points);

        }
    }
}
