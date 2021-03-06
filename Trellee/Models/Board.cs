﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trellee.Models
{
    public class Board
    {
        public int ID { get; set; }
        public Boolean IsPrivate { get; set; }

        public virtual ICollection<BoardSubscriptions> Subscriptions { get; set; }
    }
}
