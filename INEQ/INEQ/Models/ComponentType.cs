﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ.Models
{
    public class ComponentType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Component> Components { get; set; }

    }
}