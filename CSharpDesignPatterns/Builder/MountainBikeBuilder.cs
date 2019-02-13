using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns; //added to access namespace

namespace Builder
{
    public class MountainBikeBuilder : BikeBuilder

    {
        // class object of AbstarctMountainBike
        // is assinged by the constructor
        // retrieved by the property Bicycle

        //class in the base class/class level variable
        private AbstractMountainBike _mountainBikeInProgess;

        // Property of MountainBikeBuilder used to return an object of IBicycle. 
        //This oject is AbstractMountainBike That implements the IBicycle interface
        public override IBicycle Bicycle
        {
            get
            {
                return _mountainBikeInProgess;
            }
        }
        //constructor takes name of the class
        //constructor of the class MountainBikeBuilder that
        //takes a Parameter of AbstractMountainBike and assigns that a 
        //parameter to the class field _mountainBikeInProgress
        //                              int      value
        //                              string   name
        //                              parameter object
        //
        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this._mountainBikeInProgess = mountainBike;
        }

        // method
        //public - access moifier
        //override - Used to define its behavior instead of the parent class 
        //that it exetends
        //void no return Type

        public override void BuildWideTires()
        {
            Console.WriteLine("Building MountainBike Wide Tires");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building MountainBike Handlebars");
        }
    }
}
