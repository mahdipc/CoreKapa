using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kappa.Models
{
    public class ChangeLog<T>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public string TableName { get; } = nameof(T);
        public string? Description { get; set; }

    }
}
