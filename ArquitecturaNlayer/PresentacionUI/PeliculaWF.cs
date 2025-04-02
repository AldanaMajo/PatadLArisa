using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegociosBL;
using EntidadNegocioEN;

namespace PresentacionUI
{
    public partial class PeliculaWF : Form
    {
        public PeliculaWF()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var peliculaNueva = new Pelicula
            {
                Titulo = txtNombre.Text
            };
            if (peliculaNueva != null)
            {
                PeliculaBL peliculaBL = new PeliculaBL();
                peliculaBL.GuardarPelicula(peliculaNueva);
                dgvPelicula.DataSource = null;
                dgvPelicula.DataSource = peliculaBL.ObtenerPeliculas();
            }
        }

        private void PeliculaWF_Load(object sender, EventArgs e)
        {
            PeliculaBL peliculaBL = new PeliculaBL();
            dgvPelicula.DataSource = peliculaBL.ObtenerPeliculas();
            txtId.Visible = false;
        }

  
    }
}
