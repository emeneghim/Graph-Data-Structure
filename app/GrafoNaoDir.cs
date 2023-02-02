public class GrafoNaoDirigido : Grafo
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

                if (vertice1 != vertice2)
                    vertice2.ListaDic.Add(vertice1, pAresta);
            }
        }
    }

    public int grau(Vertice pVertice)
    {
        if (grauE(pVertice) == grauS(pVertice))
            return grauE(pVertice);
        else
            return 0;
    }
}