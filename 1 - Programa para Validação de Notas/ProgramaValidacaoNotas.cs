using System;

namespace DIO
{
  class ProgramaValidacaoNotas : IRun
  {
    static void OP1() {
      int notasLidas = 0;
      bool opcao;
      double x = 0;
          
      while (notasLidas < 2) { //toda rotina é executada enquanto a leitura de notas for menor que 2
        opcao = true; //opção e´a escolha do user 1-sim[true] 2-nao[false]
        double nota = double.Parse(Console.ReadLine());//recebe a primeira nota
  
        if (nota < 0 || nota > 10) {//se a primeira nota for inválida imprime tal
          Console.WriteLine("nota invalida");
        } else if (notasLidas == 0) {//senão, entao será válida mas se for a primeira leitura...
          x = nota; //entao coloque o valor em X
          notasLidas++;//e em seguida incremente o contador de leitura de notas
        } else if (notasLidas == 1) {// entao ja havendo lido a primeira,
          double media = (x + nota) / 2;//calcule a meia baseado na primeira leitura 'x' com a segunda 'nota' (e não arredonde como tu fez ok?)
  
          Console.Write("media = ");//impressão
          Console.WriteLine(media.ToString("N2"));
              
          while (opcao == true){//faça isso enquanto o user escolher 1 ou seja, opção [true]
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            double res = double.Parse(Console.ReadLine());
  
            if (res ==  1) {//abaixo é se ele escolher um ou 2
              opcao = false;
              notasLidas = 0;
            } else if (res == 2) {
              opcao = false;
              notasLidas++;                
            }
          }
        } 
      }
    }
    static void OP2() {
      double soma = 0;
      int i = 0;
      
      while(true) {
        double nota = double.Parse(Console.ReadLine());
        
        if (nota < 0 || nota > 10) {Console.WriteLine("nota invalida");continue;}
        
        soma += nota;
        
        if (i++ == 1) {
          Console.WriteLine("media = {0}", (soma / 2).ToString("N2"));
          
          double repetir = 0;
          i = 0;
          soma = 0;
          
          while(repetir != 1) {
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            repetir = double.Parse(Console.ReadLine());
            
            if(repetir == 2) return;
          }
        }
      }
    }
    public void Run()
    {
      OP2();
    }
  }
}
