using System;
namespace tugaspolymorphism
{
    public class Canon: IPrinterWindows
    {
        public  void Show()
        {
            Console.WriteLine("Canon display dimension : 9,5*12");
        }
        public  void Print()
        {
            Console.WriteLine("Canon printer printing.... ");
        }
    }
}
