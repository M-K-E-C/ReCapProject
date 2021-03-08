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

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0}--{1}--{2}---{3}",car.CarName,car.BrandName,car.ColorName,car.DailyPrice);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { ColorName="Mavi",ColorId=3});
            //colorManager.Delete(new Color { ColorId = 3, ColorName = "Mavi" });

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("ColorId:{0}----ColorName:{1}",color.ColorId,color.ColorName);
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand
            //{
            //    BrandId=3,
            //    BrandName="BMW"
            //});
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("BrandId:{0}------BrandName:{1}",brand.BrandId,brand.BrandName);
            }

            
        }
    }
}
