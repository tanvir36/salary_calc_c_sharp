using System;
namespace salaryCalc
{
    class Program
    {
          
        static void Main(string[] args)
        {
            Details ob = new Details();
            string answer = "y";
            while (answer=="y"){
                ob.details();
                Console.WriteLine("Want to use again?? (Y/N)");
                answer = Console.ReadLine();
                answer= answer.ToLower();
            }          
        }  
    }
}
