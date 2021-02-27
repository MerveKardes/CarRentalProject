using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
           
            rentalManager.Add(2);
           
             //CarTest();

            // BrandTest();

             // ColorTest();

        }

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);
        //    }
        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    foreach (var brands in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brands.BrandName);
        //    }
        //}

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                 foreach (var car in result.Data)
                   {
                      Console.WriteLine(car.CarId+" "+car.BrandName+" "+car.ColorName+" "+car.DailyPrice);
                   }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }
    }
}
