using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ.Models
{
    public class EquipmentType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string UsefulLife { get; set; }
        public string GuaranteeDuration { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; }

    }
}