using System;
 
namespace atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            string separador = new string('=',50);
            string nomeLoja = "Bem vindo a Loja do Manoel";
            Console.WriteLine(separador);
            Console.WriteLine(nomeLoja);
            Console.WriteLine("Que produto deseja: ");
            string produto = Console.ReadLine();
            Console.WriteLine("Valor do produto: ");
            double prodValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade <= 10)
            {
                Console.WriteLine($"Valor total da Compra: {prodValor}");
            }
            else if (quantidade >=11  && quantidade <=20)
            {
                double resultado = prodValor * 0.1;
                double precoFinal = prodValor - resultado;
                Console.WriteLine($"Nessa quantidade você tem 10% de desconto: {precoFinal:c}");
            }
            else if(quantidade >= 21 && quantidade < 50)
            {
                double resultado2 = prodValor * 0.2;
                double precoFinal2 = prodValor - resultado2;
                Console.WriteLine($"Nessa quantidade você tem 20% de desconto: {precoFinal2:c}");
            }
            else
            {
                double resultado3 = prodValor * 0.25;
                double precoFinal3 = prodValor - resultado3;
                Console.WriteLine($"Nessa quantidade você tem 25% de desconto: {precoFinal3:c}");
            }












        }
    }
}