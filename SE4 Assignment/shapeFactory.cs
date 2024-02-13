namespace SE4_Assignment
{
    public class shapeFactory
    {

        public static Command proccessCommand(String instruction)
        {
            String commandName = instruction.Split(' ')[0];
            commandName = commandName.ToUpper().Trim();

            String[] parameters = instruction.Split(' ').Skip(1).ToArray();

            switch (commandName)
            {
                case "CIRCLE":
                    return new Circle(parameters);
                case "TRIANGLE":
                    return new Triangle(parameters);
                case "RECTANGLE":
                    return new Rectangle(parameters);
                case "MOVETO":
                    return new MoveTo(parameters);
                case "DRAWTO":
                    return new DrawTo(parameters);
                case "FILL":
                    return new Fill(parameters);
                default:
                    throw new Exception("Invalid Command Word " + commandName);
            }
        }
    }
}
