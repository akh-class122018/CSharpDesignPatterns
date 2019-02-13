using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public abstract class BikeDirector
    {
        //paramater of a method(BikeBuilder builder)
        //object type + variable name for this type
        // like int          value
        // build name for method
        //public =access modifier
        //abstarct= requires child classes to implement
        //IBicycle = returntype of the method
        public abstract IBicycle Build(BikeBuilder builder);
    }
}
