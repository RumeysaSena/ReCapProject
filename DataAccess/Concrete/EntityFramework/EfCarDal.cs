using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join abc in context.Colors
                             on c.ColorId equals abc.ColorId
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = abc.ColorName,
                                 DailyPrice = c.DailyPrice,
                                
                             };
                
                return result.ToList();

            }
        }
    }
}