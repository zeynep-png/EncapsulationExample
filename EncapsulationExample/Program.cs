
using EncapsulationExample;

Car car1 = new Car("Honda", "Civic" , "White", 4);
car1.Display();

Console.WriteLine("\n\n------------------------------------\n\n");

Car car2 = new Car("Toyota", "Corolla", "Black", 3); // This will throw an error message
car2.Display();