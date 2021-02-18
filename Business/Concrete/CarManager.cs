using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            Car carToFind = _carDal.GetById(car.Id);
            if (carToFind != null)
            {
                Console.WriteLine("\nCar already exists with this id.\n");
            }
            else
            {
                _carDal.Add(car);
                Console.WriteLine("\nCar added to the list." + car.Description + "\n");
            }
        }

        public void Delete(Car car)
        {
            if (_carDal.GetAll().Count == 0)
            {
                Console.WriteLine("\nNo car in the list.\n");
            }
            else
            {
                _carDal.Delete(car);
            }
        }

        public Car GetById(int Id)
        {
            return _carDal.GetById(Id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
