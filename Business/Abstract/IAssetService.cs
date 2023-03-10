using System;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IAssetService
    {
        IDataResult<List<Asset>> GetAll();
        IResult Add(Asset asset);
		IResult Update(Asset asset);
		IResult Delete(Asset asset);
	}
}

