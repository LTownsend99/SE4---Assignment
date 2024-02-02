using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_Assignment
{
    abstract public class Shape : Command
    {
        

        protected Shape(string[] array) : base(array)
        {
        }

    }
}
