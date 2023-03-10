﻿using System;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ITypeService
    {
        IDataResult<List<Entities.Concrete.Type>> GetAll();
        IResult Add(Entities.Concrete.Type type);
        IResult Update(Entities.Concrete.Type type);
        IResult Delete(Entities.Concrete.Type type);
    }
}

