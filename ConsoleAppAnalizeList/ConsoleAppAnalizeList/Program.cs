using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnalizeList
{
    class Program
    {
        static void Main(string[] args)
        {
            SudokuDancingLinksExercise();

            //TestSums();
            //CircleExercise();
            //InheritanceExercise();

            /*foreach (var arg in args)
            {
                var trimmed = arg.ToLower().TrimStart('-', '/');

                if (trimmed == "?")
                {
                    PrintHelp();
                    return;
                }
                else if (trimmed == "a")
                {
                    a(@"C:\Exchange\for check\15.04.20\6185\out6185full1_1.txt");
                }
            }*/
        }


        #region test exercises



        private static void SudokuDancingLinksExercise()
        {
            var t = new DancingLinksAlgorithm.DancingLinksController();

            t.CreateExercise();

            

            Console.ReadKey();
        }

        private static void InheritanceExercise()
        {
            var t = new TestInheritance();

            t.Question5();

            Console.WriteLine(t.Responce);
            Console.ReadKey();
        }

        private static void CircleExercise()
        {
            var t = new TestCircle();

            var radius = TestSmthBase.GenerateDouble(10);
            t.Log(radius);
            t.TestCircleExercise(radius);

            Console.WriteLine(t.Responce);
            Console.ReadKey();
        }

        private static void TestSums()
        {
            var t = new TestSums();

            var array = TestSmthBase.GenerateIntArray(6, 6);
            t.Log(array);
            t.SumOfEvenIndexes(array);
            t.SumOfEvens(array);

            Console.WriteLine(t.Responce);
            Console.ReadKey();
        }

        #endregion

        private static void a(string strFile)
        {
            var s1 = Path.GetFileNameWithoutExtension(strFile);
            s1 = Path.GetDirectoryName(strFile) + Path.DirectorySeparatorChar + s1 + "_.1" + Path.GetExtension(strFile);

            using (StreamReader sr = new StreamReader(strFile))
                using (StreamWriter sw = new StreamWriter(s1))
            {
                while (!sr.EndOfStream)
                {
                    var str = sr.ReadLine();

                    if (str.IndexOf(':') >= 0)
                        str = str.Substring(0, str.IndexOf(':'));

                    try
                    {
                        sw.WriteLine(Path.GetFileName(str) + ":" + Path.GetDirectoryName(str));
                    }
                    catch (Exception) { };
                }
            }
        }

        private static void PrintHelp()
        {
            throw new NotImplementedException();
        }
    }
}
