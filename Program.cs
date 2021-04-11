using System;

namespace notas_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int inteiro, auxNotas, auxMoedas;
            Console.Clear();
            Console.WriteLine("valor total: ");
            valor = Convert.ToDouble(Console.ReadLine().Replace(".",","));

            inteiro = (int)valor;
            auxNotas = (int)Math.Floor(valor);
            valor *= 100;
            auxMoedas = (int)valor;

            //Console.WriteLine("{0}", auxNotas);

            int[] notas = new int[]{100,50,20,10,5,2};

            Console.WriteLine("NOTAS:");
            foreach(int nota in notas){
                Console.WriteLine("{0} nota(s) de R$ {1}.00", auxNotas/nota,nota);
                auxNotas = auxNotas%nota;
            }

            int[] moedas = new int[]{50,25,10,5,1};

            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ {1}.00", auxNotas,1);

            auxMoedas -= inteiro*100;

            foreach(int moeda in moedas){
                Console.WriteLine("{0} moeda(s) de R$ 0.{1:00}", auxMoedas / moeda,moeda);
                auxMoedas %= moeda;
            }
        }
    }
}
