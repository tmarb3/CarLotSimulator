using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot lot = new CarLot();
            
            var thomasCar = new Car();
            lot.CarList.Add(thomasCar);

            thomasCar.Make = "Ford";
            thomasCar.Model = "Focus";
            thomasCar.Year = 2013;
            thomasCar.EngineNoise = "vroom";
            thomasCar.HonkNoise = "beep";
            thomasCar.IsDrivable = true;

            var stevesCar = new Car()

            {
                Year = 2019,
                Make = "tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDrivable = false
            };
            lot.CarList.Add(stevesCar);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            var brettsCar = new Car(2013, "honda", "accord", "eehhhh", "honk", true);
            lot.CarList.Add(brettsCar);

            Console.WriteLine("--------------------");

            //*************BONUS X 2*************//

            foreach (var car in lot.CarList )
            {
                Console.WriteLine();
                Console.WriteLine($"Year : {car.Year} Make: {car.Make} Model: {car.Model}");

            }
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
