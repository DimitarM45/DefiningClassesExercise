using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;

        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;

            cars = new Dictionary<string, Car>();
        }

        public int Count
        {
            get { return this.cars.Count; }
        }

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
                return "Car with that registration number, already exists!";

            else if (cars.Count >= capacity)
                return "Parking is full!"; 

            else
            {
                cars.Add(car.RegistrationNumber, car);

                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (cars.ContainsKey(registrationNumber))
            {
                cars.Remove(registrationNumber);

                return $"Successfully removed {registrationNumber}";
            }
            else
                return "Car with that registration number, doesn't exist!";
        }

        public Car GetCar(string registrationNumber)
        {
            return cars[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string registratioNumber in registrationNumbers)
                cars.Remove(registratioNumber);
        }
    }
}
