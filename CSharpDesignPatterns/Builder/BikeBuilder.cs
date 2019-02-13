using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns; // we need access to this namespace

namespace Builder
{
    public abstract class BikeBuilder
    {
        // proprty of IBicycle called Bicycle
        public abstract IBicycle Bicycle { get; }

        // Virtual keyword used to optionally override in child classes
        // public access modifier - Everyone can see
        // void means no return type

        public virtual void BuildStreetTires() { }

        public virtual void BuildWideTires() { }

        public virtual void BuildHandleBars() { }
    }
}
