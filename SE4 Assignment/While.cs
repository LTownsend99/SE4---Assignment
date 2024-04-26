namespace SE4_Assignment
{
    /// <summary>
    /// Validates the parameters passed in
    /// </summary>
    public class While : Shape
    {
        protected string tempIns;
        public bool check;
        protected int num1;
        protected int num2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the paramaters passed in</param>
        public While(string[] array) : base(array)
        {
        }

        /// <summary>
        /// Takes the parameters passed in, and proccesses them to make sure they are valid. 
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="varStorage"></param>
        /// <param name="methodStorage"></param>
        /// <exception cref="Exception"></exception>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {


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


        }

        /// <summary>
        /// Checks that the expression passed in is correct or not 
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="varStorage"></param>
        /// <returns> A Bool of true or false </returns>
        /// <exception cref="ArgumentException"></exception>
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
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="varStorage"></param>
        /// <returns> A Bool of true or false </returns>
        /// <exception cref="ArgumentException"></exception>
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
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="varStorage"></param>
        /// <returns> A Bool of true or false </returns>
        /// <exception cref="ArgumentException"></exception>
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
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="varStorage"></param>
        /// <returns> A Bool of true or false </returns>
        /// <exception cref="ArgumentException"></exception>
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
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="varStorage"></param>
        /// <returns> A Bool of true or false </returns>
        /// <exception cref="ArgumentException"></exception>
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
