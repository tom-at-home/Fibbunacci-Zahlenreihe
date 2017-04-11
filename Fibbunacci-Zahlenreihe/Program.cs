using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbunacci_Zahlenreihe
{

    public delegate int FibbunacciHandler(int grenze, int i, int fibu);

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
            fibbunacciHandler = (grenze, i, fibu) => i == grenze ? fibu : fibu + fibbunacciHandler(grenze, i+1, );
            Console.WriteLine(fibbunacciHandler(6, 1, 1));
            Console.ReadLine();
        }
    }
}
