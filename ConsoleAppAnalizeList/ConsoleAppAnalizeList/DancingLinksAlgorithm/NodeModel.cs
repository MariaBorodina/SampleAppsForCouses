using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleAppAnalizeList.DancingLinksAlgorithm
{
    class NodeModel
    {
        internal int CurrentValue { get; set; }
        internal List<int> PossibleValues { get; set; }

        internal int X;
        internal int Y;

        internal bool IsPredefined { get; private set; }

        public NodeModel()
        {
            PossibleValues = new List<int>(); 
        }

        public NodeModel(bool isPredefined, List<int> possibleValues, Nullable<int> x = null, Nullable<int> y = null)
        {
            IsPredefined = isPredefined;
            PossibleValues = possibleValues;

            if (x.HasValue && y.HasValue)
            {
                X = x.Value;
                Y = y.Value;
            }
        }

        internal NodeModel Left;
        internal NodeModel Right;
        internal NodeModel Up;
        internal NodeModel Down;
    }
}
