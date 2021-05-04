using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DIO
{
    class ValidadorSenhasRequisitos : IRun
    {
        private void OP1()
        {
            var rx = new Regex(@"^[a-zA-Z0-9]{6,32}$", RegexOptions.Compiled);
            var caps = new Regex(@"[A-Z]", RegexOptions.Compiled);
            var minuscule = new Regex(@"[a-z]", RegexOptions.Compiled);
            var number = new Regex(@"[0-9]", RegexOptions.Compiled);
            string senha = "";
            
            while((senha = Console.ReadLine()) != null) {
            bool valida = rx.IsMatch(senha) && caps.IsMatch(senha) && minuscule.IsMatch(senha) && number.IsMatch(senha);
            Console.WriteLine ((valida) ? "Senha valida." : "Senha invalida.");
    }
        }
        public void Run()
        {
            OP1();
        }
    }
}
