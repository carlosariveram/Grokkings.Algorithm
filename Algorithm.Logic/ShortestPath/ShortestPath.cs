using Algorithm.Logic.ShortestPath.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.ShortestPath
{
    public class ShortestPath
    {
        public Stack<Node<T>> FindShortestPath<T>(Node<T> node, Queue<Node<T>> nodesToVerify, T elementToFind, Stack<Node<T>> nodesVerified)
        {
            if (node == null)
                return null;

            if (!nodesVerified.Any(x => x.NodeContent.Equals(node.NodeContent)))
                node.Neighbours.ForEach(x => nodesToVerify.Enqueue(x));

            nodesVerified.Push(node);

            if (elementToFind.Equals(node.NodeContent))
                return nodesVerified;

            var newNode = nodesToVerify.Dequeue();

            return FindShortestPath<T>(newNode, nodesToVerify, elementToFind, nodesVerified);
        }
    }
}
