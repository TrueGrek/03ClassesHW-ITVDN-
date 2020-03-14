using System;

namespace _03ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorPrinter cp = new ColorPrinter(ConsoleColor.Red);
            cp.Print("Hello");
            Printer pc = cp;
            pc.Print("Same");
            ColorPrinter kp = new ColorPrinter(ConsoleColor.Blue);
            kp.Print("Differnt");
            Console.ReadLine();
        }
    }
}
