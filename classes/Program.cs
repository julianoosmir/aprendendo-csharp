using System;

namespace classes
{
    class Jogador{
      public  int vida;
      public string nome;
    public Jogador(string n){
        vida=100;
        nome= n;
     }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
           Console.WriteLine("digite nome:");
           nome=Console.ReadLine();
           Jogador player1= new Jogador(nome);
           Jogador player2= new Jogador("adversario");
           player1.vida=100000;
            player2.vida=850+2615;
           Console.WriteLine("jogador : {0} e vida {1}", player1.nome,player1.vida);
           Console.WriteLine("jogador : {0} e vida {1}", player2.nome,player2.vida);

            

        }
    }
}
