using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbunacci_Zahlenreihe
{

    public delegate int FibbunacciHandler(int i);

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
            fibbunacciHandler = (i) => i == 0 ? 0 : i == 1 ? 1 : fibbunacciHandler(i-2) + fibbunacciHandler(i-1);
            // Beispiel: 33 => 3 524 578
            Console.WriteLine(fibbunacciHandler(33));
            Console.ReadLine();
        }
    }
}
