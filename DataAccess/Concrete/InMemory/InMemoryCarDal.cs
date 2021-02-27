using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car {CarId =1,ColorId=1,DailyPrice = 100000,ModelYear = 2010,Description ="Benzin-Lpg",BrandId =1},
                new Car {CarId =2,ColorId=1,DailyPrice = 120000,ModelYear = 2015,Description ="Benzin-Lpg-Otomatik" ,BrandId =2},
                new Car { CarId = 3, ColorId = 2, DailyPrice = 135000, ModelYear = 2018, Description = "Dizel-Manuel",BrandId = 3},
                new Car {CarId =4,ColorId=2,DailyPrice = 200000,ModelYear = 2019,Description ="Benzin" ,BrandId = 2},
                new Car {CarId =5,ColorId=3,DailyPrice = 155000,ModelYear = 2020,Description ="Dizel-otomatik" ,BrandId = 3},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId) ;
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToupdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToupdate.ColorId = car.ColorId;
            carToupdate.DailyPrice = car.DailyPrice;
            carToupdate.Description= car.Description;
            carToupdate.ModelYear = car.ModelYear;

            

        }
    }
}
