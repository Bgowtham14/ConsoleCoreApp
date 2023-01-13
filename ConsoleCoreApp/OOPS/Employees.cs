using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class Employees
    {
        int _EmpCode;
        string _EmpName;
        float _EmpSalary;

        public Employees()
        {
            Console.WriteLine("Default constructor called");
            this._EmpSalary= 20000;
        }
        public Employees(int _EmpCode, string _EmpName, float _EmpSalary)
        {
            this._EmpCode = _EmpCode;
            this._EmpName = _EmpName;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Parametric constructor-1 called");
        }
        public Employees(int _EmpCode, float _EmpSalary)
        {
            this._EmpCode = _EmpCode;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Parametric constructor-2 called");
        }
        static Employees()    //static constructor
        {
            Console.WriteLine("Static constructor called");
        }
        ~Employees()    //Destructor constructor called
        {
            Console.WriteLine("Object Removed");
        }
        public void  SetEmployeeDetails(int _EmpCode, string _EmpName, float _EmpSalary)
        {
            this._EmpCode = _EmpCode;
            this._EmpName = _EmpName;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Details Saved!!!");

        }
        internal void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details is:");
            Console.WriteLine($"Code:{_EmpCode}\tName:{_EmpName}\tSalary:{_EmpSalary}");
        }
    }
}
