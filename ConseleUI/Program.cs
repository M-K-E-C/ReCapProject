using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConseleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }

            Car car1 = new Car();
            car1.Id = 3;
            car1.Description = "m";
            car1.DailyPrice = 120;

            Car car2 = new Car();
            car2.Id = 4;
            car1.Description = "bmw";
            car2.DailyPrice = -5;
            carManager.Add(car1);
            carManager.Add(car2);
            
        }
    }
}
