using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee : Employee
    {
        #region Property
        public int NoOfDays
        {
            get; set;
        }
           
                
        

        public double RatePerDay
        {
            get; set;
        }
                
       
        #endregion

        #region Constructor
        public Trainee() : base()
        {
            NoOfDays = 0;
            RatePerDay = 0;
        }

        
        public Trainee(string name, string address, int days, double rate)
            : base(name, address)
        {
            NoOfDays = days;
            RatePerDay = rate;
        }
        #endregion

        #region override_sal
        public sealed override double CalculateSalary()
        {
            return NoOfDays * RatePerDay;
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() +
                   $"\nDays        : {NoOfDays}\nRate/Day    : {RatePerDay}\nSalary      : {CalculateSalary()}";
        }
    }
}
