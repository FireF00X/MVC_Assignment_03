using Company.Reposatory.Interfaces;
using Company_Data.Context;
using Company_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Reposatory.Reposatory
{
    public class EmployeeReposatory : GenericReposatory<Employee> , IEmployeeReposatory
    {
        private readonly CompanyDbContext _context;

        public EmployeeReposatory(CompanyDbContext context) : base(context) 
        {
            _context = context;
        }
    }
}
