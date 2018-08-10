using Algorithm.Logic.ShortestPath.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Test.ShortestPath
{
    /// <summary>
    /// Test the method that find the shortest path
    /// </summary>
    [TestClass]
    public class ShortestPathTest
    {
        /// <summary>
        /// Finds the shortest path valid path
        /// </summary>
        [TestMethod]
        public void FindsTheShortestPath_FindShortestPath_NodePath()
        {
            var algorithm = new Algorithm.Logic.ShortestPath.ShortestPath();

            var nodes = getNodes();
            var queue = new Queue<Node<string>>();
            var stack = new Stack<Node<string>>();

            queue.Enqueue(nodes);

            var path = algorithm.FindShortestPath(queue, "End", stack);
            Assert.IsNotNull(path);
            Assert.IsTrue(path.Parent.NodeContent == "6" && path.Parent.Parent.NodeContent == "1" && path.Parent.Parent.Parent.NodeContent == "Start");
        }

        /// <summary>
        /// Finds the shortest path valid path shortest one
        /// </summary>
        [TestMethod]
        public void FindsTheShortestPathShortestOne_FindShortestPath_NodePath()
        {
            var algorithm = new Algorithm.Logic.ShortestPath.ShortestPath();

            var nodes = getInterconnectedNodes();
            var queue = new Queue<Node<string>>();
            var stack = new Stack<Node<string>>();

            queue.Enqueue(nodes);

            var path = algorithm.FindShortestPath(queue, "End", stack);
            Assert.IsNotNull(path);
            Assert.IsTrue(path.Parent.NodeContent == "6" && path.Parent.Parent.NodeContent == "1" && path.Parent.Parent.Parent.NodeContent == "Start");
        }


        /// <summary>
        /// Finds the shortest path invalid path
        /// </summary>
        [TestMethod]
        public void NotFindAnyPath_FindShortestPath_NodePath()
        {
            var algorithm = new Algorithm.Logic.ShortestPath.ShortestPath();

            var nodes = getNodes();
            var queue = new Queue<Node<string>>();
            var stack = new Stack<Node<string>>();

            queue.Enqueue(nodes);

            var invalidPath = algorithm.FindShortestPath(queue, "Invalid", stack);
            Assert.IsNull(invalidPath);
        }


        /// <summary>
        /// Retrieve the nodes configuration
        /// </summary>
        /// <returns></returns>
        private Node<string> getNodes()
        {
            Node<string>[] nodes = new[]
            {
                new Node<string>("Start"),
                new Node<string>("1"),
                new Node<string>("2"),
                new Node<string>("3"),
                new Node<string>("4"),
                new Node<string>("5"),
                new Node<string>("6"),
                new Node<string>("7"),
                new Node<string>("8"),
                new Node<string>("End")
            };

            nodes[0].AddNeighbour(nodes[1]);
            nodes[0].AddNeighbour(nodes[2]);
            nodes[2].AddNeighbour(nodes[3]);
            nodes[2].AddNeighbour(nodes[4]);
            nodes[2].AddNeighbour(nodes[5]);
            nodes[1].AddNeighbour(nodes[6]);
            nodes[1].AddNeighbour(nodes[7]);
            nodes[1].AddNeighbour(nodes[8]);
            nodes[6].AddNeighbour(nodes[9]);

            return nodes[0];
        }

        /// <summary>
        /// Retrieve the interconnected nodes configuration (several nodes)
        /// </summary>
        /// <returns></returns>
        private Node<string> getInterconnectedNodes()
        {
            Node<string>[] nodes = new[]
            {
                new Node<string>("Start"),
                new Node<string>("1"),
                new Node<string>("2"),
                new Node<string>("3"),
                new Node<string>("4"),
                new Node<string>("5"),
                new Node<string>("6"),
                new Node<string>("7"),
                new Node<string>("8"),
                new Node<string>("End"),
                new Node<string>("6"),
                new Node<string>("End"),
            };

            nodes[0].AddNeighbour(nodes[1]);
            nodes[0].AddNeighbour(nodes[2]);
            nodes[2].AddNeighbour(nodes[3]);
            nodes[3].AddNeighbour(nodes[4]);
            nodes[4].AddNeighbour(nodes[5]);
            nodes[4].AddNeighbour(nodes[6]);
            nodes[1].AddNeighbour(nodes[10]);
            nodes[10].AddNeighbour(nodes[11]);
            nodes[1].AddNeighbour(nodes[8]);
            nodes[6].AddNeighbour(nodes[9]);

            return nodes[0];
        }
    }
}
