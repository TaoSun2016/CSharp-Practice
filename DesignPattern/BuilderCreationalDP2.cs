using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class BuilderCreationalDP2
    {
        public static void Main()
        {
            Shop shop = new Shop();
            VehicleBuilder builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();


            builder = new MortorBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }

        class Shop
        {
            public void Construct(VehicleBuilder builder)
            {
                builder.BuildFrame();
                builder.BuildEngine();
                builder.BuildWheels();
                builder.BuildDoors();
            }
        }

        abstract class VehicleBuilder
        {
            protected Vehicle vehicle;
            public Vehicle Vehicle
            {
                get { return vehicle; }
            }
            public abstract void BuildFrame();
            public abstract void BuildEngine();
            public abstract void BuildWheels();
            public abstract void BuildDoors();
        }

        class CarBuilder : VehicleBuilder
        {
            public CarBuilder()
            {
                vehicle = new Vehicle("Car");
            }
            public override void BuildFrame() {
                vehicle["frame"] = "car frame";
            }
            public override void BuildEngine() {
                vehicle["engine"] = "car engine";
            }
            public override void BuildWheels()
            {
                vehicle["wheels"] = "car wheels";
            }
            public override void BuildDoors() {
                vehicle["doors"] = "car doors";
            }
        }

        class MortorBuilder : VehicleBuilder
        {
            public MortorBuilder()
            {
                vehicle = new Vehicle("mortor");
            }
            public override void BuildFrame()
            {
                vehicle["frame"] = "mortor frame";
            }
            public override void BuildEngine()
            {
                vehicle["engine"] = "mortor engine";
            }
            public override void BuildWheels()
            {
                vehicle["wheels"] = "mortor wheels";
            }
            public override void BuildDoors()
            {
                vehicle["doors"] = "mortor doors";
            }
        }


        class Vehicle
        {
            private string type;
            private Dictionary<string, string> dic = new Dictionary<string, string>();

            public Vehicle(string type)
            {
                this.type = type;
            }

            public string this[string key]
            {
                get { return dic[key]; }
                set { dic[key] = value; }
            }

            public void Show()
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"type is {type}");
                Console.WriteLine($"frame[{dic["frame"]}]");
                Console.WriteLine($"engine[{dic["engine"]}]");
                Console.WriteLine($"wheels[{dic["wheels"]}]");
                Console.WriteLine($"doors[{dic["doors"]}]");
            }
        }
    }
}
