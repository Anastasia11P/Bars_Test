using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars_Test
{
    class Employee
    {
        private FIO _fio = new FIO();
        private string _typeSalary;
        private decimal _time;
        private decimal _salary;
        private Unit _unit;

        public FIO EmployeeFIO
        {
            get { return _fio; }
            set
            {
                if (value == _fio)
                    return;
                else
                    _fio = value;
            }
        }
        public string TypeSalary
        {
            get { return _typeSalary; }
            set
            {
                if (value == _typeSalary)
                    return;
                else
                    _typeSalary = value;
            }
        }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value == _salary)
                    return;
                else
                    _salary = value;
            }
        }
        public decimal SumSalary
        {
            get 
            { 
                if(_typeSalary == "Почасовая оплата")
                    return _salary*_time;
                return _salary;
            }
        }
        public decimal Time
        {
            get { return _time; }
            set
            {
                if (value == _time)
                    return;
                else
                    _time = value;
            }
        }
        public Unit Unit
        {
            get { return _unit; }
            set
            {
                if (value == _unit)
                    return;
                else
                    _unit = value;
            }
        }
    }
    class FIO 
    {
        private string _name;
        private string _surname;
        private string _pathronymic;
        
        public string Name 
        { 
            get { return _name; }
            set {
                if (value == _name)
                    return;
                else
                    _name = value;
            } 
        }
        public string Surname 
        {
            get { return _surname; }
            set
            {
                if (value == _surname)
                    return;
                else
                    _surname = value;
            }
        }
        public string Pathronymic
        {
            get { return _pathronymic; }
            set
            {
                if (value == _pathronymic)
                    return;
                else
                    _pathronymic = value;
            }
        }
    }
}
