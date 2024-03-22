using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceTaskOneCloud1.Models
{
    using System.Data.Entity;

    public class AppDbContext : DbContext
    {
        public DbSet<DivingEquipment> DivingEquipments { get; set; }
    }

}