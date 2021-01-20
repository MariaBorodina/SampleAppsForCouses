using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleAppAnalizeList.DancingLinksAlgorithm
{
    class Controller
    {
        private Dictionary<Point, int> exercise;
        private Random random = new Random(DateTime.Now.Millisecond);
        private NodeModel matrix;

        private void GenerateExercise()
        {
            exercise = new Dictionary<Point, int>(40);
            for (int i = 0; i < 40; i++)
            {
                var p = new Point(random.Next(9), random.Next(9));
                if (exercise.ContainsKey(p))
                    continue;

                exercise.Add(p, random.Next(0, 10));
            }
        }

        private void GenerateMatrix()
        {
            for(int i = 0; i < 9; i++)
            {
                NodeModel leftNode = null, firstNode = null, node;

                for (int j = 0; j < 9; j++)
                {
                    var p = new Point(i, j);
                    if(exercise.ContainsKey(p))
                    {
                        node = new NodeModel(true, new List<int>() { exercise[p] } , i, j);
                    }
                    else
                    {
                        node = new NodeModel(false, Enumerable.Range(1, 9).ToList(), i, j);
                    }

                    if (j == 0)
                        firstNode = node;
                    else
                        node.Left = leftNode;

                    leftNode = node;
                }
            }
        }
    }
}
