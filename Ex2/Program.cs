using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil one = new ExcellentPupil();
            Pupil ender = new GoodPupil();

            ClassRoom classs = new ClassRoom(one, ender);

            classs.Study();
            Console.WriteLine(new string('-', 30));
            classs.Read();
            Console.WriteLine(new string('-', 30));
            classs.Write();
            Console.WriteLine(new string('-', 30));
            classs.Relax();
            Console.WriteLine(new string('-', 30));
            Console.Read();
        }
    }
}
