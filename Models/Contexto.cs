using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using FindMyPet.Models;

namespace FindMyPet.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Animais> Animais { get; set; } 
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Observacoes> Observacoes { get; set; } 
    }
}