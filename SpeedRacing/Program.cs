using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 1; i <= carCount; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];

                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumptionPerKilometer));
            }

            string[] tokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "End")
            {
                string model = tokens[1];

                double distance = double.Parse(tokens[2]);

                foreach (Car car in cars)
                {
                    if (car.Model == model)
                    {
                        car.Drive(distance);

                        break;
                    }
                }

                tokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (Car car in cars)
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
        }
    }
}
