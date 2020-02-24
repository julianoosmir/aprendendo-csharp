using System;

namespace abstrato
{

abstract class Veiculo{
    protected int  velMaxima;
    protected int  velAtual;
    protected bool  ligado;
     public Veiculo(){
         ligado=false;
         velAtual=0;    
     }

     public void setLigado(bool ligado){
         this.ligado=ligado;
     }
     public int getVelAtual(){
         return velAtual;
     }
     abstract public void aceleraçao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        velMaxima=120;
    }
    override public void aceleraçao(int mult){
        velAtual+=10*mult;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Carro carro = new Carro();
            carro.aceleraçao(5);
            carro.aceleraçao(-2);
            Console.WriteLine( carro.getVelAtual()); 
        }
    }
}
