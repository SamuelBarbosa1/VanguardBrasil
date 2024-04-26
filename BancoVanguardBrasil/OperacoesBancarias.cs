using BancoVanguardBrasil;
using System;

class OperacoesBancarias
{
    public void RealizarDeposito ( Usuario usuario )
    {
        Console.Write ("Informe o valor do depósito: ");
        double valorDeposito = Convert.ToDouble (Console.ReadLine ());

        usuario.Saldo += valorDeposito;
        Console.WriteLine ($"Depósito de R$ {valorDeposito} realizado com sucesso!");
    }

    public void RealizarSaque ( Usuario usuario )
    {
        Console.Write ("Informe o valor do saque: ");
        double valorSaque = Convert.ToDouble (Console.ReadLine ());

        if ( valorSaque <= usuario.Saldo )
        {
            usuario.Saldo -= valorSaque;
            Console.WriteLine ($"Saque de R$ {valorSaque} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine ("Saldo insuficiente para saque.");
        }
    }

    public void Transferir ( Usuario origem, Usuario destino )
    {
        Console.Write ("Informe o valor da transferência: ");
        double valorTransferencia = Convert.ToDouble (Console.ReadLine ());

        if ( valorTransferencia <= origem.Saldo )
        {
            origem.Saldo -= valorTransferencia;
            destino.Saldo += valorTransferencia;
            Console.WriteLine ($"Transferência de R$ {valorTransferencia} realizada com sucesso!");
        }
        else
        {
            Console.WriteLine ("Saldo insuficiente para transferência.");
        }
    }

    public void PagarConta ( Usuario usuario )
    {
        Console.Write ("Informe o valor da conta a ser paga: ");
        double valorConta = Convert.ToDouble (Console.ReadLine ());

        if ( valorConta <= usuario.Saldo )
        {
            usuario.Saldo -= valorConta;
            Console.WriteLine ($"Conta de R$ {valorConta} paga com sucesso!");
        }
        else
        {
            Console.WriteLine ("Saldo insuficiente para pagar a conta.");
        }
    }

    public void RenderJuros ( Usuario usuario )
    {
        Console.Write ("Informe a quantidade de dinheiro a ser guardada para render juros: ");
        double valorGuardado = Convert.ToDouble (Console.ReadLine ());

        double taxaJuros = 0.01; // 1% de juros
        double juros = valorGuardado * taxaJuros;
        usuario.Saldo += juros;
        Console.WriteLine ($"Juros de R$ {juros} adicionados ao saldo.");
    }
}