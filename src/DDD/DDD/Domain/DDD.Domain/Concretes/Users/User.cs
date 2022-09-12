using DDD.Domain.Base;
using DDD.Domain.Concretes.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Concretes.Users
{
    public class Employee : IAggregateRoot
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public void SetDepartment(int id)
        {
            DepartmentId = id;
        }


    }
}
