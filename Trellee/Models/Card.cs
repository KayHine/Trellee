using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trellee.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public DateTime DueDate { get; set; }
        public int Assignee { get; set; }
        public int SwimLaneID { get; set; }
    }
}
