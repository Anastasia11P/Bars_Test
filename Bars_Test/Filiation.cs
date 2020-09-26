using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars_Test
{
    class Filiation
    {
        private string _name;
        private string _address;
        private List<Unit> _units = new List<Unit>();
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name)
                    return;
                else
                    _name = value;
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                if (value == _address)
                    return;
                else
                    _address = value;
            }
        }
        public List<Unit> Units
        {
            get { return _units; }
            set
            {
                if (value == _units)
                    return;
                else
                    _units = value;
            }
        }
    }
}
