using PRORR;
using PRORR.ProgramConfiguration;
using System.Diagnostics;


Stopwatch stopwatch = Stopwatch.StartNew();
Configuration? configuration = Configuration.GetConfiguration(args);
if (configuration == null)
{
    return;
}

GeneticAlgorithm geneticAlgorithm = new GeneticAlgorithm(configuration);
geneticAlgorithm.Run();
Individual bestIndividual = geneticAlgorithm.GetBestIndividual();

int i = 0;
bestIndividual.Genes.ToList().ForEach(gene => Console.WriteLine($"x{i++}: {gene}"));
stopwatch.Stop();
Console.WriteLine($"Czas wykonania: {stopwatch.ElapsedMilliseconds} ms");