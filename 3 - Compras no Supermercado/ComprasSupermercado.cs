using System;
using System.Linq;
using System.Collections.Generic;

namespace DIO
{
    class ComprasSupermercado : IRun
    {
        private void OP1()
        {
		var totalDeCasosDeTeste = int.Parse(Console.ReadLine()); 
		for (int i = 0; i < totalDeCasosDeTeste; i++) {
			Console.WriteLine(string.Join(" ",Console.ReadLine().Split(' ').OrderBy(x => x).Distinct()));
		}
        }
        public void Run()
        {
            OP1();
        }
    }
}
