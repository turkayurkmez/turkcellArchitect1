using DDD.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Concretes.Departments
{
    public class Department : IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void Update(string name, string description)
        {
            Name = name;
            Description = description;
        } 


    }
}
