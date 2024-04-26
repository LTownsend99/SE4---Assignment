namespace SE4_Assignment
{
    public class MethodStorage
    {
        private static MethodStorage instance = new MethodStorage(); // implement singleton structure

        private Dictionary<string, Method> methodStorage;
        private MethodStorage()
        {
            methodStorage = new Dictionary<string, Method>();
        }

        public static MethodStorage Instance   // allows an instance to be created of the Var Storage
        { 
            get { return instance; } 
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
