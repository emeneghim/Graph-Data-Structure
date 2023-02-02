public abstract class Grafo
{
    public List<Vertice> ListaVertices { get; set; }
    public List<Vertice> FilaVertices = new List<Vertice>();
    public int tempo = 0;

    public void InsereFila(Vertice pVertice)
    {
        FilaVertices.Add(pVertice);
    }

    public Vertice? RemoveFila()
    {
        if (FilaVertices.Any())
        {
            var auxVer = FilaVertices.First();
            FilaVertices.Remove(auxVer);
            return auxVer;
        }
        return null;
    }

    public int getOrdem()
    {
        return ListaVertices.Count();
    }

    public int getTamanho()
    {
        return arestas().Count();
    }

    public List<Vertice> vertices()
    {
        return ListaVertices;
    }

    public List<Aresta> arestas()
    {
        return ListaVertices.SelectMany(s => s.ListaDic.Values).Distinct().ToList();
    }

    public void insereV(string pNome)
    {
        ListaVertices.Add(new Vertice() { Nome = pNome });
    }

    public void insereV(Vertice pVertice)
    {
        ListaVertices.Add(pVertice);
    }

    public void removeV(string pNome)
    {
        var verticeEncontrado = ListaVertices.Find(f => f.Nome == pNome);

        if (verticeEncontrado != null)
            removeV(verticeEncontrado);
    }

    public void removeV(Vertice pVertice)
    {
        foreach (var verticeAtual in vertices())
        {
            if (verticeAtual == pVertice)
                continue;

            var listaAtual = verticeAtual.ListaDic.Where(w => w.Key.Nome == pVertice.Nome).Select(x => x.Key).ToArray();

            foreach (var atual in listaAtual)
            {
                verticeAtual.ListaDic.Remove(atual);
            }
        }

        if (ListaVertices.Find(f => f == pVertice) != null)
            ListaVertices.Remove(pVertice);
    }

    public void removeA(string pNomeAresta)
    {
        foreach (var ver in ListaVertices)
        {
            var a = ver.ListaDic.Where(w => w.Value.Nome == pNomeAresta).Select(s => s.Key).FirstOrDefault();
            if (a != null)
                ver.ListaDic.Remove(a);
        }
    }

    public void removeA(Aresta pAresta)
    {
        foreach (var ver in ListaVertices)
        {
            var a = ver.ListaDic.Where(w => w.Value == pAresta).Select(s => s.Key).FirstOrDefault();
            if (a != null)
                ver.ListaDic.Remove(a);
        }
    }

    public List<Vertice> adj(Vertice pVertice)
    {
        var aux = ListaVertices.Find(f => f == pVertice)?.ListaDic.Select(s => s.Key).ToList();
        if (aux == null)
            return new List<Vertice>();

        return aux; 
    }

    public Aresta? getA(Vertice pV1, Vertice pV2)
    {
        return ListaVertices.Find(f => f == pV1)?.ListaDic.Where(i => i.Key == pV2).FirstOrDefault().Value;
    }

    public int grauE(Vertice pVertice)
    {
        return arestasE(pVertice).Count();
    }

    public int grauS(Vertice pVertice)
    {
        return pVertice.ListaDic.Count();
    }

    public List<Vertice> verticesA(Aresta pAresta)
    {
        foreach (var ver in ListaVertices)
        {
            var aux = ver.ListaDic.Where(w => w.Value == pAresta).Select(s => s.Key).FirstOrDefault();

            if (aux != null)
                return new List<Vertice>() { ver, aux };
        }

        return new List<Vertice>();
    }

    public Vertice? oposto(Vertice pVertice, Aresta pAresta)
    {
        return pVertice.ListaDic.Where(w => w.Value == pAresta).Select(s => s.Key).FirstOrDefault();
    }

    public List<Aresta> arestasE(Vertice pVertice)
    {
        List<Aresta> listaRetorno = new List<Aresta>();

        foreach (var ver in ListaVertices)
            listaRetorno.AddRange(ver.ListaDic.Where(w => w.Key == pVertice).Select(s => s.Value));


        return listaRetorno;
    }

    public List<Aresta> arestasS(Vertice pVertice)
    {
        return pVertice.ListaDic.Select(s => s.Value).ToList();
    }

    public void printGrafo()
    {
        foreach (var ver in ListaVertices)
        {
            foreach (var verLista in ver.ListaDic)
            {
                Console.WriteLine("O vértice: " + ver.Nome);
                Console.WriteLine("Está ligado no vértice: " + verLista.Key.Nome);
                Console.WriteLine("Pela aresta: " + verLista.Value.Nome);
                Console.WriteLine("\n");
            }
        }
    }

    public void BFS(Vertice pVertice)
    {
        foreach (var vertice in ListaVertices)
        {
            vertice.Cor = ECores.Branco;
            vertice.Predecessor = null;
            vertice.Distancia = 0;
        }

        pVertice.Distancia = 0;
        pVertice.Cor = ECores.Cinza;
        FilaVertices = new List<Vertice>();
        InsereFila(pVertice);

        while (FilaVertices.Any())
        {
            var auxVer = RemoveFila();

            foreach (var ver in adj(auxVer))
            {
                if (ver.Cor == ECores.Branco)
                {
                    InsereFila(ver);
                    ver.Cor = ECores.Cinza;
                    ver.Predecessor = auxVer;
                    ver.Distancia = auxVer.Distancia + 1;
                }
            }
            auxVer.Cor = ECores.Preto;
        }
    }

    public void ImprimeCaminho(Vertice pInicial, Vertice pFinal)
    {
        if (pInicial == pFinal)
            Console.WriteLine(pInicial.Nome);
        else
        {
            if (pFinal.Predecessor == null)
                Console.WriteLine("Não existe caminho de " + pInicial.Nome + "para" + pFinal.Nome);
            else
            {
                ImprimeCaminho(pInicial, pFinal.Predecessor);
                Console.WriteLine(pFinal.Nome);
            }
        }
    }

    public void DFS()
    {
        foreach (var vertice in ListaVertices)
        {
            vertice.Cor = ECores.Branco;
            vertice.Predecessor = null;
        }

        tempo = 0;

        foreach (var ver in ListaVertices)
        {
            if (ver.Cor == ECores.Branco)
            {
                DFSVisit(ver);
            }
        }
    }

    public void DFSVisit(Vertice pVertice)
    {
        pVertice.Cor = ECores.Cinza;
        tempo += 1;
        pVertice.Distancia = tempo;
        foreach (var v in adj(pVertice))
        {
            if (v.Cor == ECores.Branco)
            {
                v.Predecessor = pVertice;
                DFSVisit(v);
            }
        }

        pVertice.Cor = ECores.Preto;
        tempo += 1;
        pVertice.Fechamento = tempo;
    }

    public int GetCustoAresta(Vertice V, Vertice U)
    {
        var a = V.ListaDic.Where(f => f.Key == U).Select(s => s.Value).FirstOrDefault();
        if (a != null)
            return a.Custo;
        
        return 0;
    }

    public List<Vertice> Dijkstra(Vertice s)
    {
        foreach(var v in ListaVertices)
        {
            var aux = s.ListaDic.Where(f => f.Key == v).Select(s => s.Value).FirstOrDefault();
            if (aux != null)
                aux.Custo = int.MaxValue;
            v.Predecessor = null;
        }

        List<Vertice> S = new List<Vertice>();
        List<Vertice> Q = ListaVertices;

        while(Q.Any())
        {
            Vertice u = Q.First();

            foreach (var vAux in Q)
            {
                if (GetCustoAresta(s, vAux) < GetCustoAresta(s, u))
                    u = vAux;
            }

            S.Add(u);
            Q.Remove(u);

            foreach (var v in adj(u))
            {
                if (Q.Contains(v) && (GetCustoAresta(s, v) > GetCustoAresta(s, u) + GetCustoAresta(u, v)))
                {
                    var aux = s.ListaDic.Where(f => f.Key == v).Select(s => s.Value).FirstOrDefault();
                    if (aux != null)
                        aux.Custo = GetCustoAresta(s, u) + GetCustoAresta(u, v);
                    v.Predecessor = u;
                }
            }
        }

        return S;
    }

    public List<Aresta> Kruskal()
    {
        List<Aresta> T = new List<Aresta>();

        foreach (var v in ListaVertices)
        {
            CriaConjunto(v);
        }

        var listArestas = arestas().OrderBy(o => o.Custo);

        foreach (var aresta in listArestas)
        {
            var u = ListaVertices.Find(f => f.ListaDic.Any(a => a.Value == aresta));
            var v = u.ListaDic.Where(w => w.Value == aresta).Select(s => s.Key).FirstOrDefault();
            
            if (u != null && v != null && (BuscaConjunto(u) == BuscaConjunto(v)))
            {
                Uniao(u, v);
                T.Add(aresta);
            }
        }

        return T;
    }

    public void CriaConjunto(Vertice V)
    {
        V.Predecessor = V;
        V.Peso = 0;
    }

    public Vertice BuscaConjunto(Vertice V)
    {
        if (V != V.Predecessor)
            V.Predecessor = BuscaConjunto(V.Predecessor);
        
        return V.Predecessor;
    }

    public void Uniao(Vertice U, Vertice V)
    {
        Link(BuscaConjunto(U), BuscaConjunto(V));
    }

    public void Link(Vertice U, Vertice V)
    {
        if (U.Peso > V.Peso)
            V.Predecessor = U;
        else
        {
            U.Predecessor = V;
            if (U.Peso == V.Peso)
                V.Peso += 1;
        }
    }
}
