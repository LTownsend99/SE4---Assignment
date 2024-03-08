namespace SE4_Assignment
{
    public class Var : Shape
    {
        protected string name;
        protected string value;
        protected int num1;
        protected int num2;

        public Var(string[] array) : base(array)
        {

        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {
            name = parameters[0];

            if (parameters.Length != 3)
            {
                switch (parameters[3])
                {
                    case "+":
                        value = addNumbers(parameters[2], parameters[4], varStorage);
                        break;
                    case "-":
                        value = subtractNumbers(parameters[2], parameters[4], varStorage);
                        break;
                    case "*":
                        value = multiplyNumbers(parameters[2], parameters[4], varStorage);
                        break;
                    case "/":
                        value = divideNumbers(parameters[2], parameters[4], varStorage);
                        break;
                    default:
                        throw new Exception("Invalid Operator: " + parameters[3]);
                }
            }
            else
            {
                value = parameters[2];
                // parameters[1] will be the = that is used to declare a variable. We dont need this in the program and is skipped
                // The split is done within the shape factor on ' ' so = will become its own parameter in a sense.
            }

            varStorage.AddVariable(name, value);        // store the varaiable and its value in the varStorage class
        }

        private string addNumbers(string number1, string number2, VarStorage varStorage)
        {

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

            int total = num1 + num2;


            return total.ToString();
        }

        private string subtractNumbers(string number1, string number2, VarStorage varStorage)
        {
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

            int total = num1 - num2;


            return total.ToString();
        }

        private string multiplyNumbers(string number1, string number2, VarStorage varStorage)
        {
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

            int total = num1 * num2;


            return total.ToString();
        }

        private string divideNumbers(string number1, string number2, VarStorage varStorage)
        {
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

            int total = num1 / num2;


            return total.ToString();
        }

    }

}
