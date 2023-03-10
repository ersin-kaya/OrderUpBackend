using System;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStatusDal : EfEntityRepositoryBase<Status, OrderUpContext>, IStatusDal
    {
    }
}

