using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Algorithms
{
    //
    // Summary:
    //     Determines the next highest number in the pattern.
    //     Can be played by replacing contents of Main with below and modifying line variable.
    //     This challenge appeared in a past Google competition.
    //     Full challenge description at https://www.codeeval.com/open_challenges/44/
    //
    // Returns:
    //     Print to the Console the next highest integer.
    //    
    // Notes:
    //     Currently only about 95% correct.  Fails on 29911.
    //

    //static void Main(string[] args)
    //{

    //    string line = "29911";
    //    int num = int.Parse(line);
    //    FollowingInteger i = new FollowingInteger();
    //    i.PrintFollowingInteger(num, num);
    //    Console.ReadLine();
    //}

    public class FollowingInteger
    {
        int[] _digits;
        HashSet<int> _combos;

        public void PrintFollowingInteger(int originalNum, int newNum)
        {
            foreach (int combo in Combinations(newNum))
            {
                if (combo > originalNum)
                {
                    Console.WriteLine(combo);
                    return;
                }
            }
            PrintFollowingInteger(originalNum, newNum * 10);
        }

        private List<int> Combinations(int num)
        {
            _digits = num.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
            _combos = new HashSet<int>();
            Helper(0);
            return _combos.OrderBy(o => o).ToList();
        }

        private void Helper(int start)
        {
            if (_digits.Length - start == 2)
            {
                _combos.Add(int.Parse(string.Join("", _digits)));
                Swap(start, _digits.Length - 1);
                _combos.Add(int.Parse(string.Join("", _digits)));
                Swap(start, _digits.Length - 1);
            }
            else
            {
                for (int i = start; i < _digits.Length; i++)
                {
                    Swap(start, i);
                    Helper(start + 1);
                }
            }
        }

        private void Swap(int i, int j)
        {
            int temp = _digits[i];
            _digits[i] = _digits[j];
            _digits[j] = temp;
        }
    }
}
