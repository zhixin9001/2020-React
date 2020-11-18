using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemOne.Trains
{
    class DirectedEdge
    {
        public DirectedEdge(int from, int to, double weight)
        {
            From = from;
            To = to;
            Weight = weight;            
        }

        public int From { get; }
        public int To { get; }
        public double Weight { get; }
    }
}

