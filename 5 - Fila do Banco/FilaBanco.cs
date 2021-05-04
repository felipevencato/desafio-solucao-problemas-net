using System;
using System.Linq;
using System.Collections.Generic;

namespace DIO
{
    class FilaBanco : IRun
    {
        private void OP1()
        {
		var totalDeCasos = int.Parse(Console.ReadLine()); 
		for (int i = 0; i < totalDeCasos; i++ ){ 
			Console.ReadLine(); 
			var txt = Console.ReadLine().Split(" "); 
			var original = txt.Select(x => int.Parse(x)).ToArray(); 
			var sorted = txt.Select(x => int.Parse(x)) 
				.OrderByDescending(x => x).ToArray(); 
			var cont = 0; 
			for (var j = 0; j < original.Count(); j++) { 
				if (original[j] == sorted[j]) cont++; 
			} 
			Console.WriteLine(cont); 
		}
        }
        public void Run()
        {
            OP1();
        }
    }
}
