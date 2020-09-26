using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars_Test
{
    class Enterprise
    {
        private List<Filiation> _filiations = new List<Filiation>();
        public List<Filiation> Filiations
        {
            get { return _filiations; }
            set
            {
                if (value == _filiations)
                    return;
                else
                    _filiations = value;
            }
        }
    }
}
