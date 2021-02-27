using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
                new Car {CarId = 1, BrandId = 1, ColorId = 1, ModelYear=2015, DailyPrice = 100,  Descriptions = "Güzel araba" },
                new Car {CarId = 2, BrandId = 2, ColorId = 2, ModelYear=2016, DailyPrice = 200,  Descriptions = "Renkli araba" },
                new Car {CarId = 3, BrandId = 3, ColorId = 3, ModelYear=2017, DailyPrice = 300,  Descriptions = "Hızlı araba" },

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(deleteToCar);
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

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            updateToCar.CarId = car.CarId;
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId= car.ColorId ;
            updateToCar.DailyPrice= car.DailyPrice;
            updateToCar.Descriptions= car.Descriptions;
            updateToCar.ModelYear= car.ModelYear;
        }
    }
}
