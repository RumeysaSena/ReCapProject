using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int Id);
        List<Car> GetCarsByColorId(int Id);
        List<Car> GetByDailyPrice(int min, int max);
        List<CarDetailDto> GetCarDetails();

    }
}
