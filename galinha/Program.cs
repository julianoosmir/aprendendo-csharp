using System;

namespace galinha
{ class Galinha{
    private string nomeGalinha;
    private int numOvo;

    public  Galinha(string nomeGalinha){
        this.nomeGalinha=nomeGalinha;
        numOvo=0;
    }
    public Ovo botar(){
        numOvo++;
     return new Ovo (numOvo, nomeGalinha);
 }
}   
 
   class Ovo{
       private int numOvo;
       private string minhaGalinha;
        public Ovo (int numOvo,string minhaGalinha) {
            this.numOvo=numOvo;
            this.minhaGalinha=minhaGalinha;
            Console.WriteLine("Ovo criado {0} pela {1}", this.numOvo, this.minhaGalinha);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Galinha galinha= new Galinha("pintadinah");

            galinha.botar();
        }
    }
}
