using System;

namespace tugaspolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinterWindows Printer;

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("Nomor printer [1...3]: ");

            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
            {
                Printer = new Epson();
            }
            else if (nomorPrinter == 2)
            {
                Printer = new Canon();
            }
            else
                Printer = new Laserjet();

            Printer.Show();
            Printer.Print();
            Console.ReadKey();

        }
    }
}
