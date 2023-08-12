using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDb.Entities
{
    public class Project : IEntity
    {
        public int globalId { get; set; }
        public int Id { get; set; }
        public int ProjectCost { get; set; }
    }
}
