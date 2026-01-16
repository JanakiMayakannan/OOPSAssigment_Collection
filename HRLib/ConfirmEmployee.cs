using System;
using System.Collections.Generic;
using System.Text;


namespace HRLib
{
    //GIT hub change
    public class ConfirmEmployee : Employee
    {
        #region Property
        public double Basic
        {
            get;
            
            set;
            
        }
         
        public string Designation
        {
            get; set;
        }
   
        
        #endregion

        #region Constructor


        public ConfirmEmployee() : base()
        {
            Basic = 0;
            Designation = "NA";
        }

       
        public ConfirmEmployee(string name, string address, double basic, string designation)
            : base(name, address)
        {
            //if (basic < 5000)
            //     throw new InvalidBasicException("Basic salary must be minimum Rs. 5000");

            Basic = basic;
            Designation = designation;
        }
        #endregion

        #region Override_Sal
        public sealed override double CalculateSalary()
        {
            double hra, conv, pf;

            if (Basic >= 30000)
            {
                hra = Basic * 0.30;
                conv = Basic * 0.30;
                pf = Basic * 0.10;
            }
            else if (Basic >= 20000)
            {
                hra = Basic * 0.20;
                conv = Basic * 0.20;
                pf = Basic * 0.10;
            }
            else
            {
                hra = Basic * 0.10;
                conv = Basic * 0.10;
                pf = Basic * 0.10;
            }

            return Basic + hra + conv - pf;
        }
        #endregion
        public override string ToString()
        {
            return base.ToString() +
                   $"\nDesignation : {Designation}\nBasic       : {Basic}\nNet Salary  : {CalculateSalary()}";
        }
    }
}
