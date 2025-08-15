using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class User
    { // BoCo class not have any behaviour, it is just a data holder    

        public int Id { get; set; }
        public string? FullName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public Guid SecuirtyStamp { get; set; } 



    }
}
