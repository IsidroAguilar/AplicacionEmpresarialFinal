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
        public List<Platillos> catalogo = new List<Platillos>();
        public List<Pedidos> pedidos = new List<Pedidos>();

        public MainR()
        {
            InitializeComponent();
            ObtenerRestaurantes();
            ObtenerPlatillos();
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
                    LlenarPedidos();
                    dataGridPedidos.Refresh();
                    break;

                //Historial
                case "tabHistorial":
                    //Cargar Historial de la BD
                    LlenarHistorial();
                    dataGridHistorial.Refresh();
                    break;

                //Catalogo Platillos
                case "tabRestaurants":
                    //Cargar Catalogo de platillos de la BD
                    cmbRestaurantR.Refresh();
                    LlenarCatalogo();
                    dataGridCatalogo.Refresh();
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
            foreach (var item in catalogo)
                dataGridCatalogo.Rows.Add(item.NombrePlatillo.ToString(),
                    item.Restaurantes.Nombre.ToString(),
                    item.Precio.ToString());
        }

        void LlenarPedidos()
        {
            dataGridPedidos.Rows.Clear();
            PedidosController pedidosContr = new PedidosController();
            pedidos = pedidosContr.ObtenerPedidos().ToList();
            foreach (var item in pedidos.Where(x => x.Estatus == 1))
                dataGridPedidos.Rows.Add(false, item.Platillos.NombrePlatillo.ToString(),
                    item.Habitacion.NumeroHabitacion.ToString(), item.Platillos.Precio.ToString());

        }

        void LlenarHistorial()
        {
            dataGridHistorial.Rows.Clear();
            var idDescription = "";
            foreach (var item in pedidos)
            {
                switch (item.Estatus)
                {
                    case 1:
                        idDescription = "Activo"; break;
                    case 2:
                        idDescription = "Entregado"; break;
                    case 3:
                        idDescription = "Cancelado"; break;

                    default: break;
                }

                dataGridHistorial.Rows.Add(item.Platillos.NombrePlatillo.ToString(),
                    item.Habitacion.NumeroHabitacion.ToString(), item.Platillos.Precio.ToString(),
                    idDescription);
            }

        }

        void ObtenerRestaurantes()
        {
            //Se obtienen los restaurantes y se llenan los combo
            
        }

        void ObtenerPlatillos()
        {
            PlatillosController platillos = new PlatillosController();
            catalogo = platillos.ObtenerPlatillos().ToList();
        }

    }
}
