using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Macowins_de_Uziel_Luna
{
    public partial class FormPrincipal : Form
    {
        Dom.Empresa em = new Dom.Empresa();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = em.Catalogo;
            txtRegistros.Text = em.Mostrar_Registros();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try { int y = int.Parse(txtCodigo.Text); }//revisamos que no haya errores a la hora de introducir los distintos valores
            catch (Exception ex) { MessageBox.Show("Error al ingresar codigo"); return; }
            try { int y = int.Parse(txtCant.Text); }
            catch (Exception ex) { MessageBox.Show("Error al ingresar cantidad"); return; }
            if (txtFdePago.Text != "0" && txtFdePago.Text != "1" && txtFdePago.Text != "2" && txtFdePago.Text != "3")
            { MessageBox.Show("Error en la forma de pago"); return; }
            Dom.Prenda buscada = em.BuscarPrendaVenta(int.Parse(txtCodigo.Text), int.Parse(txtCant.Text));
            if(buscada == null) { MessageBox.Show("No se encontro la prenda buscada."); return; }
            if(buscada.Stock < int.Parse(txtCant.Text)) { MessageBox.Show("La prenda buscada tiene menos stock del pedido"); return; }
            if(buscada.Estado == "Promocion") { string promo = Interaction.InputBox("Ingrese el valor a descontar al estar en promocion: ");
                if(double.TryParse(promo, out double valor))
                {
                    double promo_valor = double.Parse(promo);
                    em.VenderEnPromo(buscada, int.Parse(txtCant.Text), int.Parse(txtFdePago.Text),promo_valor); 
                }
                else
                {
                    MessageBox.Show("No se ingreso un numero");
                    return;
                }
            }
            else
            {
                em.Vender(buscada, int.Parse(txtCant.Text), int.Parse(txtFdePago.Text));
            }
            Actualizar();
        }
        private void Actualizar()//cada vez que realizamos una venta hay que actualizar la informacion que se muestra en pantalla
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
            labelGanancias.Text = "Las ganancias de hoy son de: $" + em.Mostrar_Ganancias().ToString();
            txtRegistros.Text = em.Mostrar_Registros();
        }
    }
}
