using System;
using System.Collections.Generic;
using System.Text;


public class Opdracht9
{
    //class parent
    public class Transport
    {
        private int _tires;
        public int Tires
        {
            get
            {
                return _tires;
            }
            set
            {
                this._tires = value;
            }
        }

        private string _power;
        public string Power
        {
            get
            {
                return _power;
            }
            set
            {
                this._power = value;
            }
        }

        private int _maxperson;
        public int MaxPerson
        {
            get
            {
                return _maxperson;
            }
            set
            {
                this._maxperson = value;
            }
        }

        private int _weight;
        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                this._weight = value;
            }
        }

        public string ObjectType
        {
            get
            {
                return _objectType;
            }

            set
            {
                _objectType = value;
            }
        }

        private string _objectType;

        public void printbase()
        {
            Console.WriteLine("object Type: " + ObjectType);
            Console.WriteLine("Number of tires: " + Tires);
            Console.WriteLine("Human or Motor power: " + Power);
            Console.WriteLine("Maximum passengers: " + MaxPerson);
            Console.WriteLine("Weight of the object: " + Weight);

        }
    }


    //class child of Transport
    public class Bicycle : Transport
    {
        private int _height;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                this._height = value;
            }
        }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                this._color = value;
            }
        }

        public void printbicycle()
        {
            Console.WriteLine("Height of the object: " + Height);
            Console.WriteLine("Color of the object: " + Color);
        }
    }

    //class child of Bicycle
    public class RaceBicycle : Bicycle
    {
        private int _gears;
        public int Gears
        {
            get
            {
                return _gears;
            }
            set
            {
                this._gears = value;
            }
        }

        private string _lights;
        public string Lights
        {
            get
            {
                return _lights;
            }
            set
            {
                this._lights = value;
            }
        }

        public void printracebicycle()
        {
            Console.WriteLine("Number of gears: " + Gears);
            Console.WriteLine("Does the object have lights: " + Lights);
        }
    }



    public class Car : Transport
    {
        private string _brand;
        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                this._brand = value;
            }
        }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                this._color = value;
            }
        }
        public void printcar()
        {
            Console.WriteLine("Brand of the object: " + Brand);
            Console.WriteLine("Color of the object: " + Color);
        }
    }

    public class RaceCar : Car
    {
        private int _maxspeed;
        public int MaxSpeed
        {
            get
            {
                return _maxspeed;
            }
            set
            {
                this._maxspeed = value;
            }
        }

        private int _horsepower;
        public int HorsePower
        {
            get
            {
                return _horsepower;
            }
            set
            {
                this._horsepower = value;
            }
        }

        public void printracecar()
        {
            Console.WriteLine("Maximum speed of the object: " + MaxSpeed);
            Console.WriteLine("Horse power of the object: " + HorsePower);
        }
    }


    public static void Main()
    {
        //create vars
        RaceBicycle bicycle1 = new RaceBicycle();
        bicycle1.Tires = 2;
        bicycle1.Power = "human power";
        bicycle1.MaxPerson = 2;
        bicycle1.Weight = 30;
        bicycle1.Height = 50;
        bicycle1.Color = "red";
        bicycle1.Gears = 21;
        bicycle1.Lights = "yes";

        RaceBicycle bicycle2 = new RaceBicycle();
        bicycle2.Tires = 2;
        bicycle2.Power = "human power";
        bicycle2.MaxPerson = 2;
        bicycle2.Weight = 35;
        bicycle2.Height = 55;
        bicycle2.Color = "blue";
        bicycle2.Gears = 6;
        bicycle2.Lights = "no";

        RaceBicycle bicycle3 = new RaceBicycle();
        bicycle3.Tires = 2;
        bicycle3.Power = "human power";
        bicycle3.MaxPerson = 2;
        bicycle3.Weight = 33;
        bicycle3.Height = 57;
        bicycle3.Color = "black";
        bicycle3.Gears = 3;
        bicycle3.Lights = "yes";

        RaceCar car1 = new RaceCar();
        car1.Tires = 4;
        car1.Power = "motor power";
        car1.MaxPerson = 4;
        car1.Weight = 700;
        car1.Brand = "Kia";
        car1.Color = "black";
        car1.MaxSpeed = 160;
        car1.HorsePower = 90;

        RaceCar car2 = new RaceCar();
        car2.Tires = 4;
        car2.Power = "motor power";
        car2.MaxPerson = 4;
        car2.Weight = 800;
        car2.Brand = "Volkswagen";
        car2.Color = "blue";
        car2.MaxSpeed = 180;
        car2.HorsePower = 110;

        RaceCar car3 = new RaceCar();
        car3.Tires = 4;
        car3.Power = "motor power";
        car3.MaxPerson = 4;
        car3.Weight = 1100;
        car3.Brand = "BMW";
        car3.Color = "red";
        car3.MaxSpeed = 230;
        car3.HorsePower = 150;

        //print vars
        bicycle1.printbase();
        bicycle1.printbicycle();
        bicycle1.printracebicycle();

        Console.WriteLine();
        Console.WriteLine("######################################");
        Console.WriteLine();

        bicycle2.printbase();
        bicycle2.printbicycle();
        bicycle2.printracebicycle();

        Console.WriteLine();
        Console.WriteLine("######################################");
        Console.WriteLine();

        bicycle3.printbase();
        bicycle3.printbicycle();
        bicycle3.printracebicycle();

        Console.WriteLine();
        Console.WriteLine("######################################");
        Console.WriteLine();

        car1.printbase();
        car1.printcar();
        car1.printracecar();

        Console.WriteLine();
        Console.WriteLine("######################################");
        Console.WriteLine();

        car2.printbase();
        car2.printcar();
        car2.printracecar();

        Console.WriteLine();
        Console.WriteLine("######################################");
        Console.WriteLine();

        car3.printbase();
        car3.printcar();
        car3.printracecar();

        Console.WriteLine();
        Console.WriteLine("######################################");
        Console.WriteLine();

        Transport[] transportvehicles = new Transport[6];
        transportvehicles[0] = car1;
        transportvehicles[1] = car2;
        transportvehicles[2] = car3;
        transportvehicles[3] = bicycle1;
        transportvehicles[4] = bicycle2;
        transportvehicles[5] = bicycle3;


        var heaviesttranportresult = heaviesttransport(transportvehicles);
        Console.WriteLine(heaviesttranportresult.Weight);


        Console.ReadLine();
    }
    public static Transport heaviesttransport(Transport[] transportvehicles)
    {
        Transport heaviest = null;
        for (int i = 0; i < transportvehicles.Length; i++)
        {
            if (heaviest == null || heaviest.Weight < transportvehicles[i].Weight)
            {
                heaviest = transportvehicles[i];
            }
        }
        return heaviest;
    }
}