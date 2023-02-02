public class Vertice
{
    public string Nome { get; set; }
    public IDictionary<Vertice, Aresta> ListaDic = new Dictionary<Vertice, Aresta>();
    public ECores Cor { get; set; }

    public Vertice? Predecessor { get; set; }

    public int Distancia { get; set; }
    public int Peso { get; set; }

    public bool NoCaminho { get; set; }
    public int Fechamento { get; set; }
}

