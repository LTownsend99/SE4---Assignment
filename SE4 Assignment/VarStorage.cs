
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
            if (varStorage.ContainsKey(name))
            {
                return varStorage[name];
            }
            else
            {
                return null;
            }
        }
    }
}
