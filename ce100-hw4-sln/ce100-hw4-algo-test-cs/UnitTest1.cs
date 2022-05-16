using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw4_algo_lib_cs;
using static ce100_hw4_algo_lib_cs.Class1;

namespace ce100_hw4_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void activity_selection_test_1()
        {
            int[] s = { 1, 3, 0, 5, 8, 5 };

            int[] f = { 2, 4, 6, 7, 9, 9 };
            int n = s.Length;

            int act = ActivitySelection.printMaxActivities(s, f, n);
            int res = 4;
            Assert.AreEqual(act, res);
        }

        [TestMethod]
        public void activity_selection_test_2()
        {
            int[] s = { 47, 453, 123, 78635, 1, 85 };

            int[] f = { 47, 64513, 2123, 789, 23, 12 };
            int n = s.Length;

            int act = ActivitySelection.printMaxActivities(s, f, n);
            int res = 3;
            Assert.AreEqual(act, res);
        }

        [TestMethod]
        public void activity_selection_test_3()
        {
            int[] s = { 653, 65, 645, 879, 132, 653 };

            int[] f = { 89465, 6513, 5367, 147, 51, 54 };
            int n = s.Length;

            int act = ActivitySelection.printMaxActivities(s, f, n);
            int res = 0;
            Assert.AreEqual(act, res);
        }

        [TestMethod]
        public void knapSack0_1Test1()
        {

            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 50;
            int n = val.Length;
            int result = Class1.knapSack(W, wt, val, n);
            int expected = 220;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void knapSack0_1Test2()
        {

            int[] val = new int[] { 70, 360, 420 };
            int[] wt = new int[] { 10, 40, 50 };
            int W = 50;
            int n = val.Length;
            int result = Class1.knapSack(W, wt, val, n);
            int expected = 430;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void knapSack0_1Test3()
        {

            int[] val = new int[] { 50, 300, 620 };
            int[] wt = new int[] { 40, 50, 90 };
            int W = 90;
            int n = val.Length;
            int result = Class1.knapSack(W, wt, val, n);
            int expected = 620;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void printknapSacktest_1()
        {
            int[] val = { 60, 100, 120 };
            int[] wt = { 10, 20, 30 };
            int W = 50;
            int n = val.Length;
            string result = Class1.printknapSack(W, wt, val, n);
            string expected = "30, 20";
            Assert.AreEqual(expected, result);



        }

        [TestMethod]
        public void printknapSacktest_2()
        {
            int[] val = { 70, 110, 130 };
            int[] wt = { 20, 30, 40 };
            int W = 70;
            int n = val.Length;
            string result = Class1.printknapSack(W, wt, val, n);
            string expected = "40, 30";
            Assert.AreEqual(expected, result);


        }

        [TestMethod]
        public void printknapSacktest_3()
        {
            int[] val = { 70, 90, 110 };
            int[] wt = { 20, 40, 70 };
            int W = 110;
            int n = val.Length;
            string result = Class1.printknapSack(W, wt, val, n);
            string expected = "70, 40";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BFS_Test1()
        {
            Class1.GraphBf(4);

            Class1.AddEdgeBf(0, 1);
            Class1.AddEdgeBf(0, 2);
            Class1.AddEdgeBf(1, 2);
            Class1.AddEdgeBf(2, 0);
            Class1.AddEdgeBf(2, 3);
            Class1.AddEdgeBf(3, 3);

            string result = Class1.BFS(2);
            string expected = "2, 0, 3, 1";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void BFS_Test2()
        {
            Class1.GraphBf(3);
            Class1.AddEdgeBf(0, 1);
            Class1.AddEdgeBf(0, 2);
            string result = Class1.BFS(0);
            string expected = "0, 1, 2";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void BFS_Test3()
        {
            Class1.GraphBf(4);

            Class1.AddEdgeBf(0, 1);
            Class1.AddEdgeBf(0, 2);
            Class1.AddEdgeBf(1, 2);
            Class1.AddEdgeBf(2, 0);
            Class1.AddEdgeBf(2, 3);
            Class1.AddEdgeBf(3, 3);

            string result = Class1.BFS(2);
            string expected = "2, 0, 3, 1";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void DFS_Test1()
        {
            Class1.GraphDFS(4);

            Class1.AddEdgeDFS(0, 1);
            Class1.AddEdgeDFS(0, 2);
            Class1.AddEdgeDFS(1, 2);
            Class1.AddEdgeDFS(2, 0);
            Class1.AddEdgeDFS(2, 3);
            Class1.AddEdgeDFS(3, 3);
            Class1.dfs = "";
            string result = Class1.DFS(2);
            string expected = "2, 0, 1, 3";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void DFS_Test2()
        {
            Class1.GraphDFS(4);

            Class1.AddEdgeDFS(0, 1);
            Class1.AddEdgeDFS(0, 3);
            Class1.AddEdgeDFS(1, 2);
            Class1.AddEdgeDFS(2, 1);
            Class1.AddEdgeDFS(3, 0);
            Class1.AddEdgeDFS(3, 3);
            Class1.dfs = "";
            string result = Class1.DFS(0);
            string expected = "0, 1, 2, 3";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void DFS_Test3()
        {
            Class1.GraphDFS(4);

            Class1.AddEdgeDFS(0, 1);
            Class1.AddEdgeDFS(0, 2);
            Class1.AddEdgeDFS(1, 2);
            Class1.AddEdgeDFS(2, 0);
            Class1.AddEdgeDFS(2, 3);
            Class1.AddEdgeDFS(3, 3);
            Class1.dfs = "";
            string result = Class1.DFS(2);
            string expected = "2, 0, 1, 3";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TopologicalOrder_Test1()
        {
            Class1.Graph_TPL(6);

            Class1.AddEdge_TPL(5, 2);
            Class1.AddEdge_TPL(5, 0);
            Class1.AddEdge_TPL(4, 0);
            Class1.AddEdge_TPL(4, 1);
            Class1.AddEdge_TPL(2, 3);
            Class1.AddEdge_TPL(3, 1);

            string result = Class1.Topological_Order();
            string expected = "5, 4, 2, 3, 1, 0";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TopologicalOrder_Test2()
        {
            Class1.Graph_TPL(6);

            Class1.AddEdge_TPL(5, 2);
            Class1.AddEdge_TPL(5, 0);
            Class1.AddEdge_TPL(4, 0);
            Class1.AddEdge_TPL(4, 1);
            Class1.AddEdge_TPL(2, 3);
            Class1.AddEdge_TPL(3, 1);

            string result = Class1.Topological_Order();
            string expected = "5, 4, 2, 3, 1, 0";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TopologicalOrder_Test3()
        {
            Class1.Graph_TPL(5);

            Class1.AddEdge_TPL(0, 1);
            Class1.AddEdge_TPL(0, 3);
            Class1.AddEdge_TPL(1, 2);
            Class1.AddEdge_TPL(2, 3);
            Class1.AddEdge_TPL(2, 4);
            Class1.AddEdge_TPL(3, 4);

            string result = Class1.Topological_Order();
            string expected = "0, 1, 2, 3, 4";
            Assert.AreEqual(result, expected);
        }

        [TestClass]
        public class SCCProblemTEST
        {
            [TestMethod]
            public void SCC_test_1()
            {
                SCCProblem g = new SCCProblem(4);
                g.addEdge(0, 1);
                g.addEdge(1, 2);
                g.addEdge(2, 3);
                int result = g.SCC();
                SCCProblem g1 = new SCCProblem(4);
                g1.addEdge(0, 1);
                g1.addEdge(1, 2);
                g1.addEdge(2, 3);
                int expected = g1.SCC();
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void SCC_test_2()
            {
                SCCProblem g = new SCCProblem(4);
                g.addEdge(0, 1);
                g.addEdge(1, 2);
                g.addEdge(2, 3);
                int result = g.SCC();
                SCCProblem g1 = new SCCProblem(4);
                g1.addEdge(0, 1);
                g1.addEdge(1, 2);
                g1.addEdge(2, 3);
                int expected = g1.SCC();
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void SCC_test_3()
            {
                SCCProblem g = new SCCProblem(4);
                g.addEdge(0, 1);
                g.addEdge(1, 2);
                g.addEdge(2, 3);
                int result = g.SCC();
                SCCProblem g1 = new SCCProblem(4);
                g1.addEdge(0, 1);
                g1.addEdge(1, 2);
                g1.addEdge(2, 3);
                int expected = g1.SCC();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
