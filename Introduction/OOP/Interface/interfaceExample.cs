using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP.Interface
{
    /*
        في سي شارب لا يوجد ملتي انهريتنس للكلاسات
        ولكن موجود للانترفيسيس
     */
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public Vehicle(string Brand, string Model, int Year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Year = Year;
        }
        protected Vehicle()
        {
            
        }
    }

    public class Honda : Vehicle
    {
        public Honda(string Brand, string Model, int Year) : base (Brand, Model, Year)
        {

        }
        public Honda()
        {
            
        }
    }

    public interface IDrivable
    {
        void Move();
        void Stop();
    }

    public interface ILoader
    {
        void Load();
        void Unload();
    }

    public class Caterpillar : Vehicle, ILoader, IDrivable 
    {
        public Caterpillar(string Brand, string Model, int Year) : base(Brand, Model, Year)
        {

        }

        public void Load()
        {
            Console.WriteLine("load...");
        }

        public void Unload()
        {
            Console.WriteLine("unload...");
        }

        public void Move()
        {
            Console.WriteLine("move");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }

    public class interfaceExample
    {
        public static void run()
        {
            //Vehicle v = new Vehicle(); error, we cannot create instance from abstract class
            Vehicle vObj = new Honda();

            vObj.Brand = "BMW";
            vObj.Model = "JEEP";
            vObj.Year = 2022;

            Console.WriteLine(vObj.GetType());
            Console.WriteLine($@"{vObj.Brand}
{vObj.Model}
{vObj.Year}
");


            Caterpillar c = new Caterpillar("BMW", "Normal", 2020);
            c.Load();
            
        }

    }
}
