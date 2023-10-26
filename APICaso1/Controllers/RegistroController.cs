using APICaso1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICaso1.Controllers
{
    public class RegistroController : ApiController
    {
        [HttpPost]
        [Route("Enroll")]
        public IHttpActionResult RegistroMatricula(EstudianteEntidad entidad)
        {
            try
            {

                RegistroMatricula(entidad);

                return Ok("Matrícula registrada con éxito.");
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }
    }
}