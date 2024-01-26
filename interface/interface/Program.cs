using System;
using System.Collections.Generic;
using System.Threading;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quadcopter = new Quadcopter();
            foreach (var item in quadcopter.GetComponents())
            {
                Console.WriteLine(item);
            }
            quadcopter.Charge();
            Console.WriteLine(quadcopter.GetRobotType());
            Console.ReadLine();

        }
        interface IRobot
        {
            public string GetInfo()
            {
                var a = "I am a simple robot.";
                return a;
            }
            public List<string> GetComponents()
            {
                List<string> a = new List<string>() { "I am a simple robot." };
                return a;
            }
            public string GetRobotType()
            {
                var a = "I am a simple robot.";
                return a;
            }
        }
        interface IChargeable
        {
            void Charge();
            string GetInfo();
        }

        interface IFlyingRobot : IRobot
        {
            public new string GetRobotType()
            {
                var a = "I am a flying robot.";
                return a;
            }
        }

        class Quadcopter : IFlyingRobot, IChargeable
        {
            List<string> _components = new List<string>() { "rotor1", "rotor2", "rotor3", "rotor4" };
            public List<string> GetComponents()
            {
                return _components;
            }
            public void Charge()
            {
                Console.WriteLine("Charging...");
                Thread.Sleep(3000);
                Console.WriteLine("Charged!");
            }
            public string GetInfo()
            {
                throw new NotImplementedException();
            }
            public string GetRobotType()
            {
                var a = "I am a flying robot.";
                return a;
            }
        }
    }
}
