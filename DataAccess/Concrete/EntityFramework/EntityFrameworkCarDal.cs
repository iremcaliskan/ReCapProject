using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EntityFrameworkCarDal : ICarDal
    {
        List<Car> _cars;
        public EntityFrameworkCarDal()
        {
            _cars = new List<Car>()
            {
                new Car(){BrandId = 1, ColorId = 1, DailyPrice = 375000, ModelYear = "2014", Description = "BMW 320D M Sport Otomatik HATASIZ - BOYASIZ - TRAMERSİZ" },
                new Car(){BrandId = 2, ColorId = 1, DailyPrice = 152250, ModelYear = "2013", Description = "Volkswagen Polo 1.6 TDI Comfortline, Dizel Otomatik" },
                new Car(){BrandId = 3, ColorId = 2, DailyPrice = 186500, ModelYear = "2015", Description = "Honda Civic 1.6i VTEC Eco Elegance, Benzin/LPG Otomatik" }
            };
        }
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GellAllByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GellAllByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
