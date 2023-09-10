using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
	public class Car : ICar
	{
		public string Color { get; set; }
		private int _speed;
		public int Speed { get; set; }

		public void Accelerate(int acceleration)
		{
			_speed += acceleration;
		}

		public bool IsMoving()
		{
			return (_speed != 0);
		}

		public Car()
		{
			Color = "White";
			_speed = 0;
		}

		public Car(string color, int speed)
		{
			Color = color;
			Speed = speed;
		}

		public double CalculateMpg(int startKm, int endKm, double fuelConsumptionInLiters)
		{
			return (endKm -  startKm) / fuelConsumptionInLiters;
		}
	}
}
