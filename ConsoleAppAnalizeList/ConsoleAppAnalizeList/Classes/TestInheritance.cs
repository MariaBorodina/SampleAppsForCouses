using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnalizeList
{
    class TestInheritance : TestSmthBase
    {
        class A
        {
            internal virtual void Foo()
            {
                Console.Write("Class A");
            }
        }
        class B : A
        {
            internal override void Foo()
            {
                Console.Write("Class B");
            }
        }

        internal void Question1()
        {
            //B obj1 = (B)new A(); //runtime exception - invalid cast
            //obj1.Foo();

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();
        }

        internal void Question2()
        {
            List<Action> actions = new List<Action>();
            for (var count = 0; count < 10; count++)
            {
                actions.Add(() => Console.WriteLine(count));
            }
            foreach (var action in actions)
            {
                action();
            }
        }

        internal void Question3()
        {
            Log(System.Reflection.MethodInfo.GetCurrentMethod().Name);
            int i = 1;
            object obj = i;
            ++i;
            Log(i);
            Log(obj);
            Log((short)obj); // runtime exception, boxed int can be cast to int only
        }

        internal void Question4()
        {
            Log(System.Reflection.MethodInfo.GetCurrentMethod().Name);

            var s1 = string.Format("{0}{1}", "abc", "cba");
            var s2 = "abc" + "cba";
            var s3 = "abccba";

            Log(s1 == s2);                 //true 
            Log((object)s1 == (object)s2); //false
            Log(s2 == s3);                 //true
            Log((object)s2 == (object)s3); //true - why????
            Log((object)s1 == (object)s3); //false
        }


        static IEnumerable<int> Square(IEnumerable<int> a)
        {
            foreach (var r in a)
            {
                var rr = r * r;
                Console.WriteLine(rr);
                yield return rr;
            }
        }
        class Wrap
        {
            private static int init = 0;
            public int Value
            {
                get { return ++init; }
            }
        }
        internal void Question5()
        {
            var w = new Wrap();
            var wraps = new Wrap[3];
            for (int i = 0; i < wraps.Length; i++)
            {
                wraps[i] = w;
            }

            var values = wraps.Select(x => x.Value);
            var results = Square(values);
            int sum = 0;
            int count = 0;
            foreach (var r in results)
            {
                count++;
                sum += r;
            }
            Console.WriteLine("Count {0}", count);
            Console.WriteLine("Sum {0}", sum);

            Console.WriteLine("results.first = {0}", results.First());

            Console.WriteLine("Count {0}", results.Count());
            Console.WriteLine("Sum {0}", results.Sum());
        }
    }
}
