using System;
using Business.Abstract;
using Business.Constants.Messages.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class AccountManager : IAccountService
	{
        IAccountDal _accountDal;

		public AccountManager(IAccountDal accountDal)
		{
            _accountDal = accountDal;
		}

        public IResult Add(Account account)
        {
            _accountDal.Add(account);
            return new SuccessResult(Messages.AccountAdded);
        }

        public IResult Delete(Account account)
        {
            _accountDal.Delete(account);
            return new SuccessResult(Messages.AccountDeleted);
        }

        public IDataResult<List<Account>> GetAll()
        {
            return new SuccessDataResult<List<Account>>(_accountDal.GetAll(), Messages.AccountsListed);
        }

        public IResult Update(Account account)
        {
            _accountDal.Update(account);
            return new SuccessResult(Messages.AccountUpdated);
        }
    }
}

