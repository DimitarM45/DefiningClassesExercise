using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 1; i <= carCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];

                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);

                string cargoType = carInfo[4];

                Tire[] tires = new Tire[4]
                {
                    new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6])),
                    new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8])),
                    new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10])),
                    new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12])),
                };

                cars.Add(new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType), tires));
            }

            string typeOfCargo = Console.ReadLine();

            switch (typeOfCargo)
            {
                case "fragile":
                    cars = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).ToList();
                    break;

                case "flammable":
                    cars = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250).ToList();
                    break;

                default:
                    break;
            }

            foreach (Car car in cars)
                Console.WriteLine(car.Model);
        }
    }
}
