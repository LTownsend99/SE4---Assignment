using static System.Windows.Forms.LinkLabel;

namespace SE4_Assignment
{
    public class IF : Shape
    {
        protected string instruction = "";
        protected int num1;
        protected int num2;
        protected bool check;

        public IF(string[] array) : base(array)
        {

        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            if (parameters.Length == 5)
            {
                instruction = parameters[3] + " " + parameters[4];
            }
            else if(parameters.Length == 6)
            {
                instruction = parameters[3] + " " + parameters[4] + " " + parameters[5];
            }
            else if (parameters.Length == 7)
            {
                instruction = parameters[3] + " " + parameters[4] + " " + parameters[5] + " " + parameters[6];
            }

            switch (parameters[1])
            {
                case "<":
                    check = smallerThan(parameters[0], parameters[2], varStorage);
                    break;
                case ">":
                    check = greaterThan(parameters[0], parameters[2], varStorage);
                    break;
                case "<=":
                    check = smallerOrEqualTo(parameters[0], parameters[2], varStorage);
                    break;
                case ">=":
                    check = greaterOrEqualTo(parameters[0], parameters[2], varStorage);
                    break;
                case "==":
                    check = equalTo(parameters[0], parameters[2], varStorage);
                    break;
                default:
                    throw new Exception("Invalid Operator: " + parameters[1]);
            }

            if (check == true)
            {
                try
                {
                    Command command = shapeFactory.proccessCommand(instruction);       //  passes the commmand from the line

                    command.runCommand(draw, varStorage);       //  proccesses the commmand
                }
                catch (Exception e)
                {
                    throw new ArgumentException("Invalid Data - Cannot Process inline Command");
                }
            }
        }

        private bool greaterThan(string number1, string number2, VarStorage varStorage)
        {
            bool result;

            // check if the variable already exists in the varStorage
            // Parse the strings to integers and add them together
            try
            {
                num1 = int.Parse(varStorage.GetVariableOrDefault(number1));
                num2 = int.Parse(varStorage.GetVariableOrDefault(number2));
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            if(num1 > num2) { result = true; } else { result = false; }


            return result;
        }

        private bool smallerThan(string number1, string number2, VarStorage varStorage)
        {
            bool result;

            // check if the variable already exists in the varStorage
            // Parse the strings to integers and add them together
            try
            {
                num1 = int.Parse(varStorage.GetVariableOrDefault(number1));
                num2 = int.Parse(varStorage.GetVariableOrDefault(number2));
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            if (num1 < num2) { result = true; } else { result = false; }


            return result;
        }

        private bool smallerOrEqualTo(string number1, string number2, VarStorage varStorage)
        {
            bool result;

            // check if the variable already exists in the varStorage
            // Parse the strings to integers and add them together
            try
            {
                num1 = int.Parse(varStorage.GetVariableOrDefault(number1));
                num2 = int.Parse(varStorage.GetVariableOrDefault(number2));
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            if (num1 <= num2) { result = true; } else { result = false; }


            return result;
        }

        private bool greaterOrEqualTo(string number1, string number2, VarStorage varStorage)
        {
            bool result;

            // check if the variable already exists in the varStorage
            // Parse the strings to integers and add them together
            try
            {
                num1 = int.Parse(varStorage.GetVariableOrDefault(number1));
                num2 = int.Parse(varStorage.GetVariableOrDefault(number2));
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            if (num1 >= num2) { result = true; } else { result = false; }


            return result;
        }

        private bool equalTo(string number1, string number2, VarStorage varStorage)
        {
            bool result;

            // check if the variable already exists in the varStorage
            // Parse the strings to integers and add them together
            try
            {
                num1 = int.Parse(varStorage.GetVariableOrDefault(number1));
                num2 = int.Parse(varStorage.GetVariableOrDefault(number2));
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid Data - Cannot convert to Integer");
            }

            if (num1 == num2) { result = true; } else { result = false; }


            return result;
        }
    }
}
