namespace SE4_Assignment
{
    public class MethodStorage
    {
        private Dictionary<string, List <string> > methodStorage;
        public MethodStorage()
        {
            methodStorage = new Dictionary<string, List<string> >();
        }

        public void AddVariable(string name, List<string> value)
        {
            methodStorage[name] = value;
        }

        public List<string> GetVariable(string name)
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
