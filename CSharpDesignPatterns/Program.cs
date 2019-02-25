using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;
using Singleton;
using Adapter;
using Decorator;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoratorPatternDemo();
            //SingletonPatternDemo();

            //BuilderPatternDemo();

            //AbstractFactoryDemo();

            //AdapterPatternDemo();


        }

        private static void DecoratorPatternDemo()
        {
            //standart Touring Bike
            IBicycle myTourbike = new Touring(new NarrowWheel(24));
            Console.WriteLine(myTourbike);

            // Touring Bike with custom grip Option
            myTourbike = new CustomGripOption(myTourbike);
            Console.WriteLine(myTourbike);

            // Touring Bike with leatherseat
            myTourbike = new LeatherSeatOption(myTourbike);
            Console.WriteLine(myTourbike);



        }

        private static void AdapterPatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(20));
            wheels.Add(new NarrowWheel(26));
            wheels.Add(new UltraWheelAdapter(new UltraWheel(28)));

            foreach (IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            }

        }

        private static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;
            Console.WriteLine("next serial " + generator.NextSerial);
            Console.WriteLine("next serial " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial " + generator.NextSerial);
        }

        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new Downhill(BikeColor.Green, new WideWheel(24));

            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);

        }


        private static void AbstractFactoryDemo()
        {
            /*parent class, creates objects of its child but not itself, because it is abstract, can't have a new instance
            that it(parent) created, that it's child also uses. Any child types (methods, property) created by the child cannot be seen it was first created by the parent, parent can see something a child created but a parent can see */

            //this class can only see the othods it reated from its child
            //                           new constructor being called
            AbstractBikeFactory factory = new RoadBikeFactory();

            // create Bike parts, object of interface, 
            //
            //interface object is bikeSeat, bikeFrame
            /* interface object is created. the factory object created calls the method that returns 
             * the interface that is is assinged to. THe create methodes create a new object of a 
             * Frame or Seat. This object can be either Road or Mountain. In this case the RoadFrame 
             * and the RoadSeat.   factory object calls Create Methods, thta return an interface type*/

            // interface + object of interface = object, create Bikeseat is method
            // CreateBikeFrame is a method

            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            //*show what we created,  printing out the properties, return 2 properties from Roadbike 
            /*thru interface object*  
             * method () can have paramenters inside it , constructor = class level method, with no returntype 
             * and use the class name
             * properties/
             * interface object bikeFrame calls the property BikeFrameParts
             * bikeFrame was created from the class RoadFrame
             * the property Bikeframeparts uses the get to return the string value from RoadFrame
             */
            Console.WriteLine(bikeFrame.BikeFrameParts);

            /*interface object bikeSeat calls the property BikeFrameParts
             * bikeSeat was created from the class RoadSeat
             * the property BikeSeatParts uses the get to return the string value from RoadSeat
             */

            Console.WriteLine(bikeSeat.BikeSeatParts);


        }
    }
}
