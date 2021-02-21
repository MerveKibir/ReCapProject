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
                new Car {CarId=1, BrandId=1, ColorId=4, DailyPrice=1500, Descriptions="Ford", ModelYear=2018},
                new Car {CarId=2, BrandId=2, ColorId=4, DailyPrice=1200, Descriptions="Fiat", ModelYear=2017},
                new Car {CarId=3, BrandId=2, ColorId=1, DailyPrice=500, Descriptions="Mercedes-Bend", ModelYear=2003},
                new Car {CarId=4, BrandId=1, ColorId=1, DailyPrice=700, Descriptions="Cadillac", ModelYear=2005},
                new Car {CarId=5, BrandId=4, ColorId=1, DailyPrice=900, Descriptions="Audi", ModelYear=2016},
                new Car {CarId=6, BrandId=1, ColorId=4, DailyPrice=100, Descriptions="BMW", ModelYear=2000},
                new Car {CarId=7, BrandId=3, ColorId=3, DailyPrice=1200, Descriptions="Maserati", ModelYear=2017},
                new Car {CarId=8, BrandId=1, ColorId=4, DailyPrice=150, Descriptions="Hyundai", ModelYear=2008}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
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
            return _cars.Where(c => c.CarId == Id).ToList();
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
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
