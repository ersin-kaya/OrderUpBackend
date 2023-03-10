using System;
using Business.Abstract;
using Business.Constants.Messages.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StatusManager : IStatusService
    {
        IStatusDal _statusDal;

        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public IResult Add(Status status)
        {
            _statusDal.Add(status);
            return new SuccessResult(Messages.StatusAdded);
        }

        public IResult Delete(Status status)
        {
            _statusDal.Delete(status);
            return new SuccessResult(Messages.StatusDeleted);
        }

        public IDataResult<List<Status>> GetAll()
        {
            return new SuccessDataResult<List<Status>>(_statusDal.GetAll(), Messages.StatusesListed);
        }

        public IResult Update(Status status)
        {
            _statusDal.Update(status);
            return new SuccessResult(Messages.StatusUpdated);
        }
    }
}

