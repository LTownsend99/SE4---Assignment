using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SE4_Assignment
{
    abstract public class Command
    {
        protected string[] parameters;
        protected int noOfParameters;

        public Command(String[] array) 
        { 
            parameters = array;
        }
        virtual public void runCommand()
        {
            if(parameters.Length != noOfParameters)
            {
                throw new ArgumentException("Invalid Number of Parmeters");
            }
        }
        

        
    }
}
