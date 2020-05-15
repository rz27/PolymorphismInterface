using System;
namespace tugaspolymorphism
{
    public class Laserjet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }
        public  void Print()
        {
            Console.WriteLine("Laserjet printer printing.....  ");
        }

    }
}
