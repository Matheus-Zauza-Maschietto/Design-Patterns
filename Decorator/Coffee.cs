using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator
{
    public class Coffee: ICoffee
    {
        public string Describe()
        {
            return "Café";
        }

        public double Price()
        {
            return 4d;
        }
    }
}