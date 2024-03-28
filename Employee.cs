using System;
using System.Dynamic;


namespace TestProject;

    class Employee
    {
        private string EmpNo;
        private string   FirstName;
        private int  Age;
        public int Category;
        public int BasicSalary;

        public string EmpID { get { return EmpNo;}}
        public string EmpFirstName { get { return FirstName; } set { FirstName = value; } }
        public int EmpAge {get { return Age;} set { Age = value; }  }

        public Employee(string argEmpNo,string argFirstName, int argAge, int argCategory, int argBasicSalary)

        {
            EmpNo=argEmpNo;
            FirstName=argFirstName;
       
            Category=argCategory;
            BasicSalary=argBasicSalary;

            Console.WriteLine(EmpNo + " Belongs to " + FirstName +"\n");
        }

        


    }
    


