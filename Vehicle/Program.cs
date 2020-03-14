using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane samolet = new Plane(10, 10, 10000, 300, 1999) { High = 2000, Passengers = 100 };
            Console.WriteLine("Самолёт находится на координатах: \nх={0}\ny={1}", samolet.X, samolet.Y);
            Console.WriteLine("Стоимость: {0}, Скорость: {1}, Год выпуска: {2}", samolet.Cost, samolet.Speed, samolet.Year);
            Console.WriteLine("Высота подъёма: {0}, Вместимость: {1}", samolet.High, samolet.Passengers);
            Console.ReadLine();
        }
    }
}
