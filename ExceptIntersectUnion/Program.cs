using System;
using System.Linq;

namespace ExceptIntersectUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Except 
            string[] soft = { "Microsoft", "Google", "Apple", "IBM" };
            string[] hard = { "Apple", "IBM", "Samsung" };

            //soft hanum e nranq voronq kan hard mej ev tpum soft-i parunakutyun@
            var result = soft.Except(hard);

            foreach (string s in result)
                Console.WriteLine("Except " + s);

            //Intersect
            //nranq voronq kan ev soft-um ev hard-um
            var result2 = soft.Intersect(hard);

            foreach (string s in result2)
                Console.WriteLine("Intersect " + s);

            //Union
            //miavorum e ev hard ev soft aranc krknutyan
            var result3 = soft.Union(hard);

            foreach (string s in result3)
                Console.WriteLine("Union " + s);

            //Concat 
            //miavorum e 2sn el krknutyamb
            var result4 = soft.Concat(hard);
            foreach (string s in result4)
                Console.WriteLine("Concat " + s);

            //Distinct
            //hanum e krknutyunner@ 
            var result5 = soft.Concat(hard).Distinct();
            foreach (string s in result5)
                Console.WriteLine("Concat + Distinct " + s);
            //Concat ev Distinct poxaren miangamic ogtagorcum enq Union
        }
    }
}
