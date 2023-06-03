using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCoreFrameworkCodeFirstApproach.ListColumn
{
    public  class StudentDepartment
    {
        [Key] public int dId { get; set; }
        public string dName { get; set; }

    }
}
