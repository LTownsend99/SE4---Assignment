using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_Assignment
{
    internal class shapeFactory
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
                default:
                    throw new Exception("Invalid Command Word " + commandName);
            }
        }
    }
}
