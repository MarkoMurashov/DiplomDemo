using System.Collections.Generic;

namespace GRASP.Business_logic
{
    class GRASPHelper
    {

        public static List<List<int>> CopySolution(List<List<int>> route)
        {
            List<List<int>> newList = new List<List<int>>();
            foreach (var item in route)
            {
                List<int> tmp = new List<int>();
                foreach (int num in item)
                {
                    tmp.Add(num);
                }
                newList.Add(tmp);
            }

            return newList;
        }

    }
}
