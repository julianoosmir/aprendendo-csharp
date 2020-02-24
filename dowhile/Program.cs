using System;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        { string senha = "123";
        string senhauser;
        int tentativas=0;
       
            do{
                Console.Clear();
                Console.WriteLine("Senha: ");
                senhauser=Console.ReadLine();
                tentativas++;

            }while(senha != senhauser);
            Console.Clear();
            Console.WriteLine("correto , tentativas: {0}",tentativas);
             int[] num={55,33,255,99,55};
        foreach(int n in num){
            Console.WriteLine(n);
        }
            
        }
    }
}
