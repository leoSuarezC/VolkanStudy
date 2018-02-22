using System;
using System.Collections.Generic;
using System.Text;

public class Opdracht5a
{
    public class Car
    {
        public string licenceplate { get; set; }
        public int doors { get; set; }
        public string color { get; set; }
        public string brand { get; set; }
        public string type { get; set; }
        public int maxspeed { get; set; }
    }

    public static void Main()
    {
        Car car1 = new Car();
        car1.licenceplate = "83-NR-SZ";
        car1.doors = 2;
        car1.color = "Blue";
        car1.brand = "Toyota";
        car1.type = "Yaris";
        car1.maxspeed = 160;

        Car car2 = new Car();
        car2.licenceplate = "12-KF-SA";
        car2.doors = 4;
        car2.color = "Black";
        car2.brand = "Opel";
        car2.type = "Corsa";
        car2.maxspeed = 150;

        Car car3 = new Car();
        car3.licenceplate = "KD-555-S";
        car3.doors = 4;
        car3.color = "Silver";
        car3.brand = "BMW";
        car3.type = "M3";
        car3.maxspeed = 290;

        Car car4 = new Car();
        car4.licenceplate = "DF-324-D";
        car4.doors = 4;
        car4.color = "White";
        car4.brand = "Daihatsu";
        car4.type = "Cuore";
        car4.maxspeed = 140;

        Car car5 = new Car();
        car5.licenceplate = "EVC-34-DF";
        car5.doors = 4;
        car5.color = "Green";
        car5.brand = "Volkswagen";
        car5.type = "Golf";
        car5.maxspeed = 130;

        Car[] cars = new Car[5];
        cars[0] = car1;
        cars[1] = car2;
        cars[2] = car3;
        cars[3] = car4;
        cars[4] = car5;

        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine("licenceplate:" + cars[i].licenceplate);
            Console.WriteLine("doors: " + cars[i].doors);
            Console.WriteLine("color: " + cars[i].color);
            Console.WriteLine("brand: " + cars[i].brand);
            Console.WriteLine("type:" + cars[i].type);
            Console.WriteLine("maxspeed: " + cars[i].maxspeed);
            Console.WriteLine("----------");
        }

        var fastestCarResult = fastestCar(cars);
        Console.WriteLine("fastest car is " + fastestCarResult.licenceplate + "speed: " + fastestCarResult.maxspeed);

        Console.ReadLine();
    }

    public static Car fastestCar(Car[] cars)
    {
        int hoogste = 0;
        int indexCarMaxSpeed = 0;
        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i].maxspeed > hoogste)
            {
                hoogste = cars[i].maxspeed;
                indexCarMaxSpeed = i;
            }
        }
        return cars[indexCarMaxSpeed];
    }
}

