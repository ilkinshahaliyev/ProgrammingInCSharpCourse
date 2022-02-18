using System.Collections.Generic;
using System;
using Task_2.Models;
using Bogus;

namespace Task_2.FakeData
{
    public static class FakeDataCreation
    {
        private static List<Employee> _employees;

        public static List<Employee> GetEmployees(int count)
        {
            if (_employees is null)
            {
                _employees = new Faker<Employee>()
                                .RuleFor(e => e.Id, f => f.IndexFaker + 1)
                                .RuleFor(e => e.Name, f => f.Name.FirstName())
                                .RuleFor(e => e.Surname, f => f.Name.LastName())
                                .RuleFor(e => e.DateOfBirth, f => f.Date.Recent())
                                .RuleFor(e => e.Position, f => f.Name.JobArea())
                                .RuleFor(e => e.Salary, f => f.Random.UShort())
                                .RuleFor(e => e.IsManager, f => f.Random.Bool())
                                .Generate(count);
            }

            return _employees;
        }
    }
}
