namespace SE4_Assignment
{
    /// <summary>
    /// Singleton class that Validates the parameters passed in
    /// </summary>
    public class MethodStorage
    {
        private static MethodStorage instance = new MethodStorage(); // implement singleton structure

        private Dictionary<string, Method> methodStorage;

        /// <summary>
        /// Private Constructor
        /// </summary>
        private MethodStorage()
        {
            methodStorage = new Dictionary<string, Method>();
        }

        /// <summary>
        /// Allows an instance to be created of the MethodStorage
        /// </summary>
        public static MethodStorage Instance  
        { 
            get { return instance; } 
        }

        /// <summary>
        /// Adds the Method to the MethodStorage
        /// </summary>
        /// <param name="name"> name of the method</param>
        /// <param name="method"> method commands </param>
        public void AddMethod(string name, Method method)
        {
            methodStorage[name] = method;
        }

        /// <summary>
        /// Gets the Methond from the MethodStorage
        /// </summary>
        /// <param name="name"> name of the method</param>
        /// <returns> the method commands for the specified method </returns>
        public Method GetMethod(string name)
        {
            if (methodStorage.ContainsKey(name))       // checks if method is referenced
            {
                return methodStorage[name];
            }
            else
            {
                return null;            // if it isnt referenced sets value to null 
            }
        }


    }
}
