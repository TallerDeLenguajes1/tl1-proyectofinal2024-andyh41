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
            nuevoPersonaje.Datos.Poderespecial=Enum.GetName(typeof(Poderes), random.Next (1, Enum.GetNames(typeof(Poderes)).Length));
            return nuevoPersonaje;
        }

        public static List<Personaje> CreacionPersonajes(){
            var ListaP = new List<Personaje>();
            for (int i = 0; i < 10; i++)
            {
                ListaP.Add(CreacionPersonaje());
            }
            return ListaP;
        }

     
        private static Random random = new Random();
        
        public void MostrarPersonaje(Personaje personaje){
            Console.WriteLine("Nombre: "+personaje.Datos.Nombre);
            Console.WriteLine("Genero: "+personaje.Datos.Genero);
            Console.WriteLine("Raza: "+personaje.Datos.Raza);
            Console.WriteLine("Ataque especial: "+personaje.Datos.Poderespecial);
            Console.WriteLine("Fuerza: "+personaje.Caracteristicas.Fuerza);
            Console.WriteLine("Salud: "+personaje.Caracteristicas.Salud);
            Console.WriteLine("Velocidad: "+personaje.Caracteristicas.Velocidad);
            Console.WriteLine("Resistencia: "+personaje.Caracteristicas.Resistencia);
        }
    }
 
}