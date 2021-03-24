using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Film
    {
        public virtual int Id { get; set; }
        public virtual string Nazwa { get; set; }
        public virtual int Rok { get; set; }
        public virtual decimal Ocena { get; set; }
        public virtual GatunekFilmu RodzajId { get; set; }
        public virtual int? Jezyk { get; set; }
        public virtual Rezyser RezyserId { get; set; }
    }
}