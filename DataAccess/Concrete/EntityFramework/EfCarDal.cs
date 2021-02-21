using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = new List<CarDetailDto>();
                var results = from car in context.Car
                             join brand in context.Brand
                             on car.BrandId equals brand.BrandID
                             join color in context.Color
                             on car.ColorId equals color.ColorId 
                             select new CarDetailDto
                             {
                                 Description = car.Descriptions,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 ColorName = color.ColorName
                             };
                result = results.ToList();
                return result;
            }
        }
    }
}
