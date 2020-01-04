using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class SixtyTwoWorkers
    {
        public string name { get; }
        public string payingCategory { get; }
        public int amountOfFreedom { get; }
        public int usedFreedom { get; }

        public SixtyTwoWorkers(string name,string payingCategory) 
        {
            this.name = name;
            this.payingCategory = payingCategory;
        }

        public SixtyTwoWorkers(string name, string payingCategory,int amountOfFreedom)
        {
            this.name = name;
            this.payingCategory = payingCategory;
            this.amountOfFreedom = amountOfFreedom;
        }

        public int toUseFreedom()
        {
            return amountOfFreedom - usedFreedom;
        }
    }
}
