using System;
namespace salaryCalc {
    interface ItaxCalc
    {
        public int dependent (int dependents);
        public void taxCal (int grossPay, string gender, int dependents);   
    }
}