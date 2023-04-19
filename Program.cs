using System;
using ExercicioSemana3Floripa.Model;
using Semana1Floripa.Model;

namespace projetoConsole;

public class Program
{

    public static void Main(string[] args)
    {
        ContaBancaria contaOrigem = new ContaBancaria();
        ContaBancaria contaDestino = new ContaBancaria();

        contaOrigem.Saldo = 1000.0;
        contaOrigem.Numero = 123;
        contaDestino.Numero = 777;
        // contaDestino.Depositar(445);

        System.Console.WriteLine("Transferência: " , contaOrigem.Transferencia(contaDestino, 600.0));
        System.Console.WriteLine(contaOrigem.Saldo);
        System.Console.WriteLine(contaDestino.Saldo);
        System.Console.WriteLine(contaDestino.Numero);
    }

}

