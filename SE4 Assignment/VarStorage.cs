
namespace SE4_Assignment
{
    /// <summary>
    /// A Singleton class that validates the parameters passed in
    /// </summary>
    public class VarStorage
    {
        private static VarStorage instance = new VarStorage(); // implement singleton design pattern

        private Dictionary<string, string> varStorage;

        /// <summary>
        /// Private Constructor
        /// </summary>
        private VarStorage()
        {
            varStorage = new Dictionary<string, string>();
        }

        /// <summary>
        /// Allows an instance to be created of the VarStorage
        /// </summary>
        public static VarStorage Instance   
        {
            get { return instance; }
        }

        /// <summary>
        /// Add a variable to the varStorage
        /// </summary>
        /// <param name="name"> name of the variable</param>
        /// <param name="value"> value of the variable </param>
        public void AddVariable(string name, string value)
        {
            varStorage[name] = value;
        }

        /// <summary>
        /// Gets a variable from the varStorage
        /// </summary>
        /// <param name="name"> name of the variable</param>
        /// <returns></returns>
        public string GetVariable(string name)
        {
            if (varStorage.ContainsKey(name))       // checks if variable is referenced
            {
                return varStorage[name];
            }
            else
            {
                return null;            // if it isnt referenced sets value to null 
            }
        }

        /// <summary>
        /// Gets the variable from varStorage or returns what is passed in
        /// </summary>
        /// <param name="name"> name of the variable or the value passed in </param>
        /// <returns></returns>
        public string GetVariableOrDefault(string name)
        {
            if (varStorage.ContainsKey(name))       // checks if variable is referenced
            {
                return varStorage[name];
            }
            else
            {
                return name;                // if it isnt referenced sets value to the parameter passed
            }
        }

        /// <summary>
        /// Removes a varibale from the varStorage
        /// </summary>
        /// <param name="name"> name of the variable</param>
        public void removeVariable(string name)
        {
            varStorage.Remove(name);
        }
    }
}
