using System.Linq;

public class Challenge
{
    public static string[] CalculaTopOcorrenciasDeQueries(string texto, string[] queries, int k)
    {
        return queries
            .Select(x => new { Query = x, Count = texto.Split(x).Length - 1 })
            .OrderByDescending(x => x.Count)
            .ThenBy(x => x.Query)
            .Take(k)
            .Select(x => x.Query)
            .ToArray();
    }
}
