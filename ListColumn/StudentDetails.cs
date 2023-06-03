using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCoreFrameworkCodeFirstApproach.ListColumn
{
    public  class StudentDetails
    {
        [Key]public int Id { get; set; }
        public string studentName { get; set; }
        public int semester { get;set; }


    }
}
