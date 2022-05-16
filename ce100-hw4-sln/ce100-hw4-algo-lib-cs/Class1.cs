/**
* @file ce100-hw4-algo-lib-cs
* @author Sema Nur Ersoy
* @date 16 May 2022
*
* @brief <b> HW-4 Functions </b>
*
* HW-4 Sample Lib Functions
*
* @see http://bilgisayar.mmf.erdogan.edu.tr/en/
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ce100_hw4_algo_lib_cs;

namespace ce100_hw4_algo_lib_cs
{
    public class Class1
    {
        public class ActivitySelection
        {

            /**
            *
            *	  @name   printMaxActivities (Print Activity Selection Problem)
            *	  @brief Print Activity Selection Problem
            *	  Print Activity Selection Problem
            *	  @param  [in] s [\b int]  s  
            *	  @param  [in] f [\b int]  f	  
            *	  @param  [in] n [\b int]  n
            *	  The activity selection problem is a mathematical optimization problem. 
            *     The objective is to find solution set having maximum number of non-conflicting activities that can be executed in a single time frame.
            *     Our first ill ustration is the problem of scheduling a resource among several challenge activities.
            *     We find a greedy algorithm provides a well designed and simple method for selecting a maximum- size set of manually compatible activities.  
            **/



            public static int printMaxActivities(int[] s, int[] f, int n)
            {
                int i, j;

                i = 0;

                for (j = 1; j < n; j++)
                {
                    if (s[j] >= f[i])
                    {
                        i = j;
                    }
                }

                return i;
            }

        }


        /**
        * **
        * 
        * @name knapSack
        * @param [in] arr [\b int[]] 
        * @param [in] low [\b int] 
        * @param [in] high [\b int]
        * The knapsack problem is a problem in combinatorial optimization.
        * The knapsack problem is an optimization problem used to illustrate both problem and solution.
        * It derives its name from a scenario where one is constrained in the number of items that can be placed inside a fixed-size knapsack
        * **
        **/
        public static int knapSack(int W, int[] wt,
                           int[] val, int n)
        {
            int i, w;
            int[,] K = new int[n + 1, W + 1];


            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;

                    else if (wt[i - 1] <= w)
                        K[i, w] = Math.Max(
                            val[i - 1]
                            + K[i - 1, w - wt[i - 1]],
                            K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            return K[n, W];
        }

        /**
        * **
        * 
        * @name printknapSack
        * @param [in] arr [\b string[]] 
        * @param [in] low [\b string] 
        * @param [in] high [\b string]
        * Given weights and values of n items, put these items in a knapsack of capacity W to get the maximum total value in the knapsack.
        * Also given an integer W which represents knapsack capacity, 
        * find out the items such that sum of the weights of those items of given subset is smaller than or equal to W.
        * **
        **/
        public static string printknapSack(int W, int[] wt,
                                int[] val, int n)
        {
            int i, w;
            string print = "";
            int[,] K = new int[n + 1, W + 1];

            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (wt[i - 1] <= w)
                        K[i, w] = Math.Max(val[i - 1] +
                                K[i - 1, w - wt[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }
            int res = K[n, W];



            w = W;
            for (i = n; i > 0 && res > 0; i--)
            {

                if (res == K[i - 1, w])
                    continue;
                else
                {

                    print += wt[i - 1] + ", ";

                    res = res - val[i - 1];
                    w = w - wt[i - 1];
                }
            }
            return print.Remove(print.Length - 2);
        }
        /**
        * **
        * 
        * @name GraphBf
        * @param [in] arr [\b int[]] 
        * @param [in] low [\b int] 
        * @param [in] high [\b int]
        * The Breadth First Search (BFS) is an algorithm for traversing or searching tree or graph data structures.
        * It explores all the nodes at the present depth before moving on to the nodes at the next depth level.
        * Pick a node and enqueue all its adjacent nodes into a queue.
        * Dequeue a node from the queue, mark it as visited and enqueue all its adjacent nodes into a queue.
        * Repeat this process until the queue is empty or you meet a goal.
        * Usually implemented using a queue data structure.

        * **
        **/
        public static int _V;
        public static LinkedList<int>[] _adj;

        public static void GraphBf(int V)
        {
            _adj = new LinkedList<int>[V];
            for (int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
            _V = V;
        }

        public static void AddEdgeBf(int v, int w)
        {
            _adj[v].AddLast(w);

        }

        public static string BFS(int s)
        {
            string bfs = "";
            bool[] visited = new bool[_V];
            for (int i = 0; i < _V; i++)
                visited[i] = false;

            LinkedList<int> queue = new LinkedList<int>();

            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any())
            {

                s = queue.First();
                bfs += s + ", ";
                queue.RemoveFirst();

                LinkedList<int> list = _adj[s];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
            return bfs.Remove(bfs.Length - 2);
        }



        /**
        * **
        * 
        * @name GraphDFS
        * @param [in] arr [\b int[]] 
        * @param [in] low [\b int] 
        * @param [in] high [\b int]
        * DFS, stands for Depth First Search.
        * DFS uses Stack to find the shortest path.
        * DFS starts the traversal from the root node and visits nodes as far as possible from the root node.
        * Usually implemented using a stack data structure.

        * **
        **/


        public static List<int>[] Adj;
        public static void GraphDFS(int v)
        {
            V = v;
            Adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                Adj[i] = new List<int>();
        }

        public static void AddEdgeDFS(int v, int w)
        {
            Adj[v].Add(w);
        }

        public static string dfs = "";

        public static void dfsUtil(int v, bool[] visited)
        {
            visited[v] = true;
            dfs += v + ", ";
            List<int> vList = Adj[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                    dfsUtil(n, visited);
            }
        }

        public static string DFS(int v)
        {
            bool[] visited = new bool[V];

            dfsUtil(v, visited);
            return dfs.Remove(dfs.Length - 2);
        }



        /**
        * **
        * 
        * @name Graph_TPL
        * @param [in] arr [\b int[]] 
        * @param [in] low [\b int] 
        * @param [in] high [\b int]
        * The topological sort algorithm takes a directed graph and returns an array of the nodes where each node appears before all the nodes it points to.
        * Topological sort gives a linear ordering of vertices in a directed acyclic graph such that.

        * **
        **/

        public static int V;
        public static List<List<int>> adj;
        public static void Graph_TPL(int v)
        {
            V = v;
            adj = new List<List<int>>(v);
            for (int i = 0; i < v; i++)
                adj.Add(new List<int>());
        }

        public static void AddEdge_TPL(int v, int w) { adj[v].Add(w); }

        public static void Topological_OrderUtil(int v, bool[] visited, Stack<int> stack)
        {

            visited[v] = true;

            foreach (var vertex in adj[v])
            {
                if (!visited[vertex])
                    Topological_OrderUtil(vertex, visited, stack);
            }
            stack.Push(v);
        }

        public static string Topological_Order()
        {
            Stack<int> stack = new Stack<int>();
            string tpl = "";

            var visited = new bool[V];

            for (int i = 0; i < V; i++)
            {
                if (visited[i] == false)
                    Topological_OrderUtil(i, visited, stack);
            }

            foreach (var vertex in stack)
            {
                tpl += vertex + ", ";
            }
            return tpl.Remove(tpl.Length - 2);
        }

        /**
          *
          *	  @name   SCCProblem (SCC Function)
          *	  @brief SCC Function
          *	  SCC Function
          *	  @param  [in] v [\b int]  v
          *	  A directed graph is called strongly connected if there is a path in each direction between each pair of vertices of the graph.
          *   That is, a path exists from the first vertex in the pair to the second, and another path exists from the second vertex to the first.
          *	  
          **/

        public class SCCProblem
        {
            private int V;
            private LinkedList<int>[] adj;
            private int Time;
            public void addEdge(int v, int w)
            {
                adj[v].AddLast(w);
            }

           

            public SCCProblem(int v)
            {
                V = v;
                adj = new LinkedList<int>[v];
                for (int i = 0; i < v; i++)
                {
                    adj[i] = new LinkedList<int>();
                }
            }
            public void SCCUtil(int u, int[] low, int[] disc, bool[] stackMember, Stack<int> stack)
            {
                low[u] = disc[u] = Time++;
                stack.Push(u);
                stackMember[u] = true;
                foreach (int v in adj[u])
                {
                    if (disc[v] == -1)
                    {
                        SCCUtil(v, low, disc, stackMember, stack);
                        low[u] = Math.Min(low[u], low[v]);
                    }
                    else if (stackMember[v])
                    {
                        low[u] = Math.Min(low[u], disc[v]);
                    }
                }
                if (low[u] == disc[u])
                {
                    int v;
                    do
                    {
                        v = stack.Pop();
                        stackMember[v] = false;
                    } while (v != u);
                }
            }
            public int SCC()
            {
                int[] low = new int[V];
                int[] disc = new int[V];
                bool[] stackMember = new bool[V];
                Stack<int> stack = new Stack<int>();
                for (int i = 0; i < V; i++)
                {
                    disc[i] = -1;
                    low[i] = -1;
                }
                for (int i = 0; i < V; i++)
                {
                    if (disc[i] == -1)
                    {
                        SCCUtil(i, low, disc, stackMember, stack);
                    }
                }
                return 0;
            }
        }
    }
}