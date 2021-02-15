using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Id     Model         Fiyat Listesi            Açıklama");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "      " + car.ModelYear + "           " + car.DailyPrice + "         " + car.Description);
            }

            Console.WriteLine("\n\nBrandId'si 2 Olan Araçların Listelenmesi");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("\n\nColorId'si 3 Olan Araçların Listelenmesi");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("\n\nFiyat Listesi 0 ile 950.000 Arasında Olan Araçların Listelenmesi");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var car in carManager.GetByDailyPrice(0,950000))
            {
                Console.WriteLine(car.DailyPrice);
            }

            Console.WriteLine("\n\nYeni Eklenen Araç Listesi");
            Console.WriteLine("--------------------------------------------------------------------");
            List<Car> cars = new List<Car>();
            cars.Add(new Car () { Id= 10, BrandId=10, ColorId=10, ModelYear=2010, Description=" GOLF", DailyPrice=100000 });
            cars.Add(new Car()  { Id = 11, BrandId = 11, ColorId = 11, ModelYear = 2018, Description = "ASTON MARTIN", DailyPrice = 2650000 });
           

            Console.WriteLine("Id      Model              Fiyat Listesi             Açıklama");
            Console.WriteLine("--------------------------------------------------------------------");

            foreach (var car in cars)
            {              
                Console.WriteLine(car.Id + "      " + car.ModelYear + "                 " + car.DailyPrice + "                 " + car.Description );
            }
        }
    }
}