using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class VertexTriangle
    {
        Vertex v1, v2, v3;
        public VertexTriangle(Vertex v1, Vertex v2, Vertex v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public bool Equals(Vertex u1, Vertex u2, Vertex u3)
        {
            return ((u1 == v1 || u1 == v2 || u1 == v3) && (u2 == v1 || u2 == v2 || u2 == v3) && (u3 == v1 || u3 == v2 || u3 == v3));
        }

        public override string ToString()
        {
            return v1 + " " + v2 + " " + v3;
        }
    }
    class VertexTriangleList : IEnumerable
    {
        List<VertexTriangle> triangles = new List<VertexTriangle>();

        public void Add(Vertex v1, Vertex v2, Vertex v3)
        {
            triangles.Add(new VertexTriangle(v1, v2, v3));
        }

        public bool Contains(Vertex v1, Vertex v2, Vertex v3)
        {
            foreach (VertexTriangle t in triangles)
            {
                if (t.Equals(v1, v2, v3))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerator GetEnumerator()
        {
            return triangles.GetEnumerator();
        }
    }
}