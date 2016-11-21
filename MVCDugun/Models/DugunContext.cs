using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDugun.Models
{
    public class DugunContext : DbContext
    {
        public virtual DbSet<Rezervasyon> Rezervasyonlar { get; set; }

        //connection stringin adını değiştirmek istersek aşağıdaki gibi tanımlarız
        public DugunContext() : base("BizimConnection") { }
    }
}
