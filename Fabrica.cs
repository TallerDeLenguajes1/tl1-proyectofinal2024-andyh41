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
            nuevoPersonaje.Datos.Nombre = Enum.GetName(typeof(NombresPersonajes),random.Next(1, Enum.GetNames(typeof(NombresPersonajes)).Length));
            switch (nuevoPersonaje.Datos.Nombre)
            {
                case "Chicha":
                    nuevoPersonaje.Datos.Raza="perro salchicha";
                    nuevoPersonaje.Datos.Poderespecial=PoderEspecial.AlientoPodrido.ToString();
                break;
                case "Zoe":
                    nuevoPersonaje.Datos.Raza="perro golden";
                    nuevoPersonaje.Datos.Poderespecial=PoderEspecial.PanzasoLetal.ToString();
                break;
                case "Odie":
                    nuevoPersonaje.Datos.Raza="perro rescatado";
                    nuevoPersonaje.Datos.Poderespecial=PoderEspecial.LadridoEnzordecedor.ToString();
                break;
                case "Laika":
                    nuevoPersonaje.Datos.Raza="perro rescatado";
                    nuevoPersonaje.Datos.Poderespecial=PoderEspecial.LadridoEnzordecedor.ToString();
                break;
                case "Chola":
                    nuevoPersonaje.Datos.Raza="perro rescatado";
                    nuevoPersonaje.Datos.Poderespecial=PoderEspecial.AlientoPodrido.ToString();
                break;
                case "Kiki":
                    nuevoPersonaje.Datos.Raza="gato blanco";
                    nuevoPersonaje.Datos.Poderespecial=PoderEspecial.GarritaAfilada.ToString();
                break;
                case "Holguita":
                    nuevoPersonaje.Datos.Raza="gato gris";
                    nuevoPersonaje.Datos.Poderespecial=PoderEspecial.PanzasoLetal.ToString();
                break;
                case "Joaquin":
                    nuevoPersonaje.Datos.Raza="gato manchado";
                    nuevoPersonaje.Datos.Poderespecial=PoderEspecial.MaullidoCansador.ToString();
                break;
                case "Grisa":
                    nuevoPersonaje.Datos.Raza="perro rescatado";
                    nuevoPersonaje.Datos.Poderespecial=PoderEspecial.GarritaAfilada.ToString();
                break;
                case "Negrito":
                    nuevoPersonaje.Datos.Raza="gato negro";
                    nuevoPersonaje.Datos.Poderespecial=PoderEspecial.MaullidoCansador.ToString();
                break;

                default:
                break;
            }
            
            return nuevoPersonaje;
        }

     
        private static Random random = new Random();
        public string MostrarPersonaje(){
            return  "Nombre: "+ Nombre + " | Raza: " + Raza + " | Super Poder: " + Poderespecial + " | Fuerza: " + Fuerza + " | Velocidad: " + Velocidad + " | Recistencia: " + Resistencia;
        }
    }
   
    public enum NombresPersonajes {
        Chicha=1,
        Zoe=1,
        Odie=1,
        Laica=1,
        Chola=1,
        Kiki=0,
        Holguita=0,
        Joaquin=0,
        Grisa=0,
        Negrito=0

    }

    public enum PoderEspecial {
        PanzasoLetal,
        LadridoEnzordecedor,
        MaullidoCansador,
        AlientoPodrido,
        GarritaAfilada
    }
}