using System;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IAccountService
    {
        IDataResult<List<Account>> GetAll();
        IResult Add(Account account);
        IResult Update(Account account);
        IResult Delete(Account account);
    }
}

