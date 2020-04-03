using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Crud.Models;
using Crud.Repositories;
using Dapper;
using Npgsql;

namespace ReporterCli {
    class Program {
        public static async Task Main(string[] args) {
            await using(var employeeRepository = new EmployeeRepository()) {
                var employees = await employeeRepository.GetAll();
                Console.WriteLine($"Employee count: {employees.AsList().Count}");
                foreach (var employee in employees) {
                    Console.WriteLine($"Name: {employee.Name}");
                }
            }
        }
    }
}
