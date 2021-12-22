using Exercises._1Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2Inheritance
{
    class Exercise
    {
        public static void Start()
        {
            var pontus = new Employee("Pontus", "Programmer");
            
            var company = new Company("1 Company");
            company.Employees.Add(pontus);
            company.Employees.Add(new Employee("Joe", "HR"));
            company.Employees.Add(new Employee("Damika", "Customer Care"));
            company.Employees.Add(new Employee("Amir", "IT"));
            company.Employees.Add(new Employee("Sara", "Legal"));
            company.Employees.Add(new Employee("Trevan", "Training"));
            company.Consultants.Add(new Consultant("Jose", 250, 8));
            company.Consultants.Add(new Consultant("Simon", 300, 10));

            Console.WriteLine(company.Employees.Count);

            var hive = new Hive(new Queen("Queenie"));
            hive.Drones.Add(new Drone("Bitey", 2.5));
            hive.Drones.Add(new Drone("Buzzy", 1.5));
            hive.Drones.Add(new Drone("Swat", 0.5));
        }

    }
}
