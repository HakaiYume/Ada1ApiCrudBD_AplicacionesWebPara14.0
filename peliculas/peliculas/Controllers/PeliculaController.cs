using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using peliculas.Models.Response;
using peliculas.Models.Request;
using peliculas.Models;

namespace peliculas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta oRespuesta = new Respuesta();
            try
            {
                using (api_peliculaContext db = new api_peliculaContext())
                {
                    var lst = db.Peliculas.ToList();
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;
                }
            }
            catch(Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            Respuesta oRespuesta = new Respuesta();
            try
            {
                using (api_peliculaContext db = new api_peliculaContext())
                {
                    Pelicula oPelicula = db.Peliculas.Find(Id);
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = oPelicula;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpPost]
        public IActionResult Add(PeliculaRequest model)
        {
            Respuesta oRespuesta = new Respuesta();
            try
            {
                using (api_peliculaContext db = new api_peliculaContext())
                {
                    Pelicula oPelicula = new Pelicula();
                    oPelicula.IdPelicula = model.Id;
                    oPelicula.Titulo = model.Titulo;
                    oPelicula.Director = model.Director;
                    oPelicula.Genero = model.Genero;
                    oPelicula.Puntuacion = model.Puntuacion;
                    oPelicula.Rating = model.Rating;
                    oPelicula.Publicacion = model.Publicacion;
                    db.Peliculas.Add(oPelicula);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
            }
        }
            catch(Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
            /*

Puede utilizar este json para probar el metodo post
{
    "titulo": "Shrek",
    "director": "Vicky Jenson, Andrew Adamson",
    "genero": "Comedia",
    "puntuacion": 87,
    "rating": 928000,
    "publicacion": "2001-06-29T00:00:00"
}
            */
        }

        [HttpPut]
        public IActionResult Editar(PeliculaRequest model)
        {
            Respuesta oRespuesta = new Respuesta();
            try
            {
                using (api_peliculaContext db = new api_peliculaContext())
                {
                    Pelicula oPelicula = db.Peliculas.Find(model.Id);
                    oPelicula.Titulo = model.Titulo;
                    oPelicula.Director = model.Director;
                    oPelicula.Genero = model.Genero;
                    oPelicula.Puntuacion = model.Puntuacion;
                    oPelicula.Rating = model.Rating;
                    oPelicula.Publicacion = model.Publicacion;
                    db.Entry(oPelicula).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
            /*

Puede utilizar este json para probar el metodo put
{
    "titulo": "Shrek",
    "director": "Vicky Jenson, Andrew Adamson",
    "genero": "Comedia",
    "puntuacion": 87,
    "rating": 982000,
    "publicacion": "2001-06-29T00:00:00",
    "Id" : 5
}
            */
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarById(int Id)
        {
            Respuesta oRespuesta = new Respuesta();
            try
            {
                using (api_peliculaContext db = new api_peliculaContext())
                {
                    Pelicula oPelicula = db.Peliculas.Find(Id);
                    db.Remove(oPelicula);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch(Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpDelete]
        public IActionResult Eliminar()
        {
            Respuesta oRespuesta = new Respuesta();
            try
            {
                using (api_peliculaContext db = new api_peliculaContext())
                {
                    var lst = db.Peliculas.ToList();
                    db.RemoveRange(lst);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }
    }
}
