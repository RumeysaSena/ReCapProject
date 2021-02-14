using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=2, ColorId=3, Description="BMW 8 SERİSİ GRAN COUPÉ", ModelYear= 2019 , DailyPrice= 3523000 },
                new Car{Id=2, BrandId=3, ColorId=4, Description="BMW iX3", ModelYear= 2021 , DailyPrice= 950000 },
                new Car{Id=3, BrandId=4, ColorId=5, Description="BMW M235i xDRIVE GRAN COUPÉ", ModelYear= 2020 , DailyPrice= 1002900 },
                new Car{Id=4, BrandId=5, ColorId=6, Description="AUDİ A5 SPORTBACK", ModelYear= 2020 , DailyPrice= 932711 },
                new Car{Id=5, BrandId=6, ColorId=7, Description="AUDİ Q5 40 TDI", ModelYear= 2020 , DailyPrice= 933301 },
                new Car{Id=6, BrandId=7, ColorId=8, Description="AUDİ Q8 50 TDI", ModelYear= 2020 , DailyPrice= 1989493 },

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id == Id ).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;

        }
    }
}
