using Personajes;

namespace FabricaPersonajes
{
    public class Fabrica
    {

        private static Personaje CreacionPersonaje()
        {
            Personaje nuevoPersonaje = new Personaje();

            //caracteristicas alertorias
            nuevoPersonaje.Caracteristicas.Fuerza = random.Next(50, 100);
            nuevoPersonaje.Caracteristicas.Salud = 100;
            nuevoPersonaje.Caracteristicas.Velocidad = random.Next(50, 100);
            nuevoPersonaje.Caracteristicas.Resistencia = random.Next(50, 100);
            // datos
            nuevoPersonaje.Datos.Nombre= 
            nuevoPersonaje.Datos.Genero=
            nuevoPersonaje.Datos.Raza=
            nuevoPersonaje.Datos.Poderespecial=
            return nuevoPersonaje;
        }
        public static List<Personaje> CreacionPersonajes()
        {   

            var listaPersonajes = new List<Personaje>;
            for (int i = 0; i < 10; i++)
            {
                Personaje personajeNuevo = this.CreacionPersonaje();
                listaPersonajes.Add(personajeNuevo);
            }
            return listaPersonajes;
        } 

     
        private static Random random = new Random();
        
        public void MostrarPersonaje(Personaje personaje){
            console.WriteLine("-------------------------------");
            Console.WriteLine("Nombre: "+personaje.Datos.Nombre);
            Console.WriteLine("Genero: "+personaje.Datos.Genero);
            Console.WriteLine("Raza: "+personaje.Datos.Raza);
            Console.WriteLine("Ataque especial: "+personaje.Datos.Poderespecial);
            Console.WriteLine("Fuerza: "+personaje.Caracteristicas.Fuerza);
            Console.WriteLine("Salud: "+personaje.Caracteristicas.Salud);
            Console.WriteLine("Velocidad: "+personaje.Caracteristicas.Velocidad);
            Console.WriteLine("Resistencia: "+personaje.Caracteristicas.Resistencia);
            console.WriteLine("-------------------------------");
        }

        
    }

 
}