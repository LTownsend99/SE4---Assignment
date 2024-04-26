
namespace SE4_Assignment
{
    public class VarStorage
    {
        private static VarStorage instance = new VarStorage(); // implement singleton design pattern

        private Dictionary<string, string> varStorage;
        private VarStorage()
        {
            varStorage = new Dictionary<string, string>();
        }

        public static VarStorage Instance   // allows an instance to be created of the Var Storage
        {
            get { return instance; }
        }

        public void AddVariable(string name, string value)
        {
            varStorage[name] = value;
        }

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

        public void removeVariable(string name)
        {
            varStorage.Remove(name);
        }
    }
}
