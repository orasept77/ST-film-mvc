using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class GatunekFilmu
    {
        public virtual int Id { get; set; }
        public virtual string Nazwa { get; set; }
        public virtual int Aktywny { get; set; }
    }
}