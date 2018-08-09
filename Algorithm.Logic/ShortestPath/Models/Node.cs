using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.ShortestPath.Models
{
    /// <summary>
    /// Node list of a graph
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Node Content
        /// </summary>
        public T NodeContent { get; set; }

        /// <summary>
        /// List of node neighbours
        /// </summary>
        public List<Node<T>> Neighbours { get; set; }


        /// <summary>
        /// Default Controller
        /// </summary>
        public Node()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nodeContent"></param>
        public Node(T nodeContent)
        {
            this.NodeContent = NodeContent;
        }


        /// <summary>
        /// Verify if a node exists inthe array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Exist(T element)
        {
            var hasAny = Neighbours.Any(x => x.NodeContent.Equals(element));
            return hasAny;
        }


        /// <summary>
        /// Retrieve node 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public Node<T> GetNode(T element)
        {
            var node = Neighbours.FirstOrDefault(x => x.NodeContent.Equals(element));
            return node;
        }
    }
}
