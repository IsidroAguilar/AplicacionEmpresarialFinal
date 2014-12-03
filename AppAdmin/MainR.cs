using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaModelo.Modelo;
using HotelServiceFinal.Controllers;


namespace AppAdmin
{
    public partial class MainR : Form
    {
        public MainR()
        {
            InitializeComponent();
            ObtenerRestaurantes();
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            var pedidoSelec = dataGridPedidos.CurrentRow.Cells["cPlatillo"].Value.ToString();
            AskForm ask = new AskForm("Desea eliminar el pedido\nseleccionado ?");
            ask.ShowDialog();
            var option = ask.option;

            if (option == true)
            {
                dataGridPedidos.Rows.Remove(dataGridPedidos.CurrentRow);
                dataGridPedidos.Refresh();
                //Insertar en la base de datos la eliminacion

                MessageBox.Show("Pedido Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tabOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var opcion = tabOptions.SelectedTab.Name.ToString();

            switch (opcion)
            {
                //Pedidos Actuales
                case "tabPedidosAct":
                    dataGridPedidos.Refresh();
                    break;

                //Historial
                case "tabHistorial":
                    //Cargar Historial de la BD
                    dataGridHistorial.Refresh();
                    break;

                //Catalogo Platillos
                case "tabRestaurants":
                    //Cargar Catalogo de platillos de la BD
                    dataGridCatalogo.Refresh();
                    cmbRestaurantR.Refresh();
                    LlenarCatalogo();
                    break;

                //ABC Platillos
                case "tabPlatillos":
                    break;

                default: break;
            }
        }


        void LlenarCatalogo()
        {
            dataGridCatalogo.Rows.Clear();

        }

        void ObtenerRestaurantes()
        {
            //Se obtienen los restaurantes y se llenan los combo
        }


    }
}
