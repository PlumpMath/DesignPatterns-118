using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.FlyweightApp
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Flyweight Design Pattern.
    /// </summary>
    class FlyweightApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Show()
        {
            // Arbitrary extrinsic state
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new
              UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

        // Constructor
        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return ((Flyweight)flyweights[key]);
        }
    }

    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }

    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// </summary>
    class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }

    /// <summary>
    /// The 'UnsharedConcreteFlyweight' class
    /// </summary>
    class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " +
              extrinsicstate);
        }
    }
}