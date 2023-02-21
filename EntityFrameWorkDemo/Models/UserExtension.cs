using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo.Models
{
    public partial class User
    { 
        public string UserWithId { 
            get
            {
                return UserGkey + " " + Username;
            } 
        }
    }
}
