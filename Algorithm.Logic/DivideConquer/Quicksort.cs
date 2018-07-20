using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.DivideConquer
{
    /// <summary>
    /// Quick sort algorithm
    /// </summary>
    public class Quicksort
    {
        /// <summary>
        /// Sort an element
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public int[] Sort(int[] elements)
        {
            if (elements == null || elements.Length < 2)
                return elements;
            if (elements.Length == 2)
            {
                if (elements[0] > elements[1])
                {
                    var elementTemp = elements[0];
                    elements[0] = elements[1];
                    elements[1] = elementTemp;
                }

                return elements;
            }

            int selectedIndex = Convert.ToInt32(Math.Ceiling(((decimal)elements.Length / 2)));
            int selectedElement = elements[selectedIndex];

            var result = new List<int>();
            var smallest = elements.Where((x, y) => x <= selectedElement && y != selectedIndex).ToArray();
            var greater = elements.Where((x, y) => x > selectedElement && y != selectedIndex).ToArray();

            result.AddRange(Sort(smallest));
            result.Add(selectedElement);
            result.AddRange(Sort(greater));

            return result.ToArray();
        }
    }
}
