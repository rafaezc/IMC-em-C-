using System;

namespace IMC
{
    class Program2
    {
        static void abc(string[] args)
        {
            Console.WriteLine("Digite seu peso");
            decimal peso = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            decimal altura = decimal.Parse(Console.ReadLine());

            decimal imc = peso / (altura * altura);

            Console.WriteLine("O imc é:");
            Console.WriteLine(imc);

            if (imc < decimal.Parse("18,5"))
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (imc > decimal.Parse("18,5") && imc < decimal.Parse("24,9"))
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc > decimal.Parse("24,9") && imc < decimal.Parse("29,9"))
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc > decimal.Parse("29,9") && imc < decimal.Parse("34,9"))
            {
                Console.WriteLine("Obesidade I");
            }
            else if (imc > decimal.Parse("34,9"))
            {
                Console.WriteLine("Obesidade II");
            }

            Console.ReadKey();
        }
    }
}
