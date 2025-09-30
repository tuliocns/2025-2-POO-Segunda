using System.Globalization;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Cartao cartaoBase = new Cartao();
cartaoBase.Debitar(100);

Console.WriteLine("-- Cartão de Débito --");

Cartao cartaoDebitao = new CartaoDebito();
cartaoDebitao.Debitar(100);