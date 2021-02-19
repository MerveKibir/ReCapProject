using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rentals rental);
        IResult UpdateReturnDate(int carId);
        IDataResult<List<Rentals>> GetAll();
        IDataResult<List<Rentals>> GetByCarId(int carId);
        IDataResult<List<RentalDetailDto>> GetRentalDetail();
       
    }
}
