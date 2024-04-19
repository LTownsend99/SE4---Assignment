namespace SE4_Assignment
{
    public class Polygon : Shape
    {
        public Polygon(string[] array) : base(array)
        {
        }

        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            string temp;
            List<int> points = new List<int>();

            

                for (int i = 0; i < parameters.Length; i++)
                {
                    temp = varStorage.GetVariableOrDefault(parameters[i]);

                    try
                    {
                        points.Add(int.Parse(temp));

                    }catch(FormatException e)
                    {
                        throw new ArgumentException("Invalid Data - Cannot convert to Integer");

                    }
                }
            

            draw.drawPolygon(points);

        }
    }
}
