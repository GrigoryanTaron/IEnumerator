using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerator
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> res = new List<int> { 5, 21, 12, 6, -18, -59, 31, 3, 2, 4 };
            var finalllllll = res.ToList();
            var enumerator = finalllllll.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
            var res1 = res.Test1(6).Add1().First();
            res1 = res.Test(-20).Add().First();
            var res2 = res.Test(0).Add1();

            foreach (int item in res2)
            {
                Console.WriteLine($"{item}");
            }
            var res3 = res.Test(0).Multiple(2);
            foreach (int item in res3)
            {
                Console.WriteLine($"{item}");
            }
            var res4 = res.Test(20).Multiple1(2);
            foreach (int item in res4)
            {
                Console.WriteLine($"{item}");
            }
            var res5 = res.Test(1).Div(2);
            foreach (int item in res5)
            {
                Console.WriteLine($"{item}");
            }
            var res6 = res.Test(1).Div(2)._First();
            foreach (int item in res6)
            {
                Console.WriteLine($"{item}");
            }
        }
    }

}
