using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trellee.Models
{
    public class User
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<BoardSubscriptions> Subscriptions { get; set; }
    }
}
