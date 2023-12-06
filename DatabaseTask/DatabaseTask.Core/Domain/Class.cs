using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Vintage { get; set; }
        public IEnumerable<GroupSupervisor> GroupSupervisors { get; set; } = new List<GroupSupervisor>();
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
    }
}
