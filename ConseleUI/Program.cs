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
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentalId = 1,
                RentDate = DateTime.Today,
               ReturnDate = DateTime.Today.AddDays(3)
            });
          
            
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer
            //{
            //    UserId = 1,
            //    CustomerId=1,
            //    CompanyName="mkc"
            //});
            UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User
            //{
            //    FirstName = "Musa",
            //    LastName = "COŞKUN",
            //    UserId = 1,
            //    Email = "asdasdasd@gmail.com",
            //    Password="123456"
            //});
            CarManager carManager = new CarManager(new EfCarDal());
            var carResult = carManager.GetCarDetails();
            if (carResult.Success == true)
            {
                foreach (var car in carResult.Data)
                {
                    Console.WriteLine("{0}--{1}--{2}---{3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }


            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { ColorName="Mavi",ColorId=3});
            //colorManager.Delete(new Color { ColorId = 3, ColorName = "Mavi" });
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine("ColorId:{0}----ColorName:{1}", color.ColorId, color.ColorName);
                }
            }


            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand
            //{
            //    BrandId=3,
            //    BrandName="BMW"
            //});
            var brandResult = brandManager.GetAll();
            if (brandResult.Success == true)
            {
                foreach (var brand in brandResult.Data)
                {
                    Console.WriteLine("BrandId:{0}------BrandName:{1}", brand.BrandId, brand.BrandName);
                }

            }


        }

        
    }
}
