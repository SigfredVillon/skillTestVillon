using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skillTestVillon.Strategy
{
    public class SortContext
    {
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public string Sort(string input)
        {
            return _sortStrategy?.Sort(input);
        }
    }
}
