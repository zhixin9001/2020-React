using System;
using System.IO;

namespace ProblemOne.Trains
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = (int)'A';
            new GetEdgesFromInput(new ASCIINodeNameConverter());
            Console.WriteLine("Hello World!");
        }
    }

    interface INodeNameConverter
    {
        int ConvertToIndex(char node);
    }

    class ASCIINodeNameConverter : INodeNameConverter
    {
        private const int DIFF = 65;
        public int ConvertToIndex(char node)
        {
            return node - DIFF;
        }
    }

    class GetEdgesFromInput
    {
        public GetEdgesFromInput(INodeNameConverter nodeNameConverter)
        {
            try
            {
                var input = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "TestData.txt"));
                //todo check
                var splited = input.Split(",");
                for (int i = 0; i < splited.Length; i++)
                {
                    var charArray = splited[i].Trim().ToCharArray();
                    var edge = new DirectedEdge(
                                    from: nodeNameConverter.ConvertToIndex(charArray[0]),
                                    to: nodeNameConverter.ConvertToIndex(charArray[1]),
                                    weight: Convert.ToDouble(charArray[2].ToString()));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Read from txt failed, {e.Message}");
            }
        }
    }
}
