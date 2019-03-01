using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;
using Singleton;
using Adapter;
using Decorator;
using Facade;
using Iterator;
using Observer;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ObserverPatternDemo();

            //IteratorPatternDemo();
            Console.WriteLine(" ");

            //IteratorPatternDemo2();

            //FacadePatternDemo();
            //DecoratorPatternDemo();
            //SingletonPatternDemo();

            //BuilderPatternDemo();

            //AbstractFactoryDemo();

            //AdapterPatternDemo();


        }

        private static void ObserverPatternDemo()
        {
            Speedometer mySpeedometer = new Speedometer();
            SpeedMonitor monitor = new SpeedMonitor(mySpeedometer);
            GearBox gearBox = new GearBox(mySpeedometer);

            //Set Current Speed property to a value
            mySpeedometer.CurrentSpeed = 10;

            mySpeedometer.CurrentSpeed = 20;

            mySpeedometer.CurrentSpeed = 25;

            mySpeedometer.CurrentSpeed = 30;

            mySpeedometer.CurrentSpeed = 35;

        }

        private static void IteratorPatternDemo2()
        {
            Console.WriteLine("=== Road Bikes ===");
            RoadBikeRange roadRange = new RoadBikeRange();
            // foreach (var item in collection), FOREACH TAB TAB
            // type, variab of that type in"Collection of IBicyle objects"
            foreach (IBicycle bicycle in roadRange.Range)
            {
                Console.WriteLine(bicycle);
            }

            Console.WriteLine(" ========================= ");

            Console.WriteLine("=== Mountain Bikes ===");
            MountainBikeRange mountainRange = new MountainBikeRange();
            foreach (IBicycle bicycle in mountainRange.Range)
            {
                Console.WriteLine(bicycle);
            }

            Console.WriteLine("  ");

        }

        private static void IteratorPatternDemo()
        {
            Console.WriteLine("=== Road Bikes ===");
            RoadBikeRange roadRange = new RoadBikeRange();
            PrintIterator(roadRange.GetEnumerator());

            Console.WriteLine(" ");

            Console.WriteLine("=== Mountain Bikes ===");
            MountainBikeRange mountainRange = new MountainBikeRange();
            PrintIterator(mountainRange.GetEnumerator());
        }

        private static void PrintIterator(IEnumerator iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }
        //Facade Design Pattern Method
        private static void FacadePatternDemo()
        {
            BikeFacade facade = new BikeFacade();
            //calling a method inside the method
            //calling a constructor 
            facade.PrepareForSale(new Downhill(BikeColor.Red, new WideWheel(20)));
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
