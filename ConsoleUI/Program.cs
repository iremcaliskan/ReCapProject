using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
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
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("\n---------------\n");

            CarManager carManager1 = new CarManager(new EntityFrameworkCarDal());

            foreach (var car in carManager1.GetAll())
                Console.WriteLine(car.Description);
            }
        }
    }

