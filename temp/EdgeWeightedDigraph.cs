using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemOne.Trains
{
    class EdgeWeightedDigraph
    {
        private int nodeCount;
        public int NodeCount { get => nodeCount; }

        private int edgeCount;
        public int EdgeCount { get => edgeCount; }

        private List<DirectedEdge>[] adjEdges;
        /// <summary>
        /// Adjacency Edges of nodes
        /// </summary>
        public List<DirectedEdge>[] AdjacencyEdges { get => adjEdges; }

        public EdgeWeightedDigraph(int nodeCount)
        {
            this.nodeCount = nodeCount;
            this.edgeCount = 0;
            adjEdges = new List<DirectedEdge>[nodeCount];
            for (int i = 0; i < this.nodeCount; i++)
            {
                adjEdges[i] = new List<DirectedEdge>();
            }
        }

        public void AddEdge(int from, int to, double weight)
        {
            var edge = new DirectedEdge(from, to, weight);
            adjEdges[from].Add(edge);
            edgeCount++;
        }
    }
}
