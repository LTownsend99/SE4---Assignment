﻿namespace SE4_Assignment
{
    /// <summary>
    /// Runs the Method when () are present
    /// </summary>
    public class CallMethod : Shape
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> the parameters that are passed in </param>
        public CallMethod(string[] array) : base(array)
        {
        }

        /// <summary>
        /// Runs through the parameters passed in and runs each Command within the method
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="varStorage">passed in so variables can be called from within the method</param>
        /// <param name="methodStorage"></param>
        /// <exception cref="Exception"></exception>
        public override void runCommand(Draw draw, VarStorage varStorage, MethodStorage methodStorage)
        {
            String methodName = parameters[0];      // sets the first param to the method name

            Method method = methodStorage.GetMethod(methodName);        // gets the method for the relevant name 

            List<string> methodParameters = method.getParameters();     // gets the parameters for the relevant method 

            // exception thrown if conditon is not met
            if (methodParameters.Count != parameters.Length - 1)
            {
                throw new Exception("Invalid Number of Paramters for Method");
            }

            for (int i = 1; i < parameters.Length; i++)
            {
                // checks if the parameter is in the var storage 
                String value = varStorage.GetVariableOrDefault(parameters[i]);

                // addeds a new variable to the var storage that is referenced in the method
                varStorage.AddVariable(methodParameters[i - 1], value);
            }

            // for each command it get it will proccess it as normal
            method.getCommands().ForEach(commandString =>

            {
                Command command = shapeFactory.processCommand(commandString);

                command.runCommand(draw, varStorage, methodStorage);
            });

            methodParameters.ForEach(varStorage.removeVariable);        // deScopes the variables used in the method. once the method has been called
        }
    }
}
