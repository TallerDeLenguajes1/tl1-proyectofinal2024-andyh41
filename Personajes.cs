using System.Collections.Specialized;

namespace Personajes
{

    public class Personaje
    {
        private Datos datos;
        private Caracteristicas caracteristicas;

        public Personaje()
        {
            datos = new Datos();
            caracteristicas = new Caracteristicas();
        }

        public Datos Datos { get => datos; set => datos = value; }
        public Caracteristicas Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
    }

    public class Datos
    {
        private string nombre;
        private string raza;
        private string poderespecial;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Poderespecial { get => poderespecial; set => poderespecial = value; }
    }

    public class Caracteristicas
    {
        private int fuerza;
        private int salud;
        private int velocidad;
        private int resistencia;


        public Caracteristicas()
        {
            fuerza = 0;
            salud = 0;
            velocidad = 0;
            resistencia = 0;
        }


        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Resistencia { get => resistencia; set => resistencia = value; }

    }
    
}