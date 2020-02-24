using System;

namespace herança
{


    class Base{
        public Base(){
            Console.WriteLine("contrutor base ");
            }
      virtual  public void Info(){
            Console.WriteLine("base");
        } 
    }
    class Derivada1:Base{
        public Derivada1(){
            Console.WriteLine("contrutor deriva1 ");
        }
    override public void Info(){
            Console.WriteLine("base1");
        } 
    }

    class Derivada2:Derivada1{
        public Derivada2(){
            Console.WriteLine("contrutor derivada2 ");
        }
        override public void Info(){
            Console.WriteLine("base2");
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Base Ref;
                Derivada2 derivada2 = new Derivada2();
                Derivada1 derivada1 = new Derivada1();
               // derivada2.Info();
                //derivada1.Info();
            Ref=derivada1;
            Ref.Info();
            
        }
    }
}
