public class GrafoDirigido : Grafo
{
    public void insereA(Vertice pVertice1, Vertice pVertice2, Aresta pAresta)
    {
        var vertice1 = ListaVertices.Find(f => f.Nome == pVertice1.Nome);
        var vertice2 = ListaVertices.Find(f => f.Nome == pVertice2.Nome);

        if (!arestas().Contains(pAresta))
        {
            if (vertice1 != null && vertice2 != null)
            {
                vertice1.ListaDic.Add(vertice2, pAresta);
            }
        }
    }
}