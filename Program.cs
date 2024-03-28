// See https://aka.ms/new-console-template for more information
using System;


namespace TestProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 =new Employee("1203","Weerasinghe",50,1,10000);
            Employee E2 =new Employee("1220","De Silva",48,1,120000);

            E1.EmpAge=52;
            Console.WriteLine(E1.EmpFirstName+"'s age is "+ E1.EmpAge);
            E2.EmpFirstName="De Alwis";
            Console.WriteLine(E2.EmpFirstName+"'s age is "+ E2.EmpAge +" salary  of "+ E2.BasicSalary );

            Designation.PrintDesignation("Engineer");
            
       
       }

    }
}
