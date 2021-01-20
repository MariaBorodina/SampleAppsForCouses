using ConsoleAppHashes.Sortings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashes
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestHashSet();
            //TestEquals();
            //TestSorts();

            var c = new TestFromSite();
            Func<string> func = TestFromSite.main;
            var a = func();

            Console.WriteLine(c.GetType());
            Console.WriteLine(func.Method.Name + ": " + a);

            Console.ReadKey();
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
    }
}
