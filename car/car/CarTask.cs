using System;

namespace ConsoleApp2
{
    class CarTask
    {

        private string Brand;
        private string Model;
        private int Year;

        public CarTask(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }


        public void Start()
        {
            Console.WriteLine(Brand + Model + " is starting.");
        }

        public void Drive()
        {
            Console.WriteLine(Brand + Model + " is driving.");
        }

        public void Stop()
        {
            Console.WriteLine(Brand + Model + "has stopped.");
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Brand: " + Brand + "  " + "Model: " + Model + " Year: " + Year);
        }
    }

    class CarTask
    {
        static void Main(string[] args)
        {

            CarTask car1 = new CarTask("Mercedes", "C-Class", 2022);
            CarTask car2 = new CarTask("BMW", "X5", 2022);


            car1.Start();
            car1.Drive();
            car1.Stop();
            car1.DisplayInfo();

            Console.WriteLine();

            car2.Start();
            car2.Drive();
            car2.Stop();
            car2.DisplayInfo();
        }
    }
}











