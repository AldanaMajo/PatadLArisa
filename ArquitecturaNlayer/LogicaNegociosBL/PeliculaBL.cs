using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadNegocioEN;
using LogicaAccesoDatosDAL;

namespace LogicaNegociosBL
{
    public class PeliculaBL
    {
        //Instancia
        private PeliculaDAL peliculaDAL = new PeliculaDAL();
     
        public void GuardarPelicula(Pelicula pPelicula)
        {
            peliculaDAL.GuardarPelicula(pPelicula);
        }
        public List<Pelicula> ObtenerPeliculas()
        {
            return peliculaDAL.ObtenerPeliculas();
        }
    }
}
