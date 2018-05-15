using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolcanStudy3
{
    class opdracht1a
    {
        public abstract class Shape
        {
            public string Sort { get; set; }
            public string Name { get; set; }
            public double Riblength { get; set; }

            public Shape()
            {
                Riblength = 1;
            }

            public Shape(string name)
            {
                Riblength = 1;
            }
            public Shape(string name, double riblength)
            {

                this.Riblength = riblength;
            }
            public abstract double Volume();
            public abstract double Surface();

            public virtual void Printbase()
            {
                Console.WriteLine($"Soort is: {Sort}");
                Console.WriteLine($"Riblengte is: {Riblength}");
            }
        }

        public class Kubus : Shape
        {

            public Kubus(string name, double riblength)
            {
                Sort = "kubus";
                this.Name = name;
                this.Riblength = riblength;
            }

            public override double Volume()
            {
                return Riblength * Riblength * Riblength;
            }

            public override double Surface()
            {
                return 6 * Riblength * Riblength;
            }

            public override void Printbase()
            {
                base.Printbase();
                Console.WriteLine("Naam is: " + Name);
                Console.WriteLine("Inhoud van " + Sort + " is: {0}", Volume());
                Console.WriteLine("Oppervlakte van " + Sort + " is: {0}", Surface());


            }
        }

        public class Tetraeder : Shape
        {
            public Tetraeder(string name, double riblength)
            {
                Sort = "tetraeder";
                this.Name = name;
                this.Riblength = riblength;
            }

            public override double Volume()
            {
                double a = Math.Pow((Riblength / 2), 2);
                double b = Math.Pow(Riblength, 2);
                double c = b - a;
                double d = Math.Sqrt(c);
                double e = (Riblength * d) / 2;
                double f = 4 * e;
                return f;
            }

            public override double Surface()
            {
                return 6 * Riblength * Riblength * Riblength;
            }

            public override void Printbase()
            {
                base.Printbase();
                Console.WriteLine("Naam is: " + Name);
                Console.WriteLine("Inhoud van " + Sort + " is: {0}", Volume());
                Console.WriteLine("Oppervlakte van " + Sort + " is: {0}", Surface());
            }
        }

        public class Researcher
        {


            private Boolean Check(Shape[] shapes)
            {
                foreach (var shape in shapes)
                {
                    if (shape == null)
                    {
                        return false;
                    }
                }
                return true;
            }
            public void Maxvolume(Shape[] shapes)
            {
                if (Check(shapes))
                {
                    double maxVolume = 0;
                    string maxVolumeObject = "";
                    foreach (var shape in shapes)
                    {

                        if (shape.Volume() > maxVolume)
                        {
                            maxVolume = shape.Volume();
                            maxVolumeObject = shape.Name;
                        }
                    }
                    Console.WriteLine(" MAX volume = " + maxVolume + " Name = " + maxVolumeObject);
                }
                else
                {
                    Console.WriteLine("not valid Array");
                }

            }

            public void Minsurface(Shape[] shapes)
            {

                if (Check(shapes))
                {
                    double minSurface = 99999999999999;
                    string minSurfaceObject = "";
                    foreach (var shape in shapes)
                    {
                        if (shape.Surface() < minSurface)
                        {
                            minSurface = shape.Surface();
                            minSurfaceObject = shape.Name;
                        }
                    }
                    Console.WriteLine(" MIN surface = " + minSurface + " Name = " + minSurfaceObject);
                }
                else
                {
                    Console.WriteLine("not valid Array");
                }
            }
        }

        public static void Main()
        {
            Shape[] shapes = { new Kubus("Kubus 1", 3), new Tetraeder("Tetraeder 1", 8), new Kubus("Kubus 2", 5) };
            Shape[] shapesNull = { new Kubus("Kubus 1", 3), new Tetraeder("Tetraeder 1", 8), new Kubus("Kubus 2", 5) , null};
            Researcher testResearcher = new Researcher();

            testResearcher.Maxvolume(shapes);
            testResearcher.Minsurface(shapesNull);
            foreach (Shape i in shapes)
            {
                i.Printbase();
                Console.WriteLine("-----------------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
