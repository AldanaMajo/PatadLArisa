using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias 
using EntidadNegocioEN;
using LogicaAccesoDatosDAL;

namespace LogicaNegociosBL
{
    public class CategoriaBL
    {
        //Instancia
        private CategoriaDAL categoriaDAL = new CategoriaDAL();
        //categoriaDAL --> Representa el objeto de la instancia.
        public void GuardarCategoria(Categoria pcategoria)
        {
            categoriaDAL.GuardarCategoria(pcategoria);
        }
        public List<Categoria> ObtenerCategorias()
        { 
            return categoriaDAL.ObtenerCategorias();
        }
    }
}
