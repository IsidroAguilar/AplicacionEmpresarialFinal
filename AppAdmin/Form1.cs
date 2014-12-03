using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelServiceFinal.Controllers;

namespace AppAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var servicio = new ActDirectoryController();
            var acceso = servicio.SignAdmin(txtUser.Text, txtPassword.Text);
            if(acceso != "")
            {
                if(acceso == "Recepcion")
                {
                    MainA recepcion = new MainA();
                    recepcion.Show();
                    this.Hide();
                }
                else
                {
                    var nivel = 0;
                    if (acceso == "RestaurantA")
                        nivel = 1;
                    MainR restaurant = new MainR(nivel);
                    restaurant.Show();
                    this.Hide();
                }

            }
            else
            {

            }


        }
    }
}
