using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car {Id=1, BrandId=1, ColorId=4, DailyPrice=1500, Description="Ford", ModelYear=2018},
                new Car {Id=2, BrandId=2, ColorId=4, DailyPrice=1200, Description="Fiat", ModelYear=2017},
                new Car {Id=3, BrandId=2, ColorId=1, DailyPrice=500, Description="Mercedes-Bend", ModelYear=2003},
                new Car {Id=4, BrandId=1, ColorId=1, DailyPrice=700, Description="Cadillac", ModelYear=2005},
                new Car {Id=5, BrandId=4, ColorId=1, DailyPrice=900, Description="Audi", ModelYear=2016},
                new Car {Id=6, BrandId=1, ColorId=4, DailyPrice=100, Description="BMW", ModelYear=2000},
                new Car {Id=7, BrandId=3, ColorId=3, DailyPrice=1200, Description="Maserati", ModelYear=2017},
                new Car {Id=8, BrandId=1, ColorId=4, DailyPrice=150, Description="Hyundai", ModelYear=2008}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
