using OOP_SEM3_L2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4SEM_3
{
    class SortinByCourse : IComparer<DisciplineInfo>
    {        
        public int Compare(DisciplineInfo x, DisciplineInfo y)
        {
            
            int a = Convert.ToInt32(x.course);
            int b = Convert.ToInt32(y.course);

            if (a > b)
            {
                return 1;
            }
            else if (a < b)
            {
                return -1;
            }

            return 0;
        }
    }
}
