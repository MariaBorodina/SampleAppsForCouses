using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleAppAnalizeList.DancingLinksAlgorithm
{
    class MatrixKeeper
    {
        private const int MatrixSize = 9;
        private Dictionary<Point, int> exercise;
        private Random random = new Random(DateTime.Now.Millisecond);
        private NodeModel[] matrix = new NodeModel[MatrixSize]; //rows

        internal void GenerateExercise()
        {
            exercise = new Dictionary<Point, int>(40);
            for (int i = 0; i < 40; i++)
            {
                var p = new Point(random.Next(MatrixSize), random.Next(MatrixSize));
                if (exercise.ContainsKey(p))
                    continue;

                exercise.Add(p, random.Next(0, 10));
            }
        }

        internal void GenerateMatrix()
        {
            //generate noeds by rows, set horizontal links
            for(int i = 0; i < MatrixSize; i++)
            {
                NodeModel leftNode = null, node = null;

                for (int j = 0; j < MatrixSize; j++)
                {
                    var p = new Point(i, j);
                    if(exercise.ContainsKey(p))
                        node = new NodeModel(true, new List<int>() { exercise[p] } , i, j);
                    else
                        node = new NodeModel(false, Enumerable.Range(1, 9).ToList(), i, j);

                    if (j == 0)
                        matrix[i] = node;
                    else
                    {
                        node.Left = leftNode;
                        leftNode.Right = node;
                    }

                    leftNode = node;
                }

                node.Right = matrix[i];
                matrix[i].Left = node;
            }

            //set vertical links
            NodeModel[] slider = matrix;

            for (int i = 0; i < MatrixSize; i++)
            {
                foreach(var node in slider)
                {
                    node.Up = (node.Y == 0) ? slider.Last() : slider[node.Y - 1];
                    node.Down = (node.Y == slider.Length-1) ? slider.First() : slider[node.Y + 1];
                }

                for (int j = 0; j < MatrixSize; j++)
                    slider[j] = slider[j].Right;
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < MatrixSize; i++)
                PrintRow(i);

            //foreach (var row in matrix)
            //{
            //    Console.Write($"{row.X,2}" );
            //    var node = row;
            //    for (int j = 0; j < MatrixSize; j++)
            //    {
            //        var s = string.Join("", node.PossibleValues);
            //        Console.Write($"{s,10}");
            //        node = node.Right;
            //    }
            //    Console.WriteLine();
            //}
        }

        public void PrintRow(int rowNumber)
        {
            var row = matrix[rowNumber];

            Console.Write($"{row.X,2}");
            var node = row;
            for (int j = 0; j < MatrixSize; j++)
            {
                var s = string.Join("", node.PossibleValues);
                Console.Write($"{s,10}");
                node = node.Right;
            }
            Console.WriteLine();
        }

        public bool CheckRow(int rowNumber)
        {
            var concretes = new List<int>();
            var floatingNodes = new List<NodeModel>();

            // find concrete values and find nodes that are still floating (more than 1 possible value)
            var node = matrix[rowNumber];
            {
                if (node.PossibleValues.Count == 1)
                    node.CurrentValue = node.PossibleValues.First();

                if (node.CurrentValue > 0)
                    concretes.Add(node.CurrentValue);
                else
                    floatingNodes.Add(node);

                node = node.Right;
            } while (node != matrix[rowNumber]);

            //Check concretes - are they unique?
            if (concretes.Count() > concretes.Distinct().Count())
                return false;

            //remove concrete values from possibles
            foreach (var concrete in concretes)
                foreach (var floatingNode in floatingNodes)
                    floatingNode.PossibleValues.Remove(concrete);

            //check each node if it is 0- possible (which means bad), or 1- possible, then fill concrete
            foreach (var floatingNode in floatingNodes)
            {
                switch(floatingNode.PossibleValues.Count)
                {
                    case 0:
                        return false;
                    case 1:
                        floatingNode.CurrentValue = floatingNode.PossibleValues.First();
                        break;                        
                }
            }

            return true;
        }

    }
}
