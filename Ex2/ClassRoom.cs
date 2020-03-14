using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class ClassRoom
    {
        Random rand = new Random();
        Pupil[] p = new Pupil[4];

        public ClassRoom(Pupil p0,Pupil p1, Pupil p2, Pupil p3)
        {
            p[0] = p0;
            p[1] = p1;
            p[2] = p2;
            p[3] = p3;
        }
        public ClassRoom(Pupil p0, Pupil p1, Pupil p2)
        {
            p[0] = p0;
            p[1] = p1;
            p[2] = p2;
            p[3] = GeneratePupil();
        }
        public ClassRoom(Pupil p0, Pupil p1)
        {
            p[0] = p0;
            p[1] = p1;
            p[2] = GeneratePupil();
            p[3] = GeneratePupil();
        }
        private Pupil GeneratePupil()
        {
            int r = rand.Next(1, 4);
            switch (r)
            {
                case 1: return new ExcellentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();
                default:  return new BadPupil();
            }
        }

        public void Study()
        {
            foreach(Pupil pupils in p)
            {
                pupils.Study();
            }
        }
        public void Read()
        {
            foreach (Pupil pupils in p)
            {
                pupils.Read();
            }
        }
        public void Write()
        {
            foreach (Pupil pupils in p)
            {
                pupils.Write();
            }
        }
        public void Relax()
        {
            foreach (Pupil pupils in p)
            {
                pupils.Relax();
            }
        }
    }
}
