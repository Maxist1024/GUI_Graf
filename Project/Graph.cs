using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Vertex
    {
        List<Vertex> edges;
        string name;

        public Vertex(string name)
        {
            this.name = name;
            this.edges = new List<Vertex>();
        }

        public void AddEdge(Vertex toVertex)
        {
            edges.Add(toVertex);
        }

        public bool HasEdgeTo(Vertex v)
        {
            return edges.Contains(v);
        }

        public List<Vertex> GetEdges()
        {
            return edges;
        }

        public string GetName()
        {
            return name;
        }

        public Vertex Clone()
        {
            Vertex v = new Vertex(name);
            foreach (Vertex e in edges)
            {
                v.AddEdge(e);
            }
            return v;
        }

        public override string ToString()
        {
            return GetName();
        }
    }
    class Graph
    {
        Vertex[] vertexes;

        public Graph(params Vertex[] v)
        {
            vertexes = v;
        }


        /*  Warunek spójności grafu:
            Graf skierowany jest spójny, jeżeli graf podstawowy (ten sam graf bez kierunków na krawędziach) jest spójny.
            Poczynając od ustalonego wierzchołka, przechodząc w głąb grafu liczymy wierzchołki. Jeśli liczba wierzchołków
            przez które przeszliśmy jest równa liczbie wszystkich wierzchołków w grafie to graf jest spójny.
        */
        public bool IsCoherent()
        {
            Vertex[] undirectedGraph = GetUndirectedGraph();

            int n = undirectedGraph.Length;
            Dictionary<Vertex, bool> visited = new Dictionary<Vertex, bool>();
            foreach (Vertex v in undirectedGraph) visited.Add(v, false);

            int a = 0;
            CountDFS(undirectedGraph[0], visited, ref a);

            return n == a;
        }

        private Vertex[] GetUndirectedGraph()
        {
            Vertex[] undirectedGraph = new Vertex[vertexes.Length];

            for (int i = 0; i < vertexes.Length; i++)
            {
                undirectedGraph[i] = vertexes[i].Clone();
            }

            foreach (Vertex v in undirectedGraph)
            {
                foreach (Vertex u in v.GetEdges())
                {
                    if (!u.HasEdgeTo(v)) u.AddEdge(v);
                }
            }

            return undirectedGraph;
        }

        private void CountDFS(Vertex v, Dictionary<Vertex, bool> visited, ref int c)
        {
            c++;
            visited[v] = true;

            foreach (Vertex u in v.GetEdges())
            {
                if (!visited[u]) CountDFS(u, visited, ref c);
            }
        }

        public VertexTriangleList FindTriangles()
        {
            VertexTriangleList triangles = new VertexTriangleList();

            foreach (Vertex v in vertexes)
            {
                Stack stack = new Stack();
                FindTrianglesDFS(triangles, v, v, stack);
            }

            return triangles;
        }

        private void FindTrianglesDFS(VertexTriangleList triangles, Vertex startVertex, Vertex currentVertex, Stack stack)
        {
            if (stack.Count < 3)
            {
                stack.Push(currentVertex);
                foreach (Vertex v in currentVertex.GetEdges())
                {
                    FindTrianglesDFS(triangles, startVertex, v, stack);
                }
                stack.Pop();
            }
            else if (stack.Count == 3 && currentVertex == startVertex)
            {
                //Znaleziono nowy trójkąt
                Array array = stack.ToArray();
                Vertex v1 = (Vertex)array.GetValue(0);
                Vertex v2 = (Vertex)array.GetValue(1);
                Vertex v3 = (Vertex)array.GetValue(2);

                if (!triangles.Contains(v1, v2, v3)) triangles.Add(v3, v2, v1);
            }
        }
    }
}