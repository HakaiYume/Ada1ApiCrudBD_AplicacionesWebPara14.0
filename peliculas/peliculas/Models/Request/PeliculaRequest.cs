using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace peliculas.Models.Request
{
    public class PeliculaRequest
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public int Puntuacion { get; set; }
        public int Rating { get; set; }
        public DateTime Publicacion { get; set; }
    }
}
