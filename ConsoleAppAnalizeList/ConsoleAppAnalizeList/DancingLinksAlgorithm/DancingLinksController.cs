using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnalizeList.DancingLinksAlgorithm
{
    class DancingLinksController
    {
        private MatrixKeeper MatrixKeeper;

        public DancingLinksController()
        {
            MatrixKeeper = new MatrixKeeper();
        }

        public void CreateExercise()
        {
            MatrixKeeper.GenerateExercise();
            MatrixKeeper.GenerateMatrix();

            MatrixKeeper.PrintMatrix();
            Console.WriteLine(" MatrixKeeper.CheckRow(0) = " + MatrixKeeper.CheckRow(0));
            MatrixKeeper.PrintRow(0);
        }
    }
}
