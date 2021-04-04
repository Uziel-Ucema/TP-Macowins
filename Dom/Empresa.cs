using System;
using System.Collections.Generic;
using System.Text;

namespace Dom
{
    public class Empresa
    {
        public Empresa()
        {
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");//variable para saber el dia actual y despues mostrarlo en el registro
            Catalogo = new List<Prenda>();//en el constructor de empresa creo el catalogo de Macowins para poder probar el programa de forma mas sencilla y no tener que conectarme con una base sql o tener que usar otro metodo un poco mas complejo
            Registro = "Registro de ventas del dia " + date + ": ";
            Ganancias_Totales = 0;
            Catalogo.Add(new Prenda(1, "Pantalón de vestir noche brilloso entallado", 2499.99, "Pantalón", "Nuevo", 2));
            Catalogo.Add(new Prenda(2, "Pantalón gabardina liso entallado", 1299.99, "Pantalón", "Promocion", 5));
            Catalogo.Add(new Prenda(3, "Saco de corderoy entallado", 9665.49, "Saco", "Promocion", 3));
            Catalogo.Add(new Prenda(4, "Saco entallado", 3999.49, "Saco", "Liquidacion", 9));
            Catalogo.Add(new Prenda(5, "Camisa sport estampada de flores slim fit", 2399.99, "Camisa", "Nuevo",5));
            Catalogo.Add(new Prenda(6, "Camisa sport a cuadros manga corta slim fit", 1479.99, "Camisa", "Liquidacion", 7));
        }
        public List<Prenda> Catalogo { get; set; }//elementos que puede tener la empresa
        private string Registro { get; set; }
        private double Ganancias_Totales { get; set; }

        public string Mostrar_Registros()//metodos usados
        {
            return Registro;
        }
        public double Mostrar_Ganancias()
        {
            return Ganancias_Totales;
        }
        public Prenda BuscarPrendaVenta(int codigo, int cantidad)//para vender una prenda primero tenemos que buscar cual es la que se quiere vender
        {
            Prenda buscada = null;
            foreach (Prenda p in Catalogo)
            {
                if(p.Codigo == codigo)
                {
                    buscada = p;
                    break;
                }
            }
            return buscada;
        }
        public void Vender(Prenda p, int cantidad, int f_de_pago)//a la hora de vender, buscamos la ganancia, se guarda la venta en los registros y se actualiza el stock
        {
            double ganancia = CalcularGanancia(p, cantidad, f_de_pago);
            Registro += $"Prenda: {p.Nombre} - Cantidad: {cantidad} - Ganancia: {ganancia} | ";
            Ganancias_Totales += ganancia;
            p.Stock = p.Stock - cantidad;
        }
        public void VenderEnPromo(Prenda p, int cantidad, int f_de_pago,double valor_promo)//a la hora de vender, buscamos la ganancia, se guarda la venta en los registros y se actualiza el stock
        {
            double ganancia = 0;
            double precio_final = p.Precio - valor_promo;
            if (f_de_pago == 0)//efectivo
            {
                ganancia = precio_final * cantidad;
            }
            else if (f_de_pago == 1)//tarjeta 1 pago
            {
                ganancia = precio_final * cantidad + 3 + 0.01 * p.Precio;
            }
            else if (f_de_pago == 2)//tarjeta 6 cuotas
            {
                ganancia = precio_final * cantidad + 6 * 3 + 0.01 * p.Precio;

            }
            else if (f_de_pago == 3)//tarjeta 12 cuotas
            {
                ganancia = precio_final * cantidad + 12 * 3 + 0.01 * p.Precio;
            }
            ganancia = Math.Truncate(ganancia * 100) / 100;
            Registro += $"Prenda: {p.Nombre} - Cantidad: {cantidad} - Ganancia: {ganancia} | ";
            Ganancias_Totales += ganancia;
            p.Stock = p.Stock - cantidad;
        }
        public double CalcularGanancia(Prenda p, int cantidad, int f_de_pago)//metodo usado a la hora de calcular de cuanto va a ser la ganancia ya que hay variacion tanto en el estado de la prenda como en las formas de pago
        {
            double total = 0;
            double precio_final = p.Precio;
            if(p.Estado == "Liquidacion")
            {
                precio_final = p.Precio * 0.5;
            }
            if (f_de_pago == 0)//efectivo
            {
                total = precio_final * cantidad;
            }
            else if (f_de_pago == 1)//tarjeta 1 pago
            {
                total = precio_final * cantidad + 3 + 0.01 * p.Precio;
            }
            else if (f_de_pago == 2)//tarjeta 6 cuotas
            {
                total = precio_final * cantidad + 6 * 3 + 0.01 * p.Precio;

            }
            else if (f_de_pago == 3)//tarjeta 12 cuotas
            {
                total = precio_final * cantidad + 12 * 3 + 0.01 * p.Precio;
            }
            return Math.Truncate(total * 100) / 100;
        }
    }
}
