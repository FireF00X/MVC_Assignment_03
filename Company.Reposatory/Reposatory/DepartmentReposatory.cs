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
    public class DepartmentReposatory : GenericReposatory<Department>, IDepartmentReposatory
    {
        public DepartmentReposatory(CompanyDbContext context) : base(context) 
        {
        }
    }
}
