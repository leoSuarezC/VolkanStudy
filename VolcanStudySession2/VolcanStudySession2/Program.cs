using System;
using System.Collections.Generic;
using System.Text;


public class Opdracht6
{
    class Car
    {
        private string _name;
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public Car()
        {
        }
        public Car(string Name)
        {
            this._name = Name;
        }
    }

    class Shore
    {
        private string _name;
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = Name;
            }
        }
        private Car _waitingCar;
        public Car waitingCar
        {
            get
            {
                return _waitingCar;

            }
            set
            {
                this._waitingCar = value;

            }
        }
        public Shore(string Name)
        {
            this._name = Name;
        }
    }

    class Ferry
    {
        private string _name;
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = Name;
            }

        }

        private Car _loadedCar;
        public Car loadedCar
        {
            get
            {
                return _loadedCar;

            }
            set
            {
                this._loadedCar = value;

            }
        }
        public Ferry(string Name)
        {
            this._name = Name;
            this._loadedCar = null;
        }

    }


    public static void Main()
    {
        var car = new Car("Toyota");
        Console.WriteLine(car.Name);

        var shorenorth = new Shore("North Side");
        Console.WriteLine(shorenorth.Name);

        var shoresouth = new Shore("South Side");
        Console.WriteLine(shoresouth.Name);

        var ferry = new Ferry("Titanic");
        Console.WriteLine(ferry.Name);

        //THE CAR IN THE FERRY IS NOT PRESENT  (NULL)
        var whenNullCar = ferry.loadedCar;

        //WE ADD THE CAR TO THE FERRY
        ferry.loadedCar = car;
        var whenNotNullCar = ferry.loadedCar;
        Console.WriteLine("The car inside the ferry " + ferry.loadedCar.Name);
        Console.WriteLine("The car inside the ferry in another var (pointer) " + whenNotNullCar.Name);
        Console.ReadLine();

    }
}