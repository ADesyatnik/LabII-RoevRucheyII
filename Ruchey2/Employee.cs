using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruchey2
{
    public class Employee: Human, INameObj, IinZoo
    {
        public string Zoo { get; set; }
    }
}
