using Algorithm.Logic.ShortestPath.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.ShortestPath
{
    /// <summary>
    /// Shortest Path Algorithm
    /// </summary>
    public class ShortestPath
    {
        /// <summary>
        /// Finds the shortest path
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="node"></param>
        /// <param name="nodesToVerify"></param>
        /// <param name="elementToFind"></param>
        /// <param name="nodesVerified"></param>
        /// <returns></returns>
        public Node<T> FindShortestPath<T>(Queue<Node<T>> nodesToVerify, T elementToFind, Stack<Node<T>> nodesVerified)
        {
            if (nodesToVerify.Count == 0)
                return null;

            var node = nodesToVerify.Dequeue();

            if (!nodesVerified.Any(x => x.NodeContent.Equals(node.NodeContent)))
                node.Neighbours.ForEach(x => nodesToVerify.Enqueue(x));

            nodesVerified.Push(node);

            if (elementToFind.Equals(node.NodeContent))
                return node;

            return FindShortestPath<T>(nodesToVerify, elementToFind, nodesVerified);
        }
    }
}
