using ConsoleAppHashes.Sortings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashes
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Class1();

           // c.RandomizeArray(new[] { 1, 2, 3, 4, 5, 6 });

            //TestHashSet();
            //TestEquals();
            //TestSorts();

            //var c = new TestFromSite();
            //Func<string> func = TestFromSite.main;
            //var a = func();

            //var c = new Rect(5, 1, 10, 2);
            //Func<Point, bool> func = c.TestPointWithinRectangle;
            //var a = func(new Point() { x = 5, y = 1 });

            var r = new TestRandoms();
            //var c = new TestAnything();

            //var c = new Rect(new[] { 
            //    new Point() {x=3, y=5},
            //    new Point() {x=3, y=14},
            //    new Point() {x=13, y=5},
            //    new Point() {x=10, y=8},
            //    new Point() {x=7, y=14},  
            //});
            //Func<string> func = c.PrintMe;
            //Console.WriteLine(c.GetType());

            //RunTest(c.TestRemoveDuplicateChars_Array, "abaccaaaaccb");
            //RunTest(c.TestRemoveDuplicateChars_StringBuilder, "abccda");
            //Func<string, string> func = c.TestRemoveDuplicateChars_StringBuilder;
            //var a = func("abcabc");
            //Console.WriteLine(func.Method.Name + ": " + a);

            //Func<string, int> func = c.TestWordCalculator;
            //var a = func("Zebra"); 

            //Action<int, int> func = c.PrintNumbers;
            //var a = "ha";
            //func(1, 110);

            Func<int[], int[]> func = r.RandomOrder;
            //Func<int[], int[]> func = c.RandomizeArray;
            r.CountDistribution(new[] { 0, 1, 2, 3, 4, 5, 6 }, func);

            //Func<int, int, (int, int)> func = c.SwapXor;
            //var a = func(2, 20);
            //Func<int[], int> func = c.FindMissingElement;

            var a = func(new[] { 0, 1, 2, 3, 4, 5, 6  }); 
            Console.WriteLine($"{func.Method.Name}: {string.Join(", ", a)}");
            a = func(new[] { 0, 1, 2, 3, 4, 5, 6 });
            Console.WriteLine($"{func.Method.Name}: {string.Join(", ", a)}");
            a = func(new[] { 0, 1, 2, 3, 4, 5, 6 });
            Console.WriteLine($"{func.Method.Name}: {string.Join(", ", a)}");
            a = func(new[] { 0, 1, 2, 3, 4, 5, 6 });
            Console.WriteLine($"{func.Method.Name}: {string.Join(", ", a)}");
            a = func(new[] { 0, 1, 2, 3, 4, 5, 6 });
            Console.WriteLine($"{func.Method.Name}: {string.Join(", ", a)}");

            //string str = "atakataz sdfl skla";
            //Console.WriteLine("first non-recurring char in \"" + str + "\" is: " + c.FindFirstNonRecurringChar_(str));

            // TestList(2);

            //TestTrees2();

            Console.ReadKey();
        }


        private static void TestTrees2()
        {
            var tree = new Trees.BTree();

            tree.Tree = new Trees.Node(15);
            tree.Tree.Children.Add(new Trees.Node(6));
            tree.Tree.Children[0].Children.Add(new Trees.Node(1));
            tree.Tree.Children[0].Children.Add(new Trees.Node(4));
            tree.Tree.Children[0].Children.Add(new Trees.Node(5));
            tree.Tree.Children[0].Children[1].Children.Add(new Trees.Node(2));
            tree.Tree.Children[0].Children[1].Children.Add(new Trees.Node(3));
            tree.Tree.Children.Add(new Trees.Node(12));
            tree.Tree.Children[1].Children.Add(new Trees.Node(8));
            tree.Tree.Children[1].Children.Add(new Trees.Node(10));
            tree.Tree.Children[1].Children[0].Children.Add(new Trees.Node(7));
            tree.Tree.Children[1].Children[1].Children.Add(new Trees.Node(9));
            tree.Tree.Children[1].Children.Add(new Trees.Node(11));
            tree.Tree.Children.Add(new Trees.Node(14));
            tree.Tree.Children[2].Children.Add(new Trees.Node(13));

            Console.WriteLine("InOrderSearch:");
            tree.InOrderSearch(tree.Tree);
        }
        private static void TestTrees1()
        {
            var tree = new Trees.BTree();

            tree.Tree = new Trees.Node(1);
            tree.Tree.Children.Add(new Trees.Node(11));
            tree.Tree.Children.Add(new Trees.Node(12));
            tree.Tree.Children.Add(new Trees.Node(13));
            tree.Tree.Children[0].Children.Add(new Trees.Node(111));
            tree.Tree.Children[0].Children[0].Children.Add(new Trees.Node(1111));
            tree.Tree.Children[1].Children.Add(new Trees.Node(121));
            tree.Tree.Children[1].Children.Add(new Trees.Node(122));
            tree.Tree.Children[1].Children.Add(new Trees.Node(121));
            tree.Tree.Children[2].Children.Add(new Trees.Node(131));

            Console.WriteLine("WideSearch:");
            tree.WideSearch(tree.Tree);
            Console.WriteLine("PreOrderSearch:");
            tree.PreOrderSearch(tree.Tree);
        }

        private static void TestList(int test)
        {
            var c = new OneLinkList(new[] { 1, 2, 2, 3, 4, 2, 1, 1 });
            c.Print();

            switch (test)
            {
                case 0:
                    break;

                case 1:
                    c.Tail.Next = c.Head.Next;
                    Func<int> func = c.FindLoopedElement;
                    var a = func();
                    Console.WriteLine($"{func.Method.Name}: {string.Join(", ", a)}");
                    break;

                case 2:
                    Action func1 = c.RemoveDuplicates_Hash;
                    func1();
                    Console.WriteLine($"{func1.Method.Name}: ");
                    break;
            }

            c.Print();
        }

        static void RunTest(Func<string, string> func, string arg)
        {
            Console.WriteLine(func.Method.Name + ": " + func(arg));
        }

        static void TestSorts()
        {
            //var c = new BubbleSorting(10, 100);
            //var c = new ShakerSorting(10, 100);
            //var c = new CombSorting(10, 100);
            //var c = new InsertionSorting(10, 100);
            var c = new QuickSorting(10, 100);

            Console.WriteLine(c.GetType());
            Console.WriteLine($"Init{' ',-12}: {c.Print()}" );

            Func<int> func = c.Sort;
            var a = func();

            Console.WriteLine($"{func.Method.Name}: {a} steps");
            Console.WriteLine($"{func.Method.Name,-16}: {c.Print()}");
            Console.WriteLine($"Sorted: {c.IsOrdered}");
        }

        static void TestEquals()
        {
            var c = new TestAnything();
            Func<string> func = c.TestEqualsStructs;
            var a = func();

            Console.WriteLine(c.GetType());
            Console.WriteLine(func.Method.Name + ": " + a);
        }

        /*
        private static HashSet<PictureModel> pictures = new HashSet<PictureModel>()
            {
                new PictureModel(){
                    Name="Model1",
                    Width=50,
                    Height=100,
                    Bitmap = new System.Drawing.Bitmap(@"\Pictures\Strawberry-blue.jpg")
                },
                new PictureModel(){
                    Name="Model2",
                    Width=200,
                    Height=50,
                    Bitmap = new System.Drawing.Bitmap(@"\Pictures\maxresdefault.jpg")
                },
            };

        static void TestHashSet()
        {
            Console.WriteLine("pictures: {0}", pictures.Aggregate("", (str, pictureModel) => str + ", " + pictureModel.Name));

            var newModel = new PictureModel()
            {
                Name = "Model2",
                Width = 200,
                Height = 100,
                Bitmap = new System.Drawing.Bitmap(@"\Pictures\510174.jpg")
            };

            Console.WriteLine("contains: {0}", pictures.Contains(newModel));

            var bRes = pictures.Add(newModel);
            Console.WriteLine("new model added or not: {0}", bRes);
            Console.WriteLine("pictures: {0}\n\n", pictures.Aggregate("", (str, pictureModel) => str + ", " + pictureModel.Name));

        }
        */
    }
}
