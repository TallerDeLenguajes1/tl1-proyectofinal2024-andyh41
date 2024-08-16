
using Mensajes
using Personajes;
using EspacioPelea;
using Historial;
using FabricaPersonajes;

namespace EspacioSeleccionDePersonaje
{
    public class SeleccionDePersonaje
    {
        public static async Task SelectorDePersonajes(List<Personaje> listaPersonajes)
        {
            Console.Clear();
            //Ayuda.IntroduccionJuego();
            await SelectorDePersonajeAsync(listaPersonajes);

        }
      
        private static async Task SelectorDePersonajeAsync(List<Personaje> listaPersonajes)
        {
            int ID=0;
            foreach (var personaje in listaPersonajes)
            {
                Fabrica.MostrarPersonaje(personaje,ID);
               ID++;
            }

            int elegido;
            bool control;
            do
            {
                Console.WriteLine("Seleccione el Personaje con el que jugará (ID): ");
                string? Eleccion = Console.ReadLine();
                control = int.TryParse(Eleccion, out elegido);
                if (!control || elegido < 0 || elegido > 9)
                {
                    Console.WriteLine("Entrada no válida. Por favor ingrese un número entre 0 y 9.");
                    
                }


            } while (!control || elegido < 0 || elegido > 9);
            
            var PersonajeElegido = listaPersonajes[elegido];
            listaPersonajes.Remove(PersonajeElegido);

            await Pelea.InicioCombate(listaPersonajes,PersonajeElegido); 

           
        }
    }
}