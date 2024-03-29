﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetByBrandId(int BrandId);
        List<Car> GetAll();
        void Add(Car car);
        void Remove(Car car);
        void Update(Car car);
    }
}
