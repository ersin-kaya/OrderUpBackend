using System;
using Business.Abstract;
using Business.Constants.Messages.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class TypeManager : ITypeService
    {
        ITypeDal _typeDal;

        public TypeManager(ITypeDal typeDal)
        {
            _typeDal = typeDal;
        }

        public IResult Add(Entities.Concrete.Type type)
        {
            _typeDal.Add(type);
            return new SuccessResult(Messages.TypeAdded);
        }

        public IResult Delete(Entities.Concrete.Type type)
        {
            _typeDal.Delete(type);
            return new SuccessResult(Messages.TypeDeleted);
        }

        public IDataResult<List<Entities.Concrete.Type>> GetAll()
        {
            return new SuccessDataResult<List<Entities.Concrete.Type>>(_typeDal.GetAll(), Messages.TypesListed);
        }

        public IResult Update(Entities.Concrete.Type type)
        {
            _typeDal.Update(type);
            return new SuccessResult(Messages.TypeUpdated);
        }
    }
}

