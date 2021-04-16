using System;
using System.Linq;
using System.Collections.Generic;

namespace DIO
{
    class Run
    {
        static void Main(string[] args)
        {
            var Exe = new List<IRun>{
            };
            if (args.Count() == 0)
            {
                int i = 0;
                Console.WriteLine(
                    "Informe o numero do Executorício\n"
                    + string.Join("\n", Exe.Select(x => $"{i++} {x}"))
                    + "\ndotnet run [NUMERO]"
                );
                return;
            }
	    int Op = Int32.Parse(args[0]);
	    if (Op > Exe.Count)
		    Console.WriteLine("Opção Inválida");
            else
		    Exe.ElementAt((Op == 0)? 0:Op - 1).Run();
        }
    }
}
