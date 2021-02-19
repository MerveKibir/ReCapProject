using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customers customer);
        IResult Update(Customers customer);
        IResult Delete(Customers customer);
        IDataResult<List<Customers>> GetAll();
        IDataResult<Customers> GetById(int customerId);
    }
}
