namespace SE4_Assignment
{
    /// <summary>
    /// Validates the instruction that is passed in
    /// </summary>
    public class shapeFactory
    {
        /// <summary>
        /// Validates the commandName that is passed in and calls the relevant class relating to that name
        /// </summary>
        /// <param name="instruction"> the commands to be proccessed </param>
        /// <returns> an Object of the relevant name</returns>
        /// <exception cref="Exception"> catches the exception and provides the relevant message to the Terminal </exception>
        public static Command processCommand(String instruction)
        {
            instruction = instruction.ToUpper().Trim();
            String commandName = instruction.Split(' ')[0];

            String[] parameters = instruction.Split(' ').Skip(1).ToArray();

            switch (commandName)                        // calls the relevant command class
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
                    return new IF(parameters);
                case "WHILE":
                    return new While(parameters);
                case "ENDIF":
                    return new EndIf(parameters);
                case "ENDWHILE":
                    return new EndWhile(parameters);
                case "METHOD":
                    return new Method(parameters);
                case "ENDMETHOD":
                    return new EndMethod(parameters);
                case "POLYGON":
                    return new Polygon(parameters);

            }

            if (commandName.Contains("(") && commandName.Contains(")"))     // if the command contains () this means it is a method 
            {
                int noOfParam = commandName.Split(',').Length;

                // if noOfParam is greater than 1 then set the array size to noOfParam +1 else set it to noOfParam
                string[] methodParameters = new string[noOfParam > 1 ? noOfParam + 1 : noOfParam];

                methodParameters[0] = commandName.Split("(")[0];
                for (int i = 1; i < methodParameters.Length; i++)
                {
                    methodParameters[i] = commandName.Split("(")[1].Split(',')[i - 1].Replace(")", ""); // splits on ever, and will replace ) with nothing if present
                }

                return new CallMethod(methodParameters);        // call Method is called and the method is processed
            }

            throw new Exception("Invalid Command Word " + commandName);
        }
    }
}
