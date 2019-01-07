using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trellee.Models
{
    public class BoardSubscriptions
    {
        public int ID { get; set; }
        public int BoardID { get; set; }
        public int UserID { get; set; }
        public Boolean IsAdmin { get; set; }

        public virtual Board Board { get; set; }
        public virtual User User { get; set; }
    }
}
