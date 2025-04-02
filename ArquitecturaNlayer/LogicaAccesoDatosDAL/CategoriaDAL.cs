using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencia
using EntidadNegocioEN;

namespace LogicaAccesoDatosDAL
{
    public class CategoriaDAL
    {
        private static List<Categoria> categorias = new List<Categoria>();
        //Metodo para Guardar o Crear una categoria.
        public void GuardarCategoria(Categoria pcategoria)
        {
            //Auto incremento del Id
            pcategoria.Id = categorias.Select(categorias => categorias.Id).DefaultIfEmpty(0).Max() + 1;
            categorias.Add(pcategoria);
        }
        //Metodo para mostrar o obtener
        public List<Categoria> ObtenerCategorias()
        {
            return categorias;
        }
    }
}
