using System;
using System.Diagnostics.CodeAnalysis;

namespace ClassLibrary
{
    public class Carro : IComparable<Carro>
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string img { get; set; }
        public string horarios { get; set; }
        public string ubicacion { get; set; }
        public double rating { get; set; }
        public int top { get; set; }


        public Carro()
        {
        }

        public Carro(int id, string nombre, string img, string horarios, string ubicacion, double rating ,int top)
        {
            this.id = id;
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

        public override bool Equals(Object obj)
        {

            if (obj == null || GetType() != obj.GetType())
                return false;
            Carro r = (Carro)obj;
            return id.Equals(r.id);
        }
    }
}
