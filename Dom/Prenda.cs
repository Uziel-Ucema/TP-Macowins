using System;
using System.Collections.Generic;
using System.Text;

namespace Dom
{
    public class Prenda
    {
        public Prenda() { }
        public Prenda(int codigo, string nombre, double precio, string tipo_prenda, string estado, int stock)//constructor sobrecargado para cargar una prenda de la que ya se tiene la info
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Tipo_Prenda = tipo_prenda;
            Estado = estado;
            Stock = stock;
        }
        public int Codigo { get; set; }//valores que puede tener una prenda
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Tipo_Prenda { get; set; }
        public string Estado { get; set; }
        public int Stock { get; set; }
    }
}
