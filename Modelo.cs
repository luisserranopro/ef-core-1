using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MiPrimerPrograma
{
	public class Localidad 
	{
		public int LocalidadId { get; set; }
        public string NombreLocalidad { get; set; }
        
		public List<Persona> Personas { get; } = new List<Persona>();

	}

	public class Persona 
	{
		public int PersonaId { get; set; }
        public string NombrePersona { get; set; }

        public int LocalidadId { get; set; }
        public Localidad Localidad { get; set; }

	}

	 public class PrimerProgramaContext : DbContext
 	{
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=PrimerPrograma.db");
        
  	}


}