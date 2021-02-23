using OOP_SEM3_L2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4SEM_3
{    class SortingByControlType : IComparer<DisciplineInfo>
    {
        public int Compare(DisciplineInfo x, DisciplineInfo y)
        {
            string a = x.controlType;
            string b = y.controlType;

            if (a == "Экзамен" && b == "Экзамен" || a == "Экзамен" && b == "Зачёт")
            {
                return -1;
            }
            else if (a == "Зачёт" && b == "Экзамен" || a == "Зачёт" && b == "Зачёт")
            {
                return 1;
            }
            return 0;
        }
    }
}
