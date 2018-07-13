using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.DivideConquer
{
    /// <summary>
    /// Count the number of itemin a list
    /// </summary>
    public class ListItemCount
    {
        /// <summary>
        /// Counts the element of a list
        /// </summary>
        /// <param name="elementList"></param>
        /// <returns>The amount of element in the list</returns>
        public int Count(IList elementList)
        {
            if (elementList == null || elementList.Count == 0)
                return 0;
            if (elementList.Count == 1)
                return 1;

            elementList.RemoveAt(0);

            return 1 + Count(elementList);
        }
    }
}
