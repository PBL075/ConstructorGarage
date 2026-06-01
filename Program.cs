using System;

namespace cars
{
    class Program
    {
        static void Main()
        {
            Car A45s = new Car (" A45s , ", " galbena , ", 421);
            Car C43_sedan = new Car (" C43 sedan , ", " naegra , ", 416);
            Car GLC43 = new Car (" GLC43 SUV , ", " sura , ", 421);

            //A45s.spawnCars();
            //C43_sedan.spawnCars();
            //GLC43.spawnCars();

            Console.WriteLine(" In garaj sunt " + Car.count + " masini ");

        }
    }
}