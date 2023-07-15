// See https://aka.ms/new-console-template for more information
using GeraPadroesNumericos.Functions;
using GeraPadroesNumericos.Service;

Console.WriteLine("Iniciando Aplicação");

var setPattern = new SetPatternService(new ChoosePattern(new MultiplyNumbers()));

for (int i = 0; i < 100; i++)
{
    setPattern.SetPatternToSend();

    Console.WriteLine();

    Thread.Sleep(1000);
}
