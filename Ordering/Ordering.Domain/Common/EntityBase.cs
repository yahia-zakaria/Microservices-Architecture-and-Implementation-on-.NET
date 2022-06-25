﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Common
{
    public abstract class EntityBase
    {
        public int Id { get;  set; }
        public int CreatedBy { get;  set; }
        public DateTime CreatedAt { get;  set; }
        public int ModifiedBy { get;  set; }
        public DateTime ModifiedAt { get;  set; }
    }
}
