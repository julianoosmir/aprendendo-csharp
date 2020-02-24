using System;

namespace navaotest
{
    class Program
    {
        enum ta{a,e,i,o,u};
        static void Main(string[] args)
        {
            int xeca=100;
          //  int opa,epa ;
            xeca=xeca>>2;
            Console.WriteLine(xeca);
            ta vogais= ta.a;
            Console.WriteLine(vogais);
            ta ferro = (ta)3;
            Console.WriteLine(ferro);
          /*  Console.WriteLine("Hello World!");

            Console.Write("digite um numero: ");
            opa = int.Parse(Console.ReadLine());
            Console.Write(opa*9);

            Console.Write("\ndigite um numero: ");
            epa =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(epa*9);

            Console.WriteLine(epa-opa);

            xeca=xeca<<1;
            Console.WriteLine(xeca);

            epa=epa>>1;
            Console.WriteLine(epa);
            */
        }
    }
}
