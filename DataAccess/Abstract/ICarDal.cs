using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        // Entities referansı DA katmanına eklendi.
        List<Car> GetAll(); // Tüm arabaları listeleme

        List<Car> GetById(int carId); // carId'sine göre listeleme

        void Add(Car car); // Araba Ekleme
        void Update(Car car); // Araba Güncelleme
        void Delete(Car car); // Araba Silme

        List<Car> GellAllByBrandId(int brandId); // Marka Id'sine göre arabaları listele
        List<Car> GellAllByColorId(int colorId); // Color Id'sine göre arabaları listele

    }
}
