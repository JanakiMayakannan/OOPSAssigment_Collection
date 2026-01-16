
using System;

namespace HRLib
{
    public abstract class Employee
    {
        private static int empCounter = 1000;

        #region Property
        public int EmpNo
        {
            get; private set;
           
        }
        
        public string Name
        {
            get; set;
        }
  
        public string Address
        {
            get; set;
          
            
        }
        #endregion

        #region constructor
        public Employee()
        {
            EmpNo = ++empCounter;
            Name = "NA";
            Address = "NA";
        }

      
        public Employee(string name, string address) : this()
        {
            Name = name;
            Address = address;
        }

        #endregion

        #region abstract_method
        public abstract double CalculateSalary();
        #endregion
        public override string ToString()
        {
            return $"EmpNo: {EmpNo}\nName: {Name}\nAddress: {Address}";
        }
    }
}
