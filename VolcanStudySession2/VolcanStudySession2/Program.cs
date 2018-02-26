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

        public void print()
        {
            Console.WriteLine(" Car name: " + _name);
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
        private Ferry _waitingFerry;
        public Ferry waitingFerry {
            get
            {
                return _waitingFerry;
            }
            set
            {
                this._waitingFerry = value;
            }
        }
        public Shore(string Name)
        {
            this._name = Name;
            this._waitingCar = null;
            this._waitingFerry = null;
        }

        public void print()
        {
            Console.WriteLine(" ShoreName : " + _name );
            if (_waitingCar != null)
            {
                Console.WriteLine(" waitingCarName : " + _waitingCar.Name);
            }
            else
            {
                Console.WriteLine(" waitingCarName : noCarWaiting" );
            }
            if (_waitingFerry != null)
            {
                Console.WriteLine(" waitingFerryName : " + _waitingFerry.Name);
            }
            else
            {
                Console.WriteLine(" waitingFerryName : noFerryWaiting");
            }
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

        public void print()
        {
            Console.WriteLine(" FerryName : " + _name);
            if (_loadedCar != null)
            {
                Console.WriteLine(" loadedCarName : " + _loadedCar.Name);
            }
            else
            {
                Console.WriteLine(" loadedCarName : noCarWaiting");
            }
        }
    }


    public static void Main()
    {
        //var car = new Car("Toyota");
        //Console.WriteLine(car.Name);

        //var shorenorth = new Shore("North Side");
        //Console.WriteLine(shorenorth.Name);

        //var shoresouth = new Shore("South Side");
        //Console.WriteLine(shoresouth.Name);

        //var ferry = new Ferry("Titanic");
        //Console.WriteLine(ferry.Name);

        ////THE CAR IN THE FERRY IS NOT PRESENT  (NULL)
        //var whenNullCar = ferry.loadedCar;

        ////WE ADD THE CAR TO THE FERRY
        //ferry.loadedCar = car;
        //var whenNotNullCar = ferry.loadedCar;
        //Console.WriteLine("The car inside the ferry " + ferry.loadedCar.Name);
        //Console.WriteLine("The car inside the ferry in another var (pointer) " + whenNotNullCar.Name);
        //Console.ReadLine();



        // # 1 Create Cars
        var toyotaCarEast = new Car("toyotaEast");
        var toyotaCarWest = new Car("toyotaWest");

        // # 2 Create Shores

        var eastShore = new Shore("east");
        var westShore = new Shore("west");

        // # 3 Create Ferry

        var uniqueFerry = new Ferry("Unique");

        // # 4 time 0 ALL Objects just created
        Console.WriteLine("###################################################");
        Console.WriteLine("time 0");
        Console.WriteLine("###################################################");
        toyotaCarEast.print();
        toyotaCarWest.print();
        eastShore.print();
        westShore.print();
        uniqueFerry.print();

        Console.ReadLine();

        // # 5 time 1 Car arrive to the shore and Ferry arrives to the west Shore

        Console.WriteLine("###################################################");
        Console.WriteLine("time 1");
        Console.WriteLine("###################################################");
        //cars Arrives
        westShore.waitingCar = toyotaCarWest;
        eastShore.waitingCar = toyotaCarEast;
        //Ferry arrive
        westShore.waitingFerry = uniqueFerry;
        toyotaCarEast.print();
        toyotaCarWest.print();
        eastShore.print();
        westShore.print();
        uniqueFerry.print();

        Console.ReadLine();

        // # 6 time 2 westCar is loaded to the ferry and westShore Remains empty of car

        Console.WriteLine("###################################################");
        Console.WriteLine("time 2");
        Console.WriteLine("###################################################");

        //load the car to the ferry
        uniqueFerry.loadedCar = westShore.waitingCar;
        //empty the westshore
        westShore.waitingCar = null;
        toyotaCarEast.print();
        toyotaCarWest.print();
        eastShore.print();
        westShore.print();
        uniqueFerry.print();

        Console.ReadLine();

        // # 7 time 3 Ferry travels to eastShore and westShore remains empty 

        Console.WriteLine("###################################################");
        Console.WriteLine("time 3");
        Console.WriteLine("###################################################");

        //move the ferry to the east
        eastShore.waitingFerry = uniqueFerry;
        //empty the westshore of ferry
        westShore.waitingFerry = null;

        toyotaCarEast.print();
        toyotaCarWest.print();
        eastShore.print();
        westShore.print();
        uniqueFerry.print();
        Console.ReadLine();
    }
}