using System;
using System.Collections.Generic;

namespace classes{
    public class Company {
        private DateTime _foundedOn {get; set;}
        private string _name {get; set;}

        public Company(string name)
        {_name = name;}

        public string GetName (){
            return _name;
        }

        public void found () {
            _foundedOn = DateTime.Now;
        }

        public DateTime getFoundingDate () {
            return _foundedOn;
        }
        public List<Employee> currentEmployees = new List<Employee>();

        public void listEmployees (){
            foreach (Employee employee in currentEmployees)
            {
                Console.WriteLine($@"
 {employee.getName()} works for {GetName()}, INC. as a {employee.Title} since {employee.getHireDate()}");
            }
        }

        public void addEmployee(Employee employeeToAdd){
            currentEmployees.Add(employeeToAdd);
        }

        // public void addEmployee (List<Employee> employeeToAdd){
        //     currentEmployees.Add(employeeToAdd);
        // }
    }

}