using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Sqr
    {
        int size;
        public Sqr()
        { size = 0; }

        public Sqr(int size)
        {
            this.size = size;
        }

        public int Size { get { return size; } set { this.size = value; } }

        public int GetSize()
        { return size; }

        public void SetSize(int size)
            { this.size = size; }

        public static string StaticMethod()
        {
            return "Static method is calling...";
        }
    }
}
