using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace INEQ.Models.CatalagoDeEquipo
{
    public class CatalagoDeEquipo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string UsefulLife { get; set; }
        public string GuaranteeDuration { get; set; }
        public bool Active { get; set; }

    }
}
}