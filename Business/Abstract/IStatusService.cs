using System;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IStatusService
    {
        IDataResult<List<Status>> GetAll();
        IResult Add(Status status);
        IResult Update(Status status);
        IResult Delete(Status status);
    }
}

