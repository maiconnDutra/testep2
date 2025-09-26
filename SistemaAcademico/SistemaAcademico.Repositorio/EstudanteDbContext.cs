using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Repositorio
{
    public class EstudanteDbContext : DbContext
    {
        public EstudanteDbContext(DbContextOptions<EstudanteDbContext> options)
            : base(options)
        {
        }

        // DbSet = tabela de estudantes
        public DbSet<Estudante> Estudantes { get; set; }
    }
}
