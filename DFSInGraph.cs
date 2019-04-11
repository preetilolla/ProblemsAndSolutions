using System;
using System.Collections.Generic;
using System.Text;

namespace PS
{
	class DFSInGraph
	{
		static public void Main()
		{
			Graph g = new Graph(4);
			g.AddEdge(0, 1);
			g.AddEdge(0, 2);
			g.AddEdge(2, 0);
			g.AddEdge(2, 3);
			g.AddEdge(3, 3);
			g.AddEdge(1, 2);

			Console.WriteLine("Below is the DFS Traversal..");
			DFS(g, 2); // 2 is the starting node
			Console.ReadKey();
		}

		public static void DFS(Graph g, int s)
		{
			bool[] visited = new bool[g.Vertices];

			DFSUtility(g, visited, s);
		}

		public static void DFSUtility(Graph g, bool[] visited, int s)
		{
			visited[s] = true;
			Console.Write(" > " + s);
			foreach (var v in g.Adj[s])
			{
				int n = v;
				if (!visited[n])
				{
					DFSUtility(g, visited, v);
				}
			}
		}
	}

	class Graph
	{
		int vertices;
		LinkedList<int>[] adj;

		public Graph(int v)
		{
			this.vertices = v;
			adj = new LinkedList<int>[v];
			for (int i = 0; i < adj.Length; i++)
			{
				adj[i] = new LinkedList<int>();
			}
		}

		public void AddEdge(int u, int v)
		{
			adj[u].AddLast(v);
		}

		public int Vertices
		{
			get { return vertices; }
			set { vertices = value; }
		}
		public LinkedList<int>[] Adj
		{
			get { return adj; }
			set { adj = value; }
		}
	}
}
