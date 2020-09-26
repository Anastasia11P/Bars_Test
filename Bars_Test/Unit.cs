using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars_Test
{
    class Unit
    {
        private string _name;
        private List<Employee> _employee = new List<Employee>();
        private Filiation _filiation;
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
        public List<Employee> Employees
        {
            get { return _employee; }
            set
            {
                if (value == _employee)
                    return;
                else
                    _employee = value;
            }
        }
        public Filiation Filiation
        {
            get { return _filiation; }
            set
            {
                if (value == _filiation)
                    return;
                else
                    _filiation = value;
            }
        }
    }
}
