namespace SE4_Assignment
{
    public class shapeFactory
    {

        public static Command proccessCommand(String instruction)
        {
            instruction = instruction.ToUpper();
            String commandName = instruction.Split(' ')[0];

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
                case "CLEAR":
                    return new Clear(parameters);
                case "RESET":
                    return new Reset(parameters);
                default:
                    throw new Exception("Invalid Command Word " + commandName);
            }
        }
    }
}
