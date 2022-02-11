using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kappa.Models;

namespace Kappa.Workflow
{
    public class Main:BaseModel<Main>
    {
        public int Step { get; set; }
        public int NextStep { get; set; }
        public int PreviousStep { get; set; }
        public ICollection<Attribute> Attributes { get; set; }
    }
}
