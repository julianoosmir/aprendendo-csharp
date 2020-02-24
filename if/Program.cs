using System;

namespace iftest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4,res;
            string p;
            Console.WriteLine("digite nota: ");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("digite nota: ");
            n2= int.Parse(Console.ReadLine());
            Console.WriteLine("digite nota: ");
            n3= int.Parse(Console.ReadLine());
            Console.WriteLine("digite nota: ");
            n4= int.Parse(Console.ReadLine());

            res= (n1+n2+n3+n4)/4;
            if(res<7){
                p="reprovado";
            }else {
                p="aprovado";
            }
            Console.WriteLine(p);
        }
    }
}
