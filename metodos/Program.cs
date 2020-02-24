using System;

namespace metodos
{
    
    class Program
    {
        static void Main(string[] args)
        {
           int v1,v2,q,r;
            v1= int.Parse(Console.ReadLine());
            v2= int.Parse(Console.ReadLine());
            mutiplicaçao(v1,v2);
           // r=soma(v1,v2);
          Console.WriteLine("soma e: {0}",soma(v1,v2));
          q=divide(v1,v2,out r);
          Console.WriteLine("{0}:{1}= {2} e o rest {3}",v1,v2,q,r);
          teste();
            teste();
            parametro(v2,v1);
            parametro(9,6,3,9,6,3,6,5,36,63);
          dobrar(ref v2);
          Console.WriteLine(v2);
           
           
           
            
        }
        static void teste(){
            Console.WriteLine("Hello World!");
        }
        static void calculo(){
            int num=9;
           for(int i=0;i<10;i++){
               Console.WriteLine(num*i);
               i++;
           }
        }
        static void mutiplicaçao(int n1, int n2){
            int res = n1*n2;
            Console.WriteLine(" mutiplicaçao de {0} X {1} e = {2}",n1,n2,res);
           
        }
      static int soma(int n1, int n2){
            int res = n1+n2;
            return res;
        }
        static void dobrar(ref int valor){
            valor*=2;
        }
        static int divide(int d1, int d2, out int resto){
            int quociente= d1/d2;
            resto=d1%d2;
            return quociente;

        }
        static void parametro(params int[]n){
            int res= 0;
            if(n.Length<1){
                Console.WriteLine("sem numeros");
            }else if (n.Length <2)
            {
                Console.WriteLine("insulficia de  numeros");
            } else {
                for(int i=0;i < n.Length;i++){
                    res+=n[i];
                }
                Console.WriteLine("soma dos valores e : {0}",res);
            }

        }

    }

}
