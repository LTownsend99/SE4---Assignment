namespace SE4_Assignment
{
    public class shapeFactory
    {

        public static Command processCommand(String instruction, int noOfLines)
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
                case "COLOURRGB":
                    return new ColourRGB(parameters);
                case "COLOUR":
                    return new Colour(parameters);
                case "FILL":
                    return new Fill(parameters);
                case "CLEAR":
                    return new Clear(parameters);
                case "RESET":
                    return new Reset(parameters);
                case "VAR":
                    return new Var(parameters);
                case "IF":
                    return new IF(parameters, noOfLines);
                case "WHILE":
                    return new While(parameters, noOfLines);
                case "ENDIF":
                    return null;
                case "ENDWHILE":
                    return null;
                default:
                    throw new Exception("Invalid Command Word " + commandName);
            }
        }
    }
}
