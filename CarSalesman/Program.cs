using System;
using System.Collections.Generic;
using System.Reflection;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());

            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

            for (int i = 1; i <= engineCount; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string engineModel = engineInfo[0];

                int power = int.Parse(engineInfo[1]);

                int displacement = 0;
                string efficiency = null;

                AddEngine(engines, engineInfo, engineModel, power, displacement, efficiency);
            }

            int carCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 1; i <= carCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = carInfo[0];
                string engineModel = carInfo[1];

                int weight = 0;
                string color = null;

                AddCar(engines, cars, carInfo, carModel, engineModel, weight, color);
            }

            foreach (Car car in cars)
                Console.WriteLine(car);
        }

        private static void AddEngine(Dictionary<string, Engine> engines, string[] engineInfo, string engineModel, int power, int displacement, string efficiency)
        {
            if (engineInfo.Length == 3)
            {
                if (int.TryParse(engineInfo[2], out int result))
                {
                    displacement = result;

                    engines.Add(engineModel, new Engine(engineModel, power, displacement));
                }

                else
                {
                    efficiency = engineInfo[2];

                    engines.Add(engineModel, new Engine(engineModel, power, efficiency));
                }
            }
            else if (engineInfo.Length == 4)
            {
                displacement = int.Parse(engineInfo[2]);

                efficiency = engineInfo[3];

                engines.Add(engineModel, new Engine(engineModel, power, displacement, efficiency));
            }
            else
                engines.Add(engineModel, new Engine(engineModel, power));
        }

        private static void AddCar(Dictionary<string, Engine> engines, List<Car> cars, string[] carInfo, string carModel, string engineModel, int weight, string color)
        {
            if (carInfo.Length == 3)
            {
                if (int.TryParse(carInfo[2], out int result))
                {
                    weight = result;

                    cars.Add(new Car(carModel, engines[engineModel], weight));
                }

                else
                {
                    color = carInfo[2];

                    cars.Add(new Car(carModel, engines[engineModel], color));
                }

            }
            else if (carInfo.Length == 4)
            {
                weight = int.Parse(carInfo[2]);

                color = carInfo[3];

                cars.Add(new Car(carModel, engines[engineModel], weight, color));
            }
            else
                cars.Add(new Car(carModel, engines[engineModel]));
        }
    }
}
