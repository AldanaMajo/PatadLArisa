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
    public partial class CategoriaWF : Form
    {

        public CategoriaWF()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var categoriaNueva = new Categoria
            {
                Nombre = txtNombre.Text
            };
            if (categoriaNueva != null)
            {
                CategoriaBL categoriaBL = new CategoriaBL();
                categoriaBL.GuardarCategoria(categoriaNueva);
                dgvCategoria.DataSource = null;
                dgvCategoria.DataSource = categoriaBL.ObtenerCategorias();
            }
        }

        private void CategoriaWF_Load(object sender, EventArgs e)
        {
            CategoriaBL categoriaBL = new CategoriaBL();
            dgvCategoria.DataSource = categoriaBL.ObtenerCategorias();
            txtId.Visible = false;
        }

      
    }
}
