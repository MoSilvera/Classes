using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company codeRUs= new Company("Code R Us");
            codeRUs.found();

            Employee moSilvera= new Employee("Mo", "Silvera");
            moSilvera.Hire();
            moSilvera.setEmployeeTitle("Director of not giving a damn");

            Employee kirrenCovey = new Employee("Kirren", "Covey");
            kirrenCovey.Hire();
            kirrenCovey.setEmployeeTitle("Animal interpreter");

            Employee janetWoods = new Employee ("Janet", "Woods");
            janetWoods.Hire();
            janetWoods.setEmployeeTitle("Manager of 'YAY!' division ");

            codeRUs.addEmployee(moSilvera);
            codeRUs.addEmployee(kirrenCovey);
            codeRUs.addEmployee(janetWoods);
            codeRUs.listEmployees();
        }
    }
}
