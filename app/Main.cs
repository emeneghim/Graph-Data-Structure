using System;
using System.Collections.Generic;
using System.Linq;

using static Grafo;
using static Vertice;
using static Aresta;

public class MainProgram
{
    public static void Main(string[] args)
    {
        int testeAtual = 5;

        if (testeAtual == 1)
            MainProgram.MainBuscaLargura();
        else if (testeAtual == 2)
            MainProgram.MainBuscaProfundidade();
        else if (testeAtual == 3)
            MainProgram.MainEstrutura();
        else if (testeAtual == 4)
            MainProgram.MainDijkstra();
        else if (testeAtual == 5)
            MainProgram.MainKruskal();
    }

    public static void MainBuscaLargura()
    {
        //-------------------- Grafo não dirigido --------------------

        GrafoNaoDirigido GraNaoDirigido = new GrafoNaoDirigido();
        GraNaoDirigido.ListaVertices = new List<Vertice>();

        Console.WriteLine("Instanciando Vértices e Arestas\n");

        Vertice vA = new Vertice() { Nome = "vA" };
        Vertice vB = new Vertice() { Nome = "vB" };
        Vertice vC = new Vertice() { Nome = "vC" };
        Vertice vD = new Vertice() { Nome = "vD" };
        Vertice vE = new Vertice() { Nome = "vE" };
        Vertice vF = new Vertice() { Nome = "vF" };
        Aresta aA = new Aresta() { Nome = "aA" };
        Aresta aB = new Aresta() { Nome = "aB" };
        Aresta aC = new Aresta() { Nome = "aC" };
        Aresta aD = new Aresta() { Nome = "aD" };
        Aresta aE = new Aresta() { Nome = "aE" };
        Aresta aF = new Aresta() { Nome = "aF" };

        Console.WriteLine("Inserindo vértices no grafo e ligando-os pelas arestas\n");

        GraNaoDirigido.insereV(vA);
        GraNaoDirigido.insereV(vB);
        GraNaoDirigido.insereV(vC);
        GraNaoDirigido.insereV(vD);
        GraNaoDirigido.insereV(vE);
        GraNaoDirigido.insereV(vF);

        GraNaoDirigido.insereA(vA, vB, aA);
        GraNaoDirigido.insereA(vB, vC, aB);
        GraNaoDirigido.insereA(vC, vD, aC);
        GraNaoDirigido.insereA(vD, vE, aD);
        GraNaoDirigido.insereA(vE, vF, aE);
        GraNaoDirigido.insereA(vF, vA, aF);

        Console.WriteLine("Esse é o grafo não-dirigido: \n");
        GraNaoDirigido.printGrafo();

        Console.WriteLine("Busca a partir do vértice A: \n");
        GraNaoDirigido.BFS(vA);
        GraNaoDirigido.ImprimeCaminho(vA, vE);

        Console.WriteLine("-------------------------------------------");

        //-------------------- Grafo dirigido --------------------

        Console.WriteLine("Instanciando Grafo Dirigido\n");
        GrafoDirigido GraDirigido = new GrafoDirigido();
        GraDirigido.ListaVertices = new List<Vertice>();


        Console.WriteLine("Instanciando Vértices e Arestas\n");

        Vertice vU = new Vertice() { Nome = "vU" };
        Vertice vV = new Vertice() { Nome = "vV" };
        Vertice vW = new Vertice() { Nome = "vW" };
        Vertice vX = new Vertice() { Nome = "vX" };
        Vertice vY = new Vertice() { Nome = "vY" };
        Vertice vZ = new Vertice() { Nome = "vZ" };
        Aresta aU = new Aresta() { Nome = "aU" };
        Aresta aV = new Aresta() { Nome = "aV" };
        Aresta aW = new Aresta() { Nome = "aW" };
        Aresta aX = new Aresta() { Nome = "aX" };
        Aresta aY = new Aresta() { Nome = "aY" };
        Aresta aZ = new Aresta() { Nome = "aZ" };

        Console.WriteLine("Inserindo vértices no grafo e ligando-os pelas arestas\n");

        GraDirigido.insereV(vU);
        GraDirigido.insereV(vV);
        GraDirigido.insereV(vW);
        GraDirigido.insereV(vX);
        GraDirigido.insereV(vY);
        GraDirigido.insereV(vZ);

        GraDirigido.insereA(vU, vV, aU);
        GraDirigido.insereA(vV, vW, aV);
        GraDirigido.insereA(vW, vX, aW);
        GraDirigido.insereA(vX, vY, aX);
        GraDirigido.insereA(vY, vZ, aY);
        GraDirigido.insereA(vZ, vU, aZ);

        Console.WriteLine("Esse é o grafo dirigido: \n");
        GraDirigido.printGrafo();

        Console.WriteLine("Busca a partir do vértice U: \n");
        GraDirigido.BFS(vU);
        GraDirigido.ImprimeCaminho(vU, vY);
    }

    public static void MainBuscaProfundidade()
    {
        //-------------------- Grafo não dirigido --------------------

        GrafoNaoDirigido GraNaoDirigido = new GrafoNaoDirigido();
        GraNaoDirigido.ListaVertices = new List<Vertice>();

        Console.WriteLine("Instanciando Vértices e Arestas\n");

        Vertice vA = new Vertice() { Nome = "vA" };
        Vertice vB = new Vertice() { Nome = "vB" };
        Vertice vC = new Vertice() { Nome = "vC" };
        Vertice vD = new Vertice() { Nome = "vD" };
        Vertice vE = new Vertice() { Nome = "vE" };
        Vertice vF = new Vertice() { Nome = "vF" };
        Aresta aA = new Aresta() { Nome = "aA" };
        Aresta aB = new Aresta() { Nome = "aB" };
        Aresta aC = new Aresta() { Nome = "aC" };
        Aresta aD = new Aresta() { Nome = "aD" };
        Aresta aE = new Aresta() { Nome = "aE" };
        Aresta aF = new Aresta() { Nome = "aF" };

        Console.WriteLine("Inserindo vértices no grafo e ligando-os pelas arestas\n");

        GraNaoDirigido.insereV(vA);
        GraNaoDirigido.insereV(vB);
        GraNaoDirigido.insereV(vC);
        GraNaoDirigido.insereV(vD);
        GraNaoDirigido.insereV(vE);
        GraNaoDirigido.insereV(vF);

        GraNaoDirigido.insereA(vA, vB, aA);
        GraNaoDirigido.insereA(vB, vC, aB);
        GraNaoDirigido.insereA(vC, vD, aC);
        GraNaoDirigido.insereA(vD, vE, aD);
        GraNaoDirigido.insereA(vE, vF, aE);
        GraNaoDirigido.insereA(vF, vA, aF);

        Console.WriteLine("Esse é o grafo não-dirigido: \n");
        GraNaoDirigido.printGrafo();

        Console.WriteLine("Caminho do vértice A até o vértice E: \n");
        GraNaoDirigido.DFS();
        GraNaoDirigido.ImprimeCaminho(vA, vE);

        Console.WriteLine("-------------------------------------------");

        //-------------------- Grafo dirigido --------------------

        Console.WriteLine("Instanciando Grafo Dirigido\n");
        GrafoDirigido GraDirigido = new GrafoDirigido();
        GraDirigido.ListaVertices = new List<Vertice>();


        Console.WriteLine("Instanciando Vértices e Arestas\n");

        Vertice vU = new Vertice() { Nome = "vU" };
        Vertice vV = new Vertice() { Nome = "vV" };
        Vertice vW = new Vertice() { Nome = "vW" };
        Vertice vX = new Vertice() { Nome = "vX" };
        Vertice vY = new Vertice() { Nome = "vY" };
        Vertice vZ = new Vertice() { Nome = "vZ" };
        Aresta aU = new Aresta() { Nome = "aU" };
        Aresta aV = new Aresta() { Nome = "aV" };
        Aresta aW = new Aresta() { Nome = "aW" };
        Aresta aX = new Aresta() { Nome = "aX" };
        Aresta aY = new Aresta() { Nome = "aY" };
        Aresta aZ = new Aresta() { Nome = "aZ" };

        Console.WriteLine("Inserindo vértices no grafo e ligando-os pelas arestas\n");

        GraDirigido.insereV(vU);
        GraDirigido.insereV(vV);
        GraDirigido.insereV(vW);
        GraDirigido.insereV(vX);
        GraDirigido.insereV(vY);
        GraDirigido.insereV(vZ);

        GraDirigido.insereA(vU, vV, aU);
        GraDirigido.insereA(vV, vW, aV);
        GraDirigido.insereA(vW, vX, aW);
        GraDirigido.insereA(vX, vY, aX);
        GraDirigido.insereA(vY, vZ, aY);
        GraDirigido.insereA(vZ, vU, aZ);

        Console.WriteLine("Esse é o grafo dirigido: \n");
        GraDirigido.printGrafo();

        Console.WriteLine("Caminho do vértice U até o vértice Y: \n");
        GraDirigido.DFS();
        GraDirigido.ImprimeCaminho(vU, vY);
    }

    public static void MainEstrutura()
    {
        Console.WriteLine("Instanciando Grafo não dirigido\n");
        GrafoNaoDirigido GraNaoDirigido = new GrafoNaoDirigido();
        GraNaoDirigido.ListaVertices = new List<Vertice>();

        Console.WriteLine("Instanciando Vértices e Arestas\n");

        Vertice vA = new Vertice() { Nome = "vA" };
        Vertice vB = new Vertice() { Nome = "vB" };
        Vertice vC = new Vertice() { Nome = "vC" };
        Vertice vD = new Vertice() { Nome = "vD" };
        Vertice vE = new Vertice() { Nome = "vE" };
        Vertice vF = new Vertice() { Nome = "vF" };
        Aresta aA = new Aresta() { Nome = "aA" };
        Aresta aB = new Aresta() { Nome = "aB" };
        Aresta aC = new Aresta() { Nome = "aC" };
        Aresta aD = new Aresta() { Nome = "aD" };
        Aresta aE = new Aresta() { Nome = "aE" };
        Aresta aF = new Aresta() { Nome = "aF" };

        Console.WriteLine("Inserindo vértices no grafo e ligando-os pelas arestas\n");

        GraNaoDirigido.insereV(vA);
        GraNaoDirigido.insereV(vB);
        GraNaoDirigido.insereV(vC);
        GraNaoDirigido.insereV(vD);
        GraNaoDirigido.insereV(vE);
        GraNaoDirigido.insereV(vF);

        GraNaoDirigido.insereA(vA, vB, aA);
        GraNaoDirigido.insereA(vB, vC, aB);
        GraNaoDirigido.insereA(vC, vD, aC);
        GraNaoDirigido.insereA(vD, vE, aD);
        GraNaoDirigido.insereA(vE, vF, aE);
        GraNaoDirigido.insereA(vF, vA, aF);

        Console.WriteLine("Esse é o grafo não-dirigido: \n");
        GraNaoDirigido.printGrafo();

        Console.WriteLine("Funções auxiliares utilizadas: \n");

        Console.WriteLine("getOrdem(): " + GraNaoDirigido.getOrdem());
        Console.WriteLine("getTamanho(): " + GraNaoDirigido.getTamanho());
        Console.WriteLine("vertices(): " + GraNaoDirigido.vertices());
        Console.WriteLine("arestas(): " + GraNaoDirigido.arestas());
        Console.WriteLine("adj(vA):");
        foreach (var item in GraNaoDirigido.adj(vA))
        {
            Console.WriteLine("     Vértice adjacente a vU: " + item.Nome);
        }

        Console.WriteLine("getA(vA,vB): " + GraNaoDirigido.getA(vA, vB)?.Nome);
        Console.WriteLine("getA(vA,vD): " + GraNaoDirigido.getA(vA, vD)?.Nome);

        Console.WriteLine("grauE(vA): " + GraNaoDirigido.grauE(vA));
        Console.WriteLine("grauS(vA): " + GraNaoDirigido.grauS(vA));
        Console.WriteLine("grauE(vD): " + GraNaoDirigido.grauE(vD));
        Console.WriteLine("grauS(vD): " + GraNaoDirigido.grauS(vD));

        Console.WriteLine("grau(vC): " + GraNaoDirigido.grau(vC));


        Console.WriteLine("verticesA(aA): ");
        foreach (var ver in GraNaoDirigido.verticesA(aA))
        {
            Console.WriteLine("     vértices de aA: " + ver.Nome);
        }

        Console.WriteLine("verticesA(aF): ");
        foreach (var ver in GraNaoDirigido.verticesA(aF))
        {
            Console.WriteLine("     vértices de aF: " + ver.Nome);
        }

        Console.WriteLine("oposto(vA,aA): " + GraNaoDirigido.oposto(vA, aA)?.Nome);
        Console.WriteLine("oposto(vA,aC): " + GraNaoDirigido.oposto(vA, aC)?.Nome);

        Console.WriteLine("arestasE(vA): ");
        foreach (var aresta in GraNaoDirigido.arestasE(vA))
        {
            Console.WriteLine("     Arestas de Entrada do vértice vA:" + aresta.Nome);
        }

        Console.WriteLine("Removendo as arestas aB e aF e imprimindo o grafo: ");
        GraNaoDirigido.removeA(aB);
        GraNaoDirigido.removeA(aF);
        GraNaoDirigido.printGrafo();

        Console.WriteLine("Removendo os vértices vC e vE, suas respectivas arestas e imprimindo o grafo:");
        GraNaoDirigido.removeV(vC);
        GraNaoDirigido.removeV(vE);
        GraNaoDirigido.printGrafo();



        Console.WriteLine("-----------------------------------------------------------------------------------");

        Console.WriteLine("Instanciando Grafo\n");
        GrafoDirigido GraDirigido = new GrafoDirigido();
        GraDirigido.ListaVertices = new List<Vertice>();


        Console.WriteLine("Instanciando Vértices e Arestas\n");

        Vertice vU = new Vertice() { Nome = "vU" };
        Vertice vV = new Vertice() { Nome = "vV" };
        Vertice vW = new Vertice() { Nome = "vW" };
        Vertice vX = new Vertice() { Nome = "vX" };
        Vertice vY = new Vertice() { Nome = "vY" };
        Vertice vZ = new Vertice() { Nome = "vZ" };
        Aresta aU = new Aresta() { Nome = "aU" };
        Aresta aV = new Aresta() { Nome = "aV" };
        Aresta aW = new Aresta() { Nome = "aW" };
        Aresta aX = new Aresta() { Nome = "aX" };
        Aresta aY = new Aresta() { Nome = "aY" };
        Aresta aZ = new Aresta() { Nome = "aZ" };

        Console.WriteLine("Inserindo vértices no grafo e ligando-os pelas arestas\n");

        GraDirigido.insereV(vU);
        GraDirigido.insereV(vV);
        GraDirigido.insereV(vW);
        GraDirigido.insereV(vX);
        GraDirigido.insereV(vY);
        GraDirigido.insereV(vZ);

        GraDirigido.insereA(vU, vV, aU);
        GraDirigido.insereA(vV, vW, aV);
        GraDirigido.insereA(vW, vX, aW);
        GraDirigido.insereA(vX, vY, aX);
        GraDirigido.insereA(vY, vZ, aY);
        GraDirigido.insereA(vZ, vU, aZ);

        Console.WriteLine("Esse é o grafo dirigido: \n");
        GraDirigido.printGrafo();

        Console.WriteLine("Funções auxiliares utilizadas: \n");

        Console.WriteLine("getOrdem(): " + GraDirigido.getOrdem());
        Console.WriteLine("getTamanho(): " + GraDirigido.getTamanho());
        Console.WriteLine("vertices(): " + GraDirigido.vertices());
        Console.WriteLine("arestas(): " + GraDirigido.arestas());
        Console.WriteLine("adj(vU):");
        foreach (var item in GraDirigido.adj(vU))
        {
            Console.WriteLine("    Vértice adjacente a vU: " + item.Nome);
        }

        Console.WriteLine("getA(vU,vV): " + GraDirigido.getA(vU, vV)?.Nome);
        Console.WriteLine("getA(vU,vX): " + GraDirigido.getA(vU, vX)?.Nome);

        Console.WriteLine("grauE(vU): " + GraDirigido.grauE(vU));
        Console.WriteLine("grauS(vU): " + GraDirigido.grauS(vU));
        Console.WriteLine("grauE(vX): " + GraDirigido.grauE(vX));
        Console.WriteLine("grauS(vX): " + GraDirigido.grauS(vX));

        Console.WriteLine("verticesA(aU): ");
        foreach (var ver in GraDirigido.verticesA(aU))
        {
            Console.WriteLine("    vértices de aU: " + ver.Nome);
        }

        Console.WriteLine("verticesA(aZ): ");
        foreach (var ver in GraDirigido.verticesA(aZ))
        {
            Console.WriteLine("    vértices de aZ: " + ver.Nome);
        }

        Console.WriteLine("oposto(vU,aU): " + GraDirigido.oposto(vU, aU)?.Nome);
        Console.WriteLine("oposto(vU,aW): " + GraDirigido.oposto(vU, aW)?.Nome);

        Console.WriteLine("arestasE(vU): ");
        foreach (var aresta in GraDirigido.arestasE(vU))
        {
            Console.WriteLine("Arestas de Entrada do vértice vU:" + aresta.Nome);
        }

        Console.WriteLine("Removendo as arestas aV e aZ e imprimindo o grafo: ");
        GraDirigido.removeA(aV);
        GraDirigido.removeA(aZ);
        GraDirigido.printGrafo();

        Console.WriteLine("Removendo os vértices vW e vY, suas respectivas arestas e imprimindo o grafo:");
        GraDirigido.removeV(vW);
        GraDirigido.removeV(vY);
        GraDirigido.printGrafo();
    }

    public static void MainDijkstra()
    {
        GrafoNaoDirigido GraNaoDirigido = new GrafoNaoDirigido();
        GraNaoDirigido.ListaVertices = new List<Vertice>();

        Console.WriteLine("Instanciando Vértices e Arestas\n");

        Vertice vA = new Vertice() { Nome = "vA" };
        Vertice vB = new Vertice() { Nome = "vB" };
        Vertice vC = new Vertice() { Nome = "vC" };
        Vertice vD = new Vertice() { Nome = "vD" };
        Vertice vE = new Vertice() { Nome = "vE" };
        Vertice vF = new Vertice() { Nome = "vF" };
        Vertice vG = new Vertice() { Nome = "vG" };
        Vertice vH = new Vertice() { Nome = "vH" };

        Aresta aAB = new Aresta() { Nome = "aAB", Custo = 5 };
        Aresta aAF = new Aresta() { Nome = "aAF", Custo = 4 };
        Aresta aBF = new Aresta() { Nome = "aBF", Custo = 5 };
        Aresta aBC = new Aresta() { Nome = "aBC", Custo = 4 };
        Aresta aBG = new Aresta() { Nome = "aBG", Custo = 15 };
        Aresta aCD = new Aresta() { Nome = "aCD", Custo = 15 };
        Aresta aCH = new Aresta() { Nome = "aCH", Custo = 9 };
        Aresta aCE = new Aresta() { Nome = "aCE", Custo = 8 };
        Aresta aDH = new Aresta() { Nome = "aDH", Custo = 3 };
        Aresta aGE = new Aresta() { Nome = "aGE", Custo = 2 };
        Aresta aGH = new Aresta() { Nome = "aGH", Custo = 9 };
        Aresta aEH = new Aresta() { Nome = "aEH", Custo = 11 };

        Console.WriteLine("Inserindo vértices no grafo e ligando-os pelas arestas\n");

        GraNaoDirigido.insereV(vA);
        GraNaoDirigido.insereV(vB);
        GraNaoDirigido.insereV(vC);
        GraNaoDirigido.insereV(vD);
        GraNaoDirigido.insereV(vE);
        GraNaoDirigido.insereV(vF);
        GraNaoDirigido.insereV(vG);
        GraNaoDirigido.insereV(vH);

        GraNaoDirigido.insereA(vA, vB, aAB);
        GraNaoDirigido.insereA(vA, vF, aAF);
        GraNaoDirigido.insereA(vB, vC, aBC);
        GraNaoDirigido.insereA(vB, vG, aBG);
        GraNaoDirigido.insereA(vB, vF, aBF);
        GraNaoDirigido.insereA(vC, vD, aCD);
        GraNaoDirigido.insereA(vC, vE, aCE);
        GraNaoDirigido.insereA(vC, vH, aCH);
        GraNaoDirigido.insereA(vD, vH, aDH);
        GraNaoDirigido.insereA(vE, vH, aEH);
        GraNaoDirigido.insereA(vE, vG, aGE);
        GraNaoDirigido.insereA(vG, vH, aGH);

        Console.WriteLine("Esse é o grafo não-dirigido: \n");
        GraNaoDirigido.printGrafo();

        Console.WriteLine("\n\n\n");
        var listaDijkstra = GraNaoDirigido.Dijkstra(vB);

        foreach (var vertice in listaDijkstra)
        {
            Console.WriteLine("Nome: " + vertice.Nome + '\n');
            Console.WriteLine("Predecessor: " + vertice.Predecessor + '\n');
            // Console.WriteLine("Custo: " + vertice.Custo + "\n\n");
        }
    }

    public static void MainKruskal()
    {
        GrafoNaoDirigido GraNaoDirigido = new GrafoNaoDirigido();
        GraNaoDirigido.ListaVertices = new List<Vertice>();

        Console.WriteLine("Instanciando Vértices e Arestas\n");

        Vertice vA = new Vertice() { Nome = "vA" };
        Vertice vB = new Vertice() { Nome = "vB" };
        Vertice vC = new Vertice() { Nome = "vC" };
        Vertice vD = new Vertice() { Nome = "vD" };
        Vertice vE = new Vertice() { Nome = "vE" };
        Vertice vF = new Vertice() { Nome = "vF" };
        Vertice vG = new Vertice() { Nome = "vG" };

        Aresta aAB = new Aresta() { Nome = "aAB", Custo = 14 };
        Aresta aAE = new Aresta() { Nome = "aAE", Custo = 3 };
        Aresta aAD = new Aresta() { Nome = "aAD", Custo = 4 };
        Aresta aBC = new Aresta() { Nome = "aBC", Custo = 10 };
        Aresta aBD = new Aresta() { Nome = "aBD", Custo = 8 };
        Aresta aBG = new Aresta() { Nome = "aBG", Custo = 2 };
        Aresta aCG = new Aresta() { Nome = "aCG", Custo = 13 };
        Aresta aDG = new Aresta() { Nome = "aDG", Custo = 6 };
        Aresta aDE = new Aresta() { Nome = "aDE", Custo = 9 };
        Aresta aDF = new Aresta() { Nome = "aDF", Custo = 2 };
        Aresta aEF = new Aresta() { Nome = "aEF", Custo = 8 };
        Aresta aFG = new Aresta() { Nome = "aFG", Custo = 8 };

        Console.WriteLine("Inserindo vértices no grafo e ligando-os pelas arestas\n");

        GraNaoDirigido.insereV(vA);
        GraNaoDirigido.insereV(vB);
        GraNaoDirigido.insereV(vC);
        GraNaoDirigido.insereV(vD);
        GraNaoDirigido.insereV(vE);
        GraNaoDirigido.insereV(vF);
        GraNaoDirigido.insereV(vG);

        GraNaoDirigido.insereA(vA, vB, aAB);
        GraNaoDirigido.insereA(vA, vE, aAE);
        GraNaoDirigido.insereA(vA, vD, aAD);
        GraNaoDirigido.insereA(vB, vC, aBC);
        GraNaoDirigido.insereA(vB, vD, aBD);
        GraNaoDirigido.insereA(vB, vG, aBG);
        GraNaoDirigido.insereA(vC, vG, aCG);
        GraNaoDirigido.insereA(vD, vG, aDG);
        GraNaoDirigido.insereA(vD, vE, aDE);
        GraNaoDirigido.insereA(vD, vF, aDF);
        GraNaoDirigido.insereA(vE, vF, aEF);
        GraNaoDirigido.insereA(vG, vF, aFG);

        Console.WriteLine("Esse é o grafo não-dirigido: \n");
        GraNaoDirigido.printGrafo();

        Console.WriteLine("\n\n\n");

        var Kruskal = GraNaoDirigido.Kruskal();

        foreach (var aresta in Kruskal)
        {
            Console.WriteLine("Nome: " + aresta.Nome);
            Console.WriteLine("Custo: " + aresta.Custo);
        }
    }
}

