using System;
//автомобиль, поезд, транспортное средство, экспресс;
namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport t1 = new Transport();
            t1.CountMen = 1000;
            t1.Speed = 1000;

            Avtomobile t2 = new Avtomobile();
            t2.CountMen = 4;
            t2.Speed = 100;
            t2.BodyType = "Седан";

            Rain t3 = new Rain();
            t3.CountMen = 800;
            t3.Speed = 200;
            t3.NumberVan = 23;

            Express e = new Express();
            e.CountMen = 500;
            e.Speed = 500;
            e.NumberVan = 10;
            e.NameExpress = "Lastochka";

            Transport[] mas = new Transport[4];
            mas[0] = t1;
            mas[1] = t2;
            mas[2] = t3;
            mas[3] = e;

            for(int i = 0; i < 4; i++)
            {
                mas[i].Info();
            }
        }
    }
}
