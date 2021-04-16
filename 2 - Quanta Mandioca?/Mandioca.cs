using System;
using System.Linq;
using System.Collections.Generic;

namespace DIO
{
    class Mandioca : IRun
    {
        private void OP1()
        {
            int chico = 300 * Int32.Parse(Console.ReadLine());
            int bento = 1500 * Int32.Parse(Console.ReadLine());
            int bernardo = 600 * Int32.Parse(Console.ReadLine());
            int marina = 1000 * Int32.Parse(Console.ReadLine());
            int iara = 150 * Int32.Parse(Console.ReadLine());
            int marlene = 225;
            int total = chico + bento + bernardo + marina + iara + marlene; // Digite aqui o calculo total
            Console.WriteLine(total);
        }
        private void OP2()
        {
            Console.WriteLine(new Dictionary<string, int>{
                {"chico", 300},
                {"bento", 1500},
                {"bernardo", 600},
                {"marina", 1000},
                {"iara", 150},
                {"marlene", 225}
            }.Sum(x =>
                (x.Key == "marlene") ?
                x.Value :
                x.Value * Int32.Parse(Console.ReadLine())
            ));
        }
        private void OP3()
        {
            Console.WriteLine(new int[] { 300, 1500, 600, 1000, 150 }.Sum(x => x * Int32.Parse(Console.ReadLine())) + 225);
	}
        public void Run()
        {
            OP3();
        }
    }
}
