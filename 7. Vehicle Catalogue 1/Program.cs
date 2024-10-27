using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Vehicle_Catalogue_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();


            // collect
            for (; ; )
            {
                string input = Console.ReadLine().Trim();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split('/');

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int horsePower = 0;
                int weight = 0;
                if (type == "Car")
                {
                    horsePower = int.Parse(tokens[3]);
                }
                else // type == "Truck"
                {
                    weight = int.Parse(tokens[3]);
                }

                Car car = null;
                Truck truck = null;

                if (type == "Car")
                {
                    car = new Car()
                    {
                        Brand = brand,

                        Model = model,

                        HorsePower = horsePower
                    };

                }
                else // type == "Truck"
                {
                    truck = new Truck()
                    {
                        Brand = brand,

                        Model = model,

                        Weight = weight
                    };

                }


                if (type == "Car")
                {
                    catalog.Cars.Add(car);
                }
                else // type == "Truck"
                {
                    catalog.Trucks.Add(truck);
                }

            }


            // sort
            List<Car> sortedCars;
            sortedCars = new List<Car>(catalog.Cars.OrderBy(c => c.Brand));

            List<Truck> sortedTrucks;
            sortedTrucks = new List<Truck>(catalog.Trucks.OrderBy(t => t.Brand));


            // print
            if (sortedCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (sortedTrucks.Count() > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            Trucks = new List<Truck>();

            Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }
}
