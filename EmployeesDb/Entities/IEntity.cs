using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDb.Entities
{
    public interface IEntity
    {
        public int globalId { get; set; }
    }
}
