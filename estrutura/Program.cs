using System;

namespace estrutura
{
    struct Carro{
        public string cor;
        public string modelo;
        public string marca;

        public Carro(string marca,string cor,string modelo){
            this.cor=cor;
            this.marca=marca;
            this.modelo=modelo;
        }
        public void Info(){
             Console.WriteLine ("{0} {1}  {2}", this.modelo,this.marca,this.cor);
             Console.WriteLine("-----------------------------------------------");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Carro c1;
            c1.cor="verde";
            c1.marca="fiat";
            c1.modelo="uno";
            Carro c2= new Carro("hydai","preto","santa fe");
            Carro[] carros= new Carro[5];
            c1.Info();
            Console.WriteLine ("{0} {1}  {2}\n", c1.modelo,c1.marca,c1.cor);
       Console.WriteLine ("{0} {1}  {2}\n", c2.modelo,c2.marca,c2.cor);

            carros[0].cor="preto";
            carros[0].modelo="gol";
            carros[0].marca="vol";
            carros[1].cor="vermelho";
            carros[1].marca="honda";
            carros[1].modelo="hrv";
            carros[2].cor="btanco";
            carros[2].modelo="uno";
            carros[2].marca="fiat";
            carros[3].cor="azul";
            carros[3].marca="hilux";
            carros[3].modelo="che";

            for(int i=0;i<carros.Length;i++){
                carros[i].Info();
            }
        }
    }
}
