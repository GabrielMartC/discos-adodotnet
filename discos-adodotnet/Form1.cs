using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discos_adodotnet
{
    public partial class wfListaDiscos : Form
    {
        private List<Disco>listaDiscos;
        public wfListaDiscos()
        {
            InitializeComponent();
        }

        private void wfListaDiscos_Load(object sender, EventArgs e)
        {
            DiscosServices services = new DiscosServices();
            listaDiscos = services.listar();
            dgvListaDiscos.DataSource = listaDiscos;

            dgvListaDiscos.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaDiscos[0].UrlImagen);
            
        }

        private void dgvListaDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvListaDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenDisco.Load(imagen);
            }
            catch (Exception)
            {

                pbImagenDisco.Load("https://i0.wp.com/sunrisedaycamp.org/wp-content/uploads/2020/10/placeholder.png?ssl=1");
            }
        }


    }
}
