using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net.BLL.Models
{
    public class Author
    {

        public string au_id { get; set; } // 999-93-9929
        public string au_fname { get; set; }

        public string au_lname { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool Contract { get; set; }

    }
}
