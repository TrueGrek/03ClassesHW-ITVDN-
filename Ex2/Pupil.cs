using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class Pupil
    {
        public virtual void Study() //Ключевое слово virtual используется для разрешения переопределения в производном классе
        {
            Console.WriteLine("Pupil.Study()");
        }
        public virtual void Write()
        {
            Console.WriteLine("Pupil.Study()");
        }
        public virtual void Read()
        {
            Console.WriteLine("Pupil.Study()");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Pupil.Study()");
        }

    }
    //Класс ExcelentPupil производный класс базового класса Pupil
    class ExcellentPupil : Pupil
    {
        public override void Study() //Модификатор override требуется для расширения изменений виртуальной реализации унаследованного метода.
        {
            Console.WriteLine("ExcellentPupil.Study()");
        }
        public override void Write()
        {
            Console.WriteLine("ExcellentPupil.Study()");
        }
        public override void Read()
        {
            Console.WriteLine("ExcellentPupil.Study()");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcellentPupil.Study()");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil.Study()");
        }
        public override void Write()
        {
            Console.WriteLine("GoodPupil.Study()");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupil.Study()");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupil.Study()");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil.Study()");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil.Study()");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil.Study()");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil.Study()");
        }
    }
}
