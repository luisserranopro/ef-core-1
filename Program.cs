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
                Console.WriteLine("> Creación de una nueva localidad");
                db.Add(new Localidad { NombreLocalidad = "Granada" }); 
                db.SaveChanges(); 

                Console.WriteLine("> Búsqueda de localidad");
                var localidad = db.Localidades.OrderBy(l => l.LocalidadId).First(); 
                Console.WriteLine("> Modificación de localidad");
                localidad.NombreLocalidad = "Santander"; 
                localidad.Personas.Add( new Persona { NombrePersona = "Carmen"}); 
                db.SaveChanges(); 
                
                Console.WriteLine("> Eliminación de localidad");
                db.Remove(localidad); 
                db.SaveChanges(); 
            }

        }
    }
}
