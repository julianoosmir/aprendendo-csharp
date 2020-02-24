using System;

namespace caso
{
    class Program
    {
        static void Main(string[] args)
        {
          int tempo;
          char escolha;
                inicio:
            Console.WriteLine("Escolha o transporte: [a] aviao , [c]carro [o] onibus");
            escolha= char.Parse(Console.ReadLine());
            switch(escolha){
                case 'a':
                case 'A':
                tempo=50;
                break;
                case 'c':
                case 'C':
                tempo=450;
                break;
                case 'o':
                case 'O':
                tempo=1550;
                break;
                default: 
                tempo=-1;
                break;
            }
            if (tempo<0){
                Console.WriteLine("transporte indisponivel");
            }else{
                Console.WriteLine("chegara ao destino em {0}", tempo);
            }

            Console.WriteLine("contibuar? [s/n]");
            escolha=char.Parse(Console.ReadLine());
            if (escolha== 's'| escolha=='S') {
                    goto inicio;
            }else
            {
                Console.WriteLine("falo");
            }

        }
    }
}
