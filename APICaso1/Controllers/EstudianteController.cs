using APICaso1.Entities;
using APICaso1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CasoEstudioAPI.Controllers
{
    public class RegistrarController : ApiController
    {
        [HttpPost]
        [Route("Enroll")]
        public void Registro(EstudianteEntidad entidad)
        {
            using (var context = new CasoEstudioMNEntities())
            {
                var estudiante = new Estudiantes();
                estudiante.Nombre = entidad.Nombre;
                estudiante.Fecha = entidad.Fecha;
                estudiante.Monto = entidad.Monto;

                context.Estudiantes.Add(estudiante);
                context.SaveChanges();
            }
        }

        [HttpGet]
        [Route("EnrollEstudiantes")]
        public IHttpActionResult EnrollEstudiantes()
        {
            using (var context = new CasoEstudioMNEntities())
            {
                var result = (from e in context.Estudiantes
                              join t in context.TiposCursos on e.TipoCurso equals t.TipoCurso
                              select new
                              {
                                  Fecha = e.Fecha,
                                  Monto = e.Monto,
                                  DescripcionTipoCurso = t.DescripcionTipoCurso,
                                  Nombre = e.Nombre
                              }).ToList();

                return Ok(result);
            }
        }
    }
}