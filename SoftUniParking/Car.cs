﻿using System;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        private string make;

        private string model;

        private int horsePower;

        private string registrationNumber;

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int HorsePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            set { this.registrationNumber = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Make: {this.Make}");
            sb.Append($"{Environment.NewLine}Model: {this.Model}");
            sb.Append($"{Environment.NewLine}HorsePower: {this.HorsePower}");
            sb.Append($"{Environment.NewLine}RegistrationNumber: {this.RegistrationNumber}");

            return sb.ToString();
        }
    }
}
