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
            _cars = new List<Car>() 
            {
                new Car(){Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 375000, ModelYear = "2014", Description = "BMW 320D M Sport Otomatik HATASIZ - BOYASIZ - TRAMERSİZ" },
                new Car(){Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 950000, ModelYear = "2020", Description = "BMW 5.20i LASERLIGHT FAR, OTONOM SÜRÜŞ MODU, SADECE 3750 KM" },
                new Car(){Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 152250, ModelYear = "2013", Description = "Volkswagen Polo 1.6 TDI Comfortline, Dizel Otomatik" },
                new Car(){Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 125100, ModelYear = "2011", Description = "Volkswagen Jetta 1.4 TSI Exclusive MANUEL 6 İLERİ EXCLUSIVE PAKET" },
                new Car(){Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 186500, ModelYear = "2015", Description = "Honda Civic 1.6i VTEC Eco Elegance, Benzin/LPG Otomatik" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        { // Silinecek eleman ile gönderilen elemanların Idleri aynı olmalı
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GellAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GellAllByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
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
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
