namespace SE4_Assignment
{
    public class While : Shape
    {
        //  WHILE A < B 1 
        protected int noOfLines;
        protected string tempIns;
        protected bool check;
        protected int num1;
        protected int num2;

        public While(string[] array, int noOfLines) : base(array)
        {
            this.noOfLines = noOfLines;
        }

        public override void runCommand(Draw draw, VarStorage varStorage)
        {


            for (int i = 3; i < parameters.Length; i++)
            {
                //creates a string with all the parameters in
                tempIns += parameters[i] + " ";
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

            if (check == true)
            {
                
                    //splits the commands out again 
                    string[] temp = tempIns.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    List<string> instructions = new List<string>();

                    string currentCommand = "";

                    //goes through and creates an instruction. Every time there is a ; its the start of a new instruction
                    foreach (string line in temp)
                    {

                        if (line.EndsWith(";"))
                        {
                            instructions.Add(currentCommand.Trim());

                            currentCommand = line.Trim(';');

                        }
                        else
                        {
                            currentCommand += " " + line;
                        }
                    }

                    instructions.Add(currentCommand.Trim());

                    // removes the empty string at the start of the list
                    IEnumerable<string> instructionList = instructions.Skip(1);

                    // goes through each instuction and process the command
                    foreach (string inst in instructionList)
                    {
                        if (inst != "ENDWHILE")
                        {
                            try
                            {
                                Command command = shapeFactory.processCommand(inst, noOfLines);       //  passes the commmand from the line

                                command.runCommand(draw, varStorage);       //  proccesses the commmand
                            }
                            catch (Exception e)
                            {
                                throw new ArgumentException("Invalid Data - Cannot Process inline Command");
                            }
                        }
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

            if (num1 > num2) { result = true; } else { result = false; }


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
