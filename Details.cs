using System;
namespace salaryCalc {
    class Details : Calculations{
        public override void myName () {
            Console.WriteLine("Thank you from Tanvir");
        }
        public void details() {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter ypour email Id ");
            string userId = Console.ReadLine();
            Console.WriteLine("Please enter number of dependents");
            int dependents = Convert.ToInt32(Console.ReadLine()) ; 
            Console.WriteLine("Please enter your gender F/M");
            string gender = Console.ReadLine(); 
            gender = gender.ToLower();
            Console.WriteLine("Please enter your gross Pay");
            int grossPay = Convert.ToInt32(Console.ReadLine());
            taxCal(grossPay, gender , dependents);
            myName();           
        } 
    }
}