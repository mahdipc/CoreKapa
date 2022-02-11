using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kappa.Models
{
    public class BaseModel<T>
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<ChangeLog<T>>? ChangeLogs { get; set; }
    }
}
