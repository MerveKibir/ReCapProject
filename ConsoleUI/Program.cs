using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //BrandTest();
        }
            private static void BrandTest()
            {
                BrandManager brandManager = new BrandManager(new EfBrandDal());
                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }

            private static void CarTest()
                {
                    CarManager carManager = new CarManager(new EfCarDal());

                    var result = carManager.GetCarDetails();

                    if (result.Success == true)
                    {
                        foreach (var car in result.Data)
                        {
                            Console.WriteLine(car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice);
                        }
                    }
                    else
                    {
                        Console.WriteLine(result.Message);
                    }
                }
            //    CarManager carManager = new CarManager(new EfCarDal());
            //    ColorManager colorManager = new ColorManager(new EfColorDal());
            //    BrandManager brandManager = new BrandManager(new EfBrandDal());

            //    Console.WriteLine("Araç Kiralama Sistemine Hoşgeldiniz");
            //    bool secim = true;
            //    bool secimone = true;
            //    while (secim)
            //    {
            //        Console.WriteLine("Lütfen Aşağıdaki Menüden İşleminizi Seçiniz");
            //        Console.WriteLine("1-Araç İşlemleri");
            //        Console.WriteLine("2-Color İşlemleri");
            //        Console.WriteLine("3-Brand İşlemleri");
            //        Console.WriteLine("4-Çıkış");
            //        int sec = Convert.ToInt32(Console.ReadLine());
            //        switch (sec)
            //        {
            //            case 1:
            //                Console.ForegroundColor = ConsoleColor.Red;//Yazı rengini değiştir
            //                while (secimone)
            //                {

            //                    Console.WriteLine("1-Araç Listele");
            //                    Console.WriteLine("2-Araç Ekle");
            //                    Console.WriteLine("3-Marka ya göre Araç Bilgileri Getir");
            //                    Console.WriteLine("4-Renk e göre Araç Bilgileri Getir");
            //                    Console.WriteLine("5-Bir üst menüye dön");
            //                    Console.WriteLine("---------------Lütfen Seçiminizi Giriniz---------------");
            //                    int aracSec = Convert.ToInt32(Console.ReadLine());
            //                    switch (aracSec)
            //                    {
            //                        case 1:
            //                            var result = carManager.GetCarDetails();

            //                            if (result.Success)
            //                            {
            //                                foreach (var cars in result.Data)
            //                                {
            //                                    Console.WriteLine(cars.Description + "-" + cars.BrandName + " - " + cars.ColorName + " - " + cars.DailyPrice);
            //                                }
            //                            }
            //                                Console.WriteLine(result.Message);
            //                            break;

            //                        case 2:

            //                            Car car = new Car();
            //                            Console.WriteLine("1-Aracın Id sini giriniz:");
            //                            car.Id = Convert.ToInt32(Console.ReadLine());
            //                            Console.WriteLine("2-Aracın brandId sini giriniz:");
            //                            car.BrandId= Convert.ToInt32(Console.ReadLine());
            //                            Console.WriteLine("3-Aracın ColorId sini giriniz:");
            //                            car.ColorId= Convert.ToInt32(Console.ReadLine());
            //                            Console.WriteLine("4-Aracın DailyPrice sini giriniz:");
            //                            car.DailyPrice= Convert.ToDecimal(Console.ReadLine());
            //                            Console.WriteLine("2-Aracın Description unu giriniz:");
            //                            car.Description= Convert.ToString(Console.ReadLine());
            //                            Console.WriteLine("2-Aracın ModelYear unu giriniz:");
            //                            car.ModelYear = Convert.ToInt32(Console.ReadLine());
            //                            var results=carManager.AddedCar(car) ;
            //                            if(results.Success)
            //                            {
            //                                Console.WriteLine(car.Id+"-"+car.Description+"-"+car.ModelYear);
            //                            }
            //                            Console.WriteLine(results.Message);
            //                            break;
            //                    }
            //                }

            //            case 2:
            //                Console.ForegroundColor = ConsoleColor.Red;
            //                while (secimone)
            //                {

            //                    Console.WriteLine("1-Renk Listele");
            //                    Console.WriteLine("2-Renk Ekle");
            //                    Console.WriteLine("3-Renk Güncelle");
            //                    Console.WriteLine("4-Bir üst menüye dön");
            //                    int secone = Convert.ToInt32(Console.ReadLine());
            //                    switch (secone)
            //                    {
            //                        case 1:
            //                            Console.ForegroundColor = ConsoleColor.Blue;
            //                            foreach (var colors in colorManager.GetAll())
            //                            {
            //                                Console.WriteLine("Renk Id:{0} Renk Adı:{1}", colors.ColorId, colors.ColorName);
            //                            }
            //                            break;
            //                        case 2:
            //                            Console.ForegroundColor = ConsoleColor.Blue;
            //                            Color color = new Color();
            //                            Console.WriteLine("Renk Adı Giriniz");
            //                            color.ColorName = Console.ReadLine();
            //                            colorManager.Add(color);
            //                            break;
            //                        case 3:
            //                            Console.ForegroundColor = ConsoleColor.Blue;
            //                            foreach (var colors in colorManager.GetAll())
            //                            {
            //                                Console.WriteLine("Renk Id:{0} Renk Adı:{1}", colors.ColorId, colors.ColorName);
            //                            }
            //                            Console.WriteLine("Güncellemek istediğiniz renk ıdsini giriniz");
            //                            colorManager.Update(new Color
            //                            {
            //                                ColorId = Convert.ToInt32(Console.ReadLine()),
            //                                ColorName = Console.ReadLine(),
            //                            });
            //                            break;

            //                        case 4:
            //                            secimone = false;
            //                            break;
            //                        default:
            //                            Console.WriteLine("Lütfen 1 ile 4 arasında sayı giriniz");
            //                            break;
            //                    }
            //                    Console.ForegroundColor = ConsoleColor.Red;
            //                }
            //                break;
            //            case 3:
            //                Console.ForegroundColor = ConsoleColor.Red;
            //                while (secimone)
            //                {

            //                    Console.WriteLine("1-Marka Listele");
            //                    Console.WriteLine("2-Marka Ekle");
            //                    Console.WriteLine("3-Marka Güncelle");
            //                    Console.WriteLine("4-Bir üst menüye dön");
            //                    int secone = Convert.ToInt32(Console.ReadLine());
            //                    switch (secone)
            //                    {
            //                        case 1:
            //                            Console.ForegroundColor = ConsoleColor.Blue;
            //                            foreach (var brands in brandManager.GetAll())
            //                            {
            //                                Console.WriteLine("Marka Id:{0} Marka Adı:{1}", brands.BrandId, brands.BrandName);
            //                            }
            //                            break;
            //                        case 2:
            //                            Console.ForegroundColor = ConsoleColor.Blue;
            //                            Brand brand = new Brand();
            //                            Console.WriteLine("Marka Adı Giriniz");
            //                            brand.BrandName = Console.ReadLine();
            //                            brandManager.Add(brand);
            //                            break;
            //                        case 3:
            //                            Console.ForegroundColor = ConsoleColor.Blue;
            //                            foreach (var brands in brandManager.GetAll())
            //                            {
            //                                Console.WriteLine("Marka Id:{0} Marka Adı:{1}", brands.BrandId, brands.BrandName);
            //                            }
            //                            Console.WriteLine("Güncellemek istediğiniz marka ıdsini giriniz");
            //                            brandManager.Update(new Brand
            //                            {
            //                                BrandId = Convert.ToInt32(Console.ReadLine()),
            //                                BrandName = Console.ReadLine(),
            //                            });
            //                            break;

            //                        case 4:
            //                            secimone = false;
            //                            break;
            //                        default:
            //                            Console.WriteLine("Lütfen 1 ile 4 arasında sayı giriniz");
            //                            break;
            //                    }
            //                    Console.ForegroundColor = ConsoleColor.Red;
            //                }
            //                break;
            //            case 4:
            //                secim = false;
            //                break;
            //            default:
            //                Console.WriteLine("Lütfen 1 ile 5 arasında değer giriniz");
            //                break;
            //        }
            //        Console.ForegroundColor = ConsoleColor.White;
            //    }


            //    Console.ReadKey();
        
    }
}
