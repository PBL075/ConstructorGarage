using System;

namespace cars
{
    class Car
    {
        public string model = "";
        public string culoare = "";
        public int cai ;
        public static int count = 0;

        public Car(string _model , string _culoare , int _cai)
        {
            model = _model;
            culoare = _culoare;
            cai = _cai;
            
            count++;
            
        }
        public void spawnCars()
        {
            Console.WriteLine("Model: " + model + "Culoarea " + culoare + "Cai " + cai);
        }
    }
}