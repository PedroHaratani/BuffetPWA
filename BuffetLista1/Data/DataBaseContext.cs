using BuffetLista1.Models.Acesso;
using BuffetLista1.Models.Buffet.Cliente;
using BuffetLista1.Models.Buffet.Evento;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuffetLista1.Data
{
    public class DataBaseContext : IdentityDbContext<Usuario,Papel, Guid>
    {
        public DbSet<ClienteEntity> Clientes { get; set; }

        public DbSet<EventoEntity> Eventos { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options) 
        { 
        }
    }
}
