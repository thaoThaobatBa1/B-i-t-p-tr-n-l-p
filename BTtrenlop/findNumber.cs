using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtrenlop
{
    public class findNumber
    {
        public List<int> FindEvenNumber(List<int> numbers) {
            return numbers.Where(x => x % 2 == 0).ToList();
        
        }
    }
}
