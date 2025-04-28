using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VargasM_EvaluacionProgreso1.Models;

namespace VargasM_EvaluacionProgreso1.Data
{
    public class VargasM_EvaluacionProgreso1Context : DbContext
    {
        public VargasM_EvaluacionProgreso1Context (DbContextOptions<VargasM_EvaluacionProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<VargasM_EvaluacionProgreso1.Models.Clientes> Clientes { get; set; } = default!;
    }
}
