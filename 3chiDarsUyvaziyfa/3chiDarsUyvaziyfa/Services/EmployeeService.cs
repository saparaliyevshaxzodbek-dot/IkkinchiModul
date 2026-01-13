using _3chiDarsUyvaziyfa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3chiDarsUyvaziyfa.Services;

public class EmployeeService
{
    List<Employee> Employees = new List<Employee>();

    public Guid AddEmployee(Employee employee)
    {
        employee.EmployeeId = Guid.NewGuid();
        Employees.Add(employee);
        return employee.EmployeeId;
    }

    public Employee GetEmployeeById(Guid employeeId)
    {
        foreach(var  employee in Employees)
        {
            if(employee.EmployeeId == employeeId)
            {
                return employee; 
            }
        }

        return null;
    }

    public bool DeleteEmployee(Guid employeeId)
    {
        var employee = GetEmployeeById(employeeId);
        if (employee != null)
        {
            Employees.Remove(employee);
            return true;
        }
        return false;

    }

    public List<Employee> GetAllEmployees()
    {
        return Employees; 
    }


    public bool UpdateEmployee(Guid employeeID , Employee newemployee)
    {
        var employee = GetEmployeeById (employeeID);
        if (employee == null)
        {
            return false;
        }

        employee.PhoneNumber = newemployee.PhoneNumber;
        employee.FirstName = newemployee.FirstName;
        employee.LastName = newemployee.LastName;
        employee.Idkarta = newemployee.Idkarta;
        return true; 
    }

}
