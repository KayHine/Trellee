using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trellee.Models
{
    public class SwimLane
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int BoardID { get; set; }
        public int Sequence { get; set; }
    }
}
