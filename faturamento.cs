using System;

class FaturamentoDistribuidora
{
    static void Main()
    {
        Console.WriteLine("Informe os valores de faturamento mensal para cada estado:");

        Console.Write("SP: R$ ");
        double sp = Convert.ToDouble(Console.ReadLine());

        Console.Write("RJ: R$ ");
        double rj = Convert.ToDouble(Console.ReadLine());

        Console.Write("MG: R$ ");
        double mg = Convert.ToDouble(Console.ReadLine());

        Console.Write("ES: R$ ");
        double es = Convert.ToDouble(Console.ReadLine());

        Console.Write("Outros: R$ ");
        double outros = Convert.ToDouble(Console.ReadLine());

        double totalFaturamento = sp + rj + mg + es + outros;

        double percentualSP = (sp / totalFaturamento) * 100;
        double percentualRJ = (rj / totalFaturamento) * 100;
        double percentualMG = (mg / totalFaturamento) * 100;
        double percentualES = (es / totalFaturamento) * 100;
        double percentualOutros = (outros / totalFaturamento) * 100;

        Console.WriteLine("\nPercentual de representação por estado no faturamento total:");
        Console.WriteLine($"SP: {percentualSP:F2}%");
        Console.WriteLine($"RJ: {percentualRJ:F2}%");
        Console.WriteLine($"MG: {percentualMG:F2}%");
        Console.WriteLine($"ES: {percentualES:F2}%");
        Console.WriteLine($"Outros: {percentualOutros:F2}%");
    }
}