using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2019, Description="CAR", DailyPrice= 3523000},
                new Car{Id=2, BrandId=2, ColorId=2, ModelYear=2021, Description="CAR", DailyPrice= 950000 },
                new Car{Id=3, BrandId=3, ColorId=3, ModelYear=2020, Description="CAR", DailyPrice= 1002900 },
                new Car{Id=4, BrandId=4, ColorId=4, ModelYear=2020, Description="CAR", DailyPrice= 932711 },
                new Car{Id=5, BrandId=5, ColorId=5, ModelYear=2020, Description="CAR", DailyPrice= 933301 },
                new Car{Id=6, BrandId=6, ColorId=6, ModelYear=2020, Description="CAR", DailyPrice= 1989493 },  
                new Car{Id=7, BrandId=7, ColorId=7, ModelYear=1982, Description="CAR", DailyPrice= 850000 },
                new Car{Id=8, BrandId=8, ColorId=8, ModelYear=1967, Description="CAR", DailyPrice= 1000000 },
                new Car{Id=9, BrandId=9, ColorId=9, ModelYear=1926, Description="CAR", DailyPrice= 2000000 },
                
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
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
