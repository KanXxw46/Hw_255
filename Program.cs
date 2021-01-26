using System;

namespace CarBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Mechanik mechanik = new Mechanik();
            CarBuilder carBuilder =  new HeavyCar();
            var heavyCar = mechanik.Make(CarBuilder);
        }
    }
}
