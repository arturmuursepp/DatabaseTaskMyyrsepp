using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class FoodCoupon
    {
        public int Id { get; set; }
        public IEnumerable<Student>? Students { get; set; } = new List<Student>();
        public DateTime ExpireDate { get; set; } 
    }
}
