namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters passed in
    /// </summary>
    /// <example> IF A < B </example>
    public class IF : Shape
    {
        protected string instruction = "";
        protected int num1;
        protected int num2;
        public bool check;
        public bool singleLine = true;
        protected string tempIns;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters passed in</param>
        public IF(string[] array) : base(array)
        {
        }

        /// <summary>
        /// Takes the parameters passed in, and proccesses them to make sure they are valid. 
        /// </summary>
        /// <param name="draw"> provides the ability to call methods from this class</param>
        /// <param name="varStorage">provides the ability to call methods from this class</param>
        /// <param name="methodStorage"> provides the ability to call methods from this class </param>
        /// <exception cref="Exception"> catches the exception and provides the relevant message to the Terminal </exception>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {


            if (parameters.Length == 3)     // if there are 3 parameters then it is not a singleLine IF
            {
                singleLine = false;
            }


            // checks the operator of the IF statement and calls the relevant method
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

            if (singleLine)     
            {
                // creates the instruction from the parameters passed in

                if (parameters.Length == 5)
                {
                    instruction = parameters[3] + " " + parameters[4];
                }
                else if (parameters.Length == 6)
                {
                    instruction = parameters[3] + " " + parameters[4] + " " + parameters[5];
                }
                else if (parameters.Length == 7)
                {
                    instruction = parameters[3] + " " + parameters[4] + " " + parameters[5] + " " + parameters[6];
                }

                if (check == true)
                {
                    try
                    {
                        Command command = shapeFactory.processCommand(instruction);       //  passes the commmand from the line

                        command.runCommand(draw, varStorage, methodStorage);       //  proccesses the commmand
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException("Invalid Data - Cannot Process inline Command");
                    }
                }

            }

        }

        /// <summary>
        /// Checks that the expression passed in is correct or not 
        /// </summary>
        /// <param name="number1">First number passed in</param>
        /// <param name="number2"> second number passed in</param>
        /// <param name="varStorage"> provides the ability to call methods from this class </param>
        /// <returns> A Bool of true or false </returns>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
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

            if (num1 > num2) { result = true; } else { result = false; }


            return result;
        }

        /// <summary>
        /// Checks that the expression passed in is correct or not 
        /// </summary>
        /// <param name="number1">First number passed in</param>
        /// <param name="number2"> second number passed in</param>
        /// <param name="varStorage"> provides the ability to call methods from this class </param>
        /// <returns> A Bool of true or false </returns>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
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

        /// <summary>
        /// Checks that the expression passed in is correct or not 
        /// </summary>
        /// <param name="number1">First number passed in</param>
        /// <param name="number2"> second number passed in</param>
        /// <param name="varStorage"> provides the ability to call methods from this class </param>
        /// <returns> A Bool of true or false </returns>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
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

        /// <summary>
        /// Checks that the expression passed in is correct or not 
        /// </summary>
        /// <param name="number1">First number passed in</param>
        /// <param name="number2"> second number passed in</param>
        /// <param name="varStorage"> provides the ability to call methods from this class </param>
        /// <returns> A Bool of true or false </returns>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
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

        /// <summary>
        /// Checks that the expression passed in is correct or not 
        /// </summary>
        /// <param name="number1">First number passed in</param>
        /// <param name="number2"> second number passed in</param>
        /// <param name="varStorage"> provides the ability to call methods from this class </param>
        /// <returns> A Bool of true or false </returns>
        /// <exception cref="ArgumentException"> catches the exception and provides the relevant message to the Terminal </exception>
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
