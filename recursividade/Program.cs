using System;



namespace recursividade


{   class Cal{
    public int soma(params int[]n){
        int s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
    public double soma(params double[]n){
        double s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
    public int fat (int n){
        int res;
        if (n<=1){
            res=1;
        }else{
            res=n*fat(n-1);
        }
        return res;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cal cal= new Cal();
            var soma=cal.soma(4,2,3,6);
            var maça=cal.soma(4.7,2.5,3.7,6.9);
            var fatorial = cal.fat(3);
        
            Console.WriteLine(soma);
            Console.WriteLine(maça);
            Console.WriteLine(fatorial);
        }
    }
}
