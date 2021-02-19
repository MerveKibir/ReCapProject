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
                             on r.CarId equals c.Id
                             join u in context.Users
                             on r.CustomerId equals u.UserId
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
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
