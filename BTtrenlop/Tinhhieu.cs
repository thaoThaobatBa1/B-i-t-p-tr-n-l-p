using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtrenlop
{
    public class Tinhhieu
    {
        private int[] numbers;
        private int difference;

        public Tinhhieu()
        {
            numbers = new int[] { 10, 4, 6, 18 };
            difference = numbers[0] - numbers[1] - numbers[2] - numbers[3];
        }

        public int[] GetNumbers()
        {
            return numbers;
        }

        public int GetDifference()
        {
            return difference;
        }
    }
}
