using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadNegocioEN;

namespace LogicaAccesoDatosDAL
{
        public class PeliculaDAL
        {
            private static List<Pelicula> peliculas = new List<Pelicula>();
            public void GuardarPelicula(Pelicula ppelicula)
            {
                //incremento del Id
                ppelicula.Id = peliculas.Select(peliculas => peliculas.Id).DefaultIfEmpty(0).Max() + 1;
                peliculas.Add(ppelicula);
            }
            //met mostrar o obtener
            public List<Pelicula> ObtenerPeliculas()
            {
                return peliculas;
            }
        }
}
