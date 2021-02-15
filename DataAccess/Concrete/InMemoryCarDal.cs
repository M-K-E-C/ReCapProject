using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id =1,ColorId=1,DailyPrice = 100000,ModelYear = 2010,Decsription ="Benzin-Lpg",BrandId =1},
                new Car {Id =2,ColorId=1,DailyPrice = 120000,ModelYear = 2015,Decsription ="Benzin-Lpg-Otomatik" ,BrandId =2},
                new Car { Id = 3, ColorId = 2, DailyPrice = 135000, ModelYear = 2018, Decsription = "Dizel-Manuel",BrandId = 3},
                new Car {Id =4,ColorId=2,DailyPrice = 200000,ModelYear = 2019,Decsription ="Benzin" ,BrandId = 2},
                new Car {Id =5,ColorId=3,DailyPrice = 155000,ModelYear = 2020,Decsription ="Dizel-otomatik" ,BrandId = 3},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id) ;
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToupdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToupdate.ColorId = car.ColorId;
            carToupdate.DailyPrice = car.DailyPrice;
            carToupdate.Decsription= car.Decsription;
            carToupdate.ModelYear = car.ModelYear;

            

        }
    }
}
