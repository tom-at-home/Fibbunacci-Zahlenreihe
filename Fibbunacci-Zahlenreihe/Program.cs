using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbunacci_Zahlenreihe
{

    public delegate int FibbunacciHandler(int grenze, int a, int b, int i);

    class Program
    {

        FibbunacciHandler fibbunacciHandler;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Init();
        }

        public void Init()
        {
            fibbunacciHandler = (grenze, a, b, i) => i == grenze ? a + b : fibbunacciHandler(grenze, a+b, , i+1);
            Console.WriteLine(fibbunacciHandler(6, 0, 1, 1));
            Console.ReadLine();
        }
    }
}
