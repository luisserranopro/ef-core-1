using System;
using System.Linq;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PrimerProgramaContext()) 
			{ 

				Console.WriteLine("Inserción de datos");
				db.Add(new Localidad { NombreLocalidad = "Granada" });
				db.SaveChanges(); 

				Console.WriteLine("Búsqueda de datos");
				var localidad = db.Localidades.OrderBy(l => l.LocalidadId).First(); 
				Console.WriteLine("	Nombre de localidad: " + localidad.NombreLocalidad);
				localidad.NombreLocalidad = "Santander"; 
				Console.WriteLine("	Nuevo nombre de localidad: "+ localidad.NombreLocalidad);
				localidad.Personas.Add( new Persona { NombrePersona = "Carmen"}); 
				db.SaveChanges(); 

				Console.WriteLine("Borrado de datos");
				db.Remove(localidad);
				db.SaveChanges(); 
			}

        }
    }
}
