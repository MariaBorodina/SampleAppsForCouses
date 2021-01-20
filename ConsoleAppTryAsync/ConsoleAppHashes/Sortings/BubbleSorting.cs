namespace ConsoleAppHashes.Sortings
{
    class BubbleSorting : SortingBase 
    {
        public BubbleSorting(int len, int maxValue) : base(len, maxValue) { }

        public override int Sort()
        {
            int ops = 0;

            for (int i = 1; i < Values.Length; i++)
                for (int j = 0; j < Values.Length - i; j++)
                    if (WrongOrder(Values[j], Values[j + 1]))
                        Swap(ref Values[j], ref Values[j + 1], ref ops);

            return ops;
        }

    }
}
