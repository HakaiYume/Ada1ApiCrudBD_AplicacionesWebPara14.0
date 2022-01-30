using System;
using System.Collections.Generic;

#nullable disable

namespace peliculas.Models
{
    public partial class Pelicula
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public int? Puntuacion { get; set; }
        public int? Rating { get; set; }
        public DateTime? Publicacion { get; set; }
    }
}
