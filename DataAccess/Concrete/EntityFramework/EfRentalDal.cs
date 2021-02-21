using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rentals, RentACarContext>, IRentalDal
    {

        public List<RentalDetailDto> GetRentalDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = new List<RentalDetailDto>(
                             from r in context.Rentals
                             join c in context.Car
                             on r.CarId equals c.CarId
                             join u in context.Users
                             on r.CustomerId equals u.Id
                             join b in context.Brand
                             on c.BrandId equals b.BrandID
                             select new RentalDetailDto
                             {
                                 RentalId = r.Id,
                                 BrandName = b.BrandName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             });
                return result.ToList();
            }
        }


    }
}
