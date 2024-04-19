namespace SE4_Assignment
{
    public class MethodStorage
    {
        private Dictionary<string, Method> methodStorage;
        public MethodStorage()
        {
            methodStorage = new Dictionary<string, Method>();
        }

        public void AddMethod(string name, Method method)
        {
            methodStorage[name] = method;
        }

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
