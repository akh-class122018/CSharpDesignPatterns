using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Visitor
{
    public class WheelDiagnostics : IWheelVisitor
    //to add additional features later, classsize small stil adding features to it
    {
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("Diagnosing the Wheel");
        }

        public void Visit(Spokes spokes)
        {
            Console.WriteLine("Diagnosing the Spokes");
        }

        public void Visit(Bearings bearings)
        {
            Console.WriteLine("Diagnosing the Bearings");
        }
    }
}
