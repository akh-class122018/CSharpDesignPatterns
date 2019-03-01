using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Facade
{
    public class Registration
    {
        private IBicycle _bicycle;

        //constuctor take the variable
        public Registration(IBicycle bicycle)
        {
            this._bicycle = bicycle;
        }

        public void AllocateBikeNumber()
        {
            Console.WriteLine("Allocation bike number");
        }
    }
}
