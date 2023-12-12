using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Person
{
    enum PersonCompareEnum
    {
        CompWeight, CompHeight, CompBMI, CompFName, CompLName
    }

    internal class PersonSort : IComparer<Person>
    {
        private PersonCompareEnum Comp;
        public PersonSort(PersonCompareEnum comp)
        {
            this.Comp = comp;
        }
        public int Compare(Person x, Person y)
        {
            switch (Comp)
            {
                case PersonCompareEnum.CompHeight:
                    return (int)(x.Højde * 100 - y.Højde * 100);
                case PersonCompareEnum.CompWeight:
                    return (int)(x.Vægt * 100 - y.Vægt * 100);
                case PersonCompareEnum.CompBMI:
                    return (int)(x.GetBMI() * 100 - y.GetBMI() * 100);
            }
            return 0;
        }
    }
}
