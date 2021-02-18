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
            _cars = new List<Car> { 
                new Car{BrandId = 1, ColorId = 1, ModelYear = 2017, DailyPrice = 185000, Description = "Toyota Corolla", Id = 1},
                new Car{BrandId = 2, ColorId = 1, ModelYear = 2016, DailyPrice = 750000, Description = "Mercedes C 180", Id = 2},
                new Car{BrandId = 3, ColorId = 2, ModelYear = 2019, DailyPrice = 805000, Description = "BMW 3.20i", Id = 3},
                new Car{BrandId = 4, ColorId = 4, ModelYear = 2016, DailyPrice = 530000, Description = "Jaguar XE 2.0D R-SPORT", Id = 4},
                new Car{BrandId = 5, ColorId = 5, ModelYear = 2006, DailyPrice = 600000, Description = "Honda S2000", Id = 5}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
        }
    }
}
