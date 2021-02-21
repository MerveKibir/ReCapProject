using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rentals rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            //var lastRental = result.LastOrDefault();

            //if (lastRental.ReturnDate == null)
            //{
            //    return new ErrorResult(Messages.RentalAddFailed);
            //}
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetail()
        {
            return new DataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetail(),true ,Messages.RentalsListed);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            var result = _rentalDal.GetAll();
            
            return new SuccessDataResult<List<Rentals>>(result, Messages.RentalsListed);
        }

        public IDataResult<List<Rentals>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll(r => r.CarId == carId));
        }

        public IResult UpdateReturnDate(int carId)
        {
            var result = _rentalDal.GetAll(r => r.CarId == carId);
            var rentalToUpdate = result.LastOrDefault();

            if (rentalToUpdate.ReturnDate != null)
            {
                return new ErrorResult(Messages.RentalUpdateFailed);
            }

            rentalToUpdate.ReturnDate = DateTime.Now;
            _rentalDal.Update(rentalToUpdate);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
