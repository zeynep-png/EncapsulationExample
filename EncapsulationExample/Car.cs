using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class Car
    {
        //proporties PascalCasing
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        private int numberOfDoors;

        public Car(string brand, string model, string color, int numberOfDoors)
        {
            Brand = brand; //Fields camelCasing
            Model = model;
            Color = color;
            NumberOfDoors = numberOfDoors; //encapsulated property

        }


        public int NumberOfDoors { get { return numberOfDoors; } 
            set {
                if (value == 2 || value == 4)
                    numberOfDoors = value;
                else {
                    Console.WriteLine("Geçersiz bir değer atanız.");
                    numberOfDoors = -1;

                }
            }
        }

        public void Display()
        {
            Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nColor: {Color}\nNumber of Doors: {NumberOfDoors}");
        }
    }
}