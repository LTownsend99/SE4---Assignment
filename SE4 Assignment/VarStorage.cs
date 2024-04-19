
namespace SE4_Assignment
{
    public class VarStorage
    {
        private Dictionary<string, string> varStorage;
        public VarStorage()
        {
            varStorage = new Dictionary<string, string>();
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
