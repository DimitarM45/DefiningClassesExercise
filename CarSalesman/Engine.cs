using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string model;

        private int power;

        private int displacement;

        private string efficiency;

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int displacement) 
        {
            Model = model;
            Power = power;
            Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency) 
        {
            Model = model;
            Power = power;
            Efficinecy = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficinecy = efficiency;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public int Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }

        public string Efficinecy
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($" {this.Model}:");
            sb.Append($"{Environment.NewLine}  Power: {this.Power}");
            sb.Append($"{Environment.NewLine}  Displacement: {(this.Displacement.ToString() != "0" ? this.Displacement.ToString() : "n/a")}");
            sb.Append($"{Environment.NewLine}  Efficiency: {(this.Efficinecy != null ? this.Efficinecy : "n/a")}");

            return sb.ToString();
        }
    }
}
