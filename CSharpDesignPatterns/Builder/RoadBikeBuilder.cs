using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns; //added to access namespace

namespace Builder
{
    public class RoadBikeBuilder : BikeBuilder

    {
        // class object of AbstarctRoadBike
        // is assinged by the constructor
        // retrieved by the property Bicycle

        //class in the base class/class level variable
        private AbstractRoadBike _roadBikeInProgess;

        // Property of RoadBikeBuilder used to return an object of IBicycle. 
        //This oject is AbstractRoadBike That implements the IBicycle interface
        public override IBicycle Bicycle
        {
            get
            {
                return _roadBikeInProgess;
            }
        }
        //                              int       vaconstructor of the class RoadBikeBuilder that
        //takes a Parameter of AbstractRoadbike and assigns that aparameter to the class field _roadBikeInProgress
        //                              int      value
        //                              string   name
        //                              parameter object
        //
        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeInProgess = roadBike;
        }

        // method
        //public - access modifier
        //override - Used to define its behavior instead of the parent class that it exeteds
        //void no return Type

        public override void BuildStreetTires()
        {
            Console.WriteLine("Building RoadBike Street Tires.");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building RoadBike Handlebars.");
        }


    }
}
