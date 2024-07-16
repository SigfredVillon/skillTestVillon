using skillTestVillon.Model;
using skillTestVillon.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skillTestVillon.Controller
{
    public class SortController
    {
        private SortModel _model;
        private SortContext _context;

        public SortController(SortModel model, SortContext context)
        {
            _model = model;
            _context = context;
        }

        public void SortString()
        {
            _model.SortedString = _context.Sort(_model.InputString);
        }

    }
}
