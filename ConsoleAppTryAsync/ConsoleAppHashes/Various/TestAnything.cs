using System;
using System.Collections.Generic;
using System.Linq;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashes
{
    class TestAnything
    {
        public char FindFirstNonRecurringChar_(string str)
        {
            var chars = new char[str.Length];
            int iNextChar = 0;
            int iFirstDuplicate = 0;

            bool duplicatesContain(char ch1)
            {
                for (int i = iFirstDuplicate; i < iNextChar; i++)
                    if (chars[i] == ch1)
                        return true;

                return false;
            }
            (bool, int) candidatesContain(char ch1)
            {
                int iFirstNulItem = -1;
                bool res = false;

                for (int i = 0; i < iFirstDuplicate; i++)
                {
                    if (chars[i] == ch1)
                    {
                        res = true;
                        iFirstNulItem = i;
                        break;
                    }
                    //if (iFirstNulItem < 0 && chars[i] == default(char))
                    //    iFirstNulItem = i;
                }
                return (res, iFirstNulItem);
            }
            void swap(int iFirstIndex, int iSecondIndex)
            {
                var ch = chars[iFirstIndex];
                chars[iFirstIndex] = chars[iSecondIndex];
                chars[iSecondIndex] = ch;
            }

            foreach (char ch in str)
            {
                if (duplicatesContain(ch))
                    continue;

                var tuple = candidatesContain(ch);
                int iSwitchIndex = tuple.Item2;
                if (tuple.Item1)
                {
                    swap(iSwitchIndex, iNextChar++);
                }
                else
                {
                    swap(iFirstDuplicate, iNextChar++);
                    chars[iFirstDuplicate++] = ch;
                }
            }

            char resCh = default(char);
            for (int i = 0; i < iFirstDuplicate; i++)
                if (chars[i] != default(char))
                {
                    resCh = chars[i];
                    break;
                }

            return resCh;
        }

        public char FindFirstNonRecurringChar_Lists(string str)
        {
            var candidates = new List<char>();
            var duplicates = new List<char>();


            foreach (char ch in str)
            {
                if (duplicates.Contains(ch))
                    continue;

                if (candidates.Contains(ch))
                {
                    candidates.Remove(ch);
                    duplicates.Add(ch);
                }
                else
                    candidates.Add(ch);
            }

            return candidates.FirstOrDefault();
        }

        public char FindFirstNonRecurringChar_Dict(string str)
        {
            var dict = new Dictionary<char, int>(256);

            foreach (char ch in str)
            {
                if (dict.ContainsKey(ch))
                    dict[ch]++;
                else
                    dict.Add(ch, 1);
            }

            foreach (var pair in dict)
                if (pair.Value == 1)
                    return pair.Key;

            return ' ';
        }

        public int FindMissingElement(int[] array)
        {
            void swap(ref int a, ref int b)
            {
                var r = a;
                a = b;
                b = r;
            }

            for (int i = 0; i <= array.Length; i++)
            {
                var bFound = false;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] == i + 1)
                    {
                        swap(ref array[j], ref array[i]);
                        bFound = true;
                    }
                }

                if (!bFound)
                    return i + 1;
            }

            return array.Length + 1;
        }

        public (int, int) SwapXor(int a, int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            return (a, b);
        }

        public (int, int) SwapMult(int a, int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;

            return (a, b);
        }

        public (int, int) Swap(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            return (a, b);
        }

        public int[] Reverse(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();

            var len = array.Length;

            for (int i = 0; i < len / 2; i++)
            {
                var r = array[i];
                array[i] = array[len - i - 1];
                array[len - i - 1] = r;
            }

            return array;
        }

        public void PrintNumbers(int low, int high)
        {
            for (int i = low; i <= high; i++)
            {
                bool bFirst = false;
                string by = "";
                foreach (var divider in new int[] { 3, 5, 7 })
                {
                    if (i % divider == 0)
                    {
                        by += (bFirst ? " and " : " by ") + divider;
                        bFirst = true;
                    }
                }

                Console.WriteLine($"{i,-5}{by}");
            }
        }

        //public int TestWordCalculator(string word)
        //{            
        //    return word.ToCharArray().Where(ch => char.IsLetter(ch)).Sum(ch => Convert.ToInt32(char.ToLower(ch)) - 96);
        //}

        public string TestRemoveDuplicateChars_StringBuilder(string strInput)
        {
            var builder = new StringBuilder(strInput.Length);

            foreach (var ch in strInput)
            {
                if (!builder.ToString().Contains(ch.ToString()))
                    builder.Append(ch);
            }

            return builder.ToString();
        }
        public string TestRemoveDuplicateChars_List(string strInput)
        {
            var builder = new List<char>();

            foreach (var ch in strInput)
            {
                if (!builder.Contains(ch))
                    builder.Add(ch);
            }

            return new string(builder.ToArray());
        }

        public string TestRemoveDuplicateChars_Array(string strInput)
        {
            var builder = new char[strInput.Length];  // new StringBuilder(strInput.Length);
            int i = 0;

            foreach (var ch in strInput)
            {
                bool bContains = false;
                for (int j = 0; j < i; j++)
                {
                    if (builder[j] == ch)
                    {
                        bContains = true;
                        break;
                    }
                }

                if (!bContains)
                    builder[i++] = ch;
            }


            Array.Resize(ref builder, i);

            return new string(builder);
        }

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
