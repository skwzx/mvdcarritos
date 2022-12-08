using System;
using System.Diagnostics.CodeAnalysis;

namespace ClassLibrary
{
    public class Carro : IComparable<Carro>
    {
        public int id { get; set; }
        private static int ultimoId { get; set; } = 1;
        public string nombre { get; set; }
        public string img { get; set; }
        public string horarios { get; set; }
        public string ubicacion { get; set; }
        public double rating { get; set; }
        public int top { get; set; }


        public Carro()
        {
            id = ultimoId;
            ultimoId++;
        }

        public Carro(string nombre, string img, string horarios, string ubicacion, double rating ,int top)
        {
            id = ultimoId;
            ultimoId++;
            this.nombre = nombre;
            this.img = img;
            this.horarios = horarios;
            this.ubicacion = ubicacion;
            this.top = top;
        }

        public int getTop()
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
