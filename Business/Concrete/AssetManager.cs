using System;
using Business.Abstract;
using Business.Constants.Messages.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AssetManager : IAssetService
    {
        IAssetDal _assetDal;

        public AssetManager(IAssetDal assetDal)
        {
            _assetDal = assetDal;
        }

        public IResult Add(Asset asset)
        {
            _assetDal.Add(asset);
            return new SuccessResult(Messages.AssetAdded);
        }

        public IResult Delete(Asset asset)
        {
            _assetDal.Delete(asset);
            return new SuccessResult(Messages.AssetDeleted);
        }

        public IDataResult<List<Asset>> GetAll()
        {
            return new SuccessDataResult<List<Asset>>(_assetDal.GetAll(), Messages.AssetsListed);
        }

        public IResult Update(Asset asset)
        {
            _assetDal.Update(asset);
            return new SuccessResult(Messages.AssetUpdated);
        }
    }
}

