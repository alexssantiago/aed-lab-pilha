using SensorVertebral.Dominio;
using System;

namespace SensorVertebral
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            do
            {
                Console.Clear();
                double peso = new Random().Next(20, 120);

                if (pilha.LimiteSuportaPeso())
                    pilha.InserirPeso(peso);
                else
                    Console.WriteLine($"\nO peso empilhado ultrapassou o limite suportado!");

                Console.WriteLine($"\nPeso suportado pela coluna: {pilha.VerificaLimite()}");
                Console.WriteLine($"\nPeso total empilhado: {pilha.Peso}");

            } while (Console.ReadLine() == "");

            Console.ReadKey();
        }
    }
}
