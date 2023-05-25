using System;
using System.Diagnostics;

 class DFSApp
{
    public static void Main(String[] args)
    {

        Graph theGraph = new Graph();
        //theGraph.addVertex(1);
        //theGraph.addVertex(2);
        //theGraph.addVertex(3);
        //theGraph.addVertex(4);
        //theGraph.addVertex(5);
        //theGraph.addVertex(6);
        Stopwatch v = Stopwatch.StartNew();
        theGraph.CreateArray(15000, 0.5);
        v.Stop();
        Console.WriteLine("Elapsed Time: {0} ms", v.ElapsedMilliseconds);
        //theGraph.addEdge(0, 1);
        //theGraph.addEdge(1, 2);
        //theGraph.addEdge(0, 3);
        //theGraph.addEdge(3, 4);
        //theGraph.addEdge(4, 5);
        //theGraph.addEdge(1, 3);

        //Console.WriteLine("Visits: ");
        Stopwatch s = Stopwatch.StartNew();
        theGraph.dfs();
        s.Stop();
        Console.WriteLine("Elapsed Time: {0} ms", s.ElapsedMilliseconds);
    }


    
  

}