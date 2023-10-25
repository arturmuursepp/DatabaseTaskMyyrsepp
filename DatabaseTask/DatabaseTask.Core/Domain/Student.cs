using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public IEnumerable<Class> Classes { get; set; } = new List<Class>();
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string GuardianPhone { get; set; }
    }
}
