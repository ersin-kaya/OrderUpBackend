using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfTypeDal : EfEntityRepositoryBase<Entities.Concrete.Type, OrderUpContext>, ITypeDal
	{
	}
}

