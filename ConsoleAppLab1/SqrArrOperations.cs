using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class SqrArrOperations
    {
       // Sqr sqr = new Sqr();

        Sqr[] sqrs;
        int poiner = 0;

        public SqrArrOperations(int size)
        {
            sqrs = new Sqr[size];
           
        }

        public void SetSqrElement(Sqr sqr)
        { 
            if (poiner < sqrs.Length)
            {
                sqrs[poiner] = sqr;
            }
        }

    }
}
