using System;

namespace OOPChallenges
{
    class Program
    {
        class car
        {
            string mark;
            string model;
            string color;
            string regnumber;
            int fueltank;
            int odo;

            public car(string _mark, string _model, string _color, string _regnumber)
            {
                mark = _mark;
                model = _model;
                color = _color;
                if (_regnumber.Length != 6)
                {
                    regnumber = "Undefined";
                }
                else
                {
                    regnumber = _regnumber;
                }
                fueltank = 60;
                odo = 0;
            }
            public string Model
            {

                get { return model; }
            }
            public string Mark
            {

                get { return mark; }
            }
            public string Color
            {

                get { return color; }
            }
            public int Fueltank
            {
                get { return fueltank; }
            }
            public int Odo
            {
                get { return odo; }
            }
            public string Regnumber
            {
                get { return regnumber; }
            }
            public void Drive()
            {
                odo += 100;
                fueltank -= 5;
            }
            public void Showcardetails()
            {
                Console.WriteLine($"Model:{model}\n Mark:{mark}\n Color:{color}\n Regnumber:{regnumber}\n Fuel:{fueltank}\n Odo:{odo}");
            }
        }
            static void Main(string[] args)
        {
            car newcar = new car("toyota","supra","white", "12345f");
            while (newcar.Fueltank != 0)
            {
                newcar.Drive();
            }
            Console.WriteLine("ride is over!");
            newcar.Showcardetails();
        }
    }
}
