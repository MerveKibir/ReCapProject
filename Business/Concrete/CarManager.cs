using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult AddedCar(Car car)
        {
            if (car.Descriptions.Length < 2 && car.DailyPrice < 0)
            {
                return new ErrorResult (Messages.CarNameAndDailyPriceInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }

        public IDataResult<List<Car>> GetAll()
        {
            if(DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>> (Messages.MaintanenceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new DataResult<List<CarDetailDto>> (_carDal.GetCarDetails(),true);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new DataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId), true);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new DataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId), true);
        }
    }
}
