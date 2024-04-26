namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters that are passed in
    /// </summary>
    /// <example> VAR A + B </example>
    public class Var : Shape
    {
        protected string name;
        protected string value;
        protected int num1;
        protected int num2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters passed in </param>
        public Var(string[] array) : base(array)
        {

        }

        /// <summary>
        /// Takes the parameters passed in, and proccesses them to make sure they are valid
        /// </summary>
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        /// <exception cref="Exception"> catches the exception and provides the relevant message to the Terminal </exception>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            name = parameters[0];

            if (parameters.Length != 3)
            {
                // checks to see if an operator is present
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

        /// <summary>
        /// Adds the 2 numbers together
        /// </summary>
        /// <param name="number1">First number passed in</param>
        /// <param name="number2"> second number passed in</param>
        /// <param name="varStorage"> provides the ability to call methods from this class </param>
        /// <returns> A string of the sum of the expression </returns>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
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

        /// <summary>
        /// Subtracts one number from the other
        /// </summary>
        /// <param name="number1">First number passed in</param>
        /// <param name="number2"> second number passed in</param>
        /// <param name="varStorage"> provides the ability to call methods from this class </param>
        /// <returns> A string of the sum of the expression </returns>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
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

        /// <summary>
        /// Multiplies the 2 numbers together
        /// </summary>
        /// <param name="number1">First number passed in</param>
        /// <param name="number2"> second number passed in</param>
        /// <param name="varStorage"> provides the ability to call methods from this class </param>
        /// <returns> A string of the sum of the expression </returns>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
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

        /// <summary>
        /// Divides one number from the other
        /// </summary>
        /// <param name="number1">First number passed in</param>
        /// <param name="number2"> second number passed in</param>
        /// <param name="varStorage"> provides the ability to call methods from this class </param>
        /// <returns> A string of the sum of the expression </returns>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
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
