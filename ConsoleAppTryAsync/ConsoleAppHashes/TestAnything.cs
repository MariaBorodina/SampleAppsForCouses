using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashes
{
    class TestAnything
    {
        delegate void P();
        public string TestClosure()
        {
            P p = Console.WriteLine; // P объявлен как delegate void P();
            foreach (var i in new[] { 1, 2, 3, 4 })
            {
                p += () => Console.Write(i);
            }
            p();

            return "";
        }

        public string TestSyntax()
        {
            var @this = "wtf";

            return @this;
        }

        public string TestTryReturn()
        {
            string a = "const";

            try
            {
                // throw new Exception("message");
                return "haha!";
            }
            catch (Exception e) when (!string.IsNullOrEmpty(e.Message))
            {
                a = "Exception: " + e.Message;
            }
            finally
            {
                a = "finally";
            }

            //int i = 42;
            //IComparable<int> ic = (IComparable<int>)i;
            //ic.CompareTo(5);

            return a;

        }

        public string TestInheritance()
        {
            var b1 = new b();

            return ((a)b1).fVirtNew().ToString();
        }


        public string TestEqualsObjects()
        {
            var a1 = new a() { mem = 5 };
            var a2 = new a() { mem = 5 };

            //return a1.Equals(a2).ToString();
            return (a1 == a2).ToString();
        }

        public string TestEqualsStructs()
        {
            var a1 = new s() { mem = 5 };
            var a2 = new s() { mem = 5 };

            return a1.Equals(a2).ToString();
            // return (a1 == a2).ToString();
        }
    }


    class a
    {
        public int f() => 5;
        public virtual int fVirt() => 5;
        public virtual int fVirtNew() => 5;

        public int mem;
    }

    class b : a
    {
        public new int f() => 10;
        public override int fVirt() => 10;
        public new int fVirtNew() => 10;
    }

    struct s
    {
        public int mem;
    }
}
