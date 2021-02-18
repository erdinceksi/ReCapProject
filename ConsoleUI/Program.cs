using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id: {0}, Brand Id: {1}, ColorId: {2}, DailyPrice: {3}, Description: {4}, ModelYear: {5}",
                    car.Id, car.BrandId, car.ColorId, car.DailyPrice, car.Description, car.ModelYear);
            }

            carManager.Add(new Car { BrandId = 5, ColorId = 1, ModelYear = 2017, DailyPrice = 185000, Description = "Toyota Corolla", Id = 1 });

            Car carToDelete = carManager.GetById(1);
            carManager.Delete(carToDelete);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id: {0}, Brand Id: {1}, ColorId: {2}, DailyPrice: {3}, Description: {4}, ModelYear: {5}",
                    car.Id, car.BrandId, car.ColorId, car.DailyPrice, car.Description, car.ModelYear);
            }
        }
    }
}
