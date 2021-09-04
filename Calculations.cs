using System;
namespace salaryCalc {
    abstract class Calculations : ItaxCalc{
        public abstract void myName () ;
        public int dependent (int dependents) {
            int benefit;
            if(dependents == 1){
                benefit = 2400;
            }
            else if (dependents == 2){
                benefit = 3400;
            }
            else if (dependents == 3){
                benefit = 4200;
            }
            else{
                benefit = 5000;
            }
            return benefit;
        }

        public void taxCal (int grossPay, string gender, int dependents) {
            double cpp = 3166.45;
            double ei = 889.54;
            double fedTax =0;
            double provTax =0; 
            double dependentBenefit = dependent(dependents);
            double taxableAmt = grossPay - cpp - ei - dependentBenefit;
            double netPay =0;
            double[] tax = new double[2];
            if(taxableAmt <= 45000){
                if(gender == "f"){
                    fedTax = taxableAmt*13/100;
                    tax[0] = fedTax;
                    
                } else{
                    fedTax = taxableAmt*15/100;
                    tax[0] = fedTax;
                }  
                provTax = taxableAmt*5/100;
                tax[1] = provTax;               
            }

            else if(taxableAmt > 45000 && taxableAmt <= 98000){
                if(gender == "f"){
                    fedTax = taxableAmt*18/100;
                    tax[0] = fedTax;
                } else{
                    fedTax = taxableAmt*20.5/100;
                    tax[0] = fedTax;
                }  
                provTax = taxableAmt*9/100;
                tax[1] = provTax;
            }

            else if(taxableAmt > 98000 && taxableAmt <= 150000){
                if(gender == "f"){
                    fedTax = grossPay*24/100;
                    tax[0] = fedTax;
                } else{
                    fedTax = taxableAmt*26/100;
                    tax[0] = fedTax;
                } 
                provTax = taxableAmt*11/100;
                tax[1] = provTax;
            }

            else if(taxableAmt > 150000 && taxableAmt <= 200000){
                if(gender == "f"){
                    fedTax = grossPay*27/100;
                    tax[0] = fedTax;
                } else{
                    fedTax = taxableAmt*29/100;
                    tax[0] = fedTax;
                } 
                provTax = taxableAmt*12/100;
                tax[1] = provTax;
            }

            else if(taxableAmt > 200000){
                if(gender == "f"){
                    fedTax = taxableAmt*32/100;
                    tax[0] = fedTax;
                } else{
                    fedTax = taxableAmt*33/100;
                    tax[0] = fedTax;
                }
                provTax = taxableAmt*13/100;
                tax[1] = provTax;
            }
            netPay = grossPay + dependent(dependents) -cpp - ei - fedTax - provTax; 
            Console.WriteLine("Federal Tax: "+ Math.Round(tax[0], 2));
            Console.WriteLine("Provincial Tax: " + Math.Round(tax[1], 2)); 
            Console.WriteLine("Net Pay: "+ Math.Round(netPay, 2)); 
          
        }
    }
}