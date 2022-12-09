using System;
using System.Diagnostics.CodeAnalysis;

namespace ClassLibrary
{
    public class Carro : IComparable<Carro>
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string img { get; set; }
        public string horarios { get; set; }
        public string ubicacion { get; set; }
        public string rating { get; set; }
        public string top { get; set; }


        public Carro()
        {
        }

        public Carro(string id, string nombre, string img, string horarios, string ubicacion, string rating ,string top)
        {
            this.id = id;
            this.nombre = nombre;
            this.img = img;
            this.horarios = horarios;
            this.ubicacion = ubicacion;
            this.top = top;
        }

        public string getTop()
        {
            return this.top;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int CompareTo([AllowNull] Carro other)
        {
            return top.CompareTo(other.top);
        }
    }
}
