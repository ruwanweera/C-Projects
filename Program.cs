// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

namespace TestProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 =new Employee("1203","Weerasinghe",50,1,10000);
            Employee E2 =new Employee ("1220","De Silva",48,1,120000);

            E1.EmpAge=52;
            Console.WriteLine(E1.EmpFirstName+"'s age is "+ E1.EmpAge);
            E2.EmpFirstName="De Alwis";
            E2.EmpAge=20;
       
            Console.WriteLine(E2.EmpFirstName+"'s age is "+ E2.EmpAge +" salary  of "+ E2.BasicSalary );

            Designation.PrintDesignation("Engineer");
            E1.PrintDetails();
            AdminOfficer E3 =new AdminOfficer("5002","Weerasinghe",50,1,105000);
             E3.PrintDuty();    
             E3.EmpAge=60;
            Console.WriteLine(E3.EmpFirstName+"'s age is "+ E3.EmpAge +" salary  of "+ E3.BasicSalary + "  is an ");
            E3.PrintDuty();  

          // Thread mainThread = Thread.CurrentThread;
           // mainThread.Name="Main Thread";

            //Thread thread1= new Thread(CountUp);
            //Thread thread2= new Thread(CountDown); 

            Thread thread1= new Thread(() => CountUp("Timer #1"));
            Thread thread2= new Thread(() => CountDown("Timer #2")); 
            thread1.Start();
            thread2.Start();

        } 

    


        public static void CountUp()
        {

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer thread #1 started  " + i +  " seconds");
                Thread.Sleep(1000);
            }
        }


        public static void CountDown()
        {

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer thread #2 started " + i +  " seconds");
                Thread.Sleep(1000);
            }
        }
    }
}
