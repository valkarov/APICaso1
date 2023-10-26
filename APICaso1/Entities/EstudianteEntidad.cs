using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICaso1.Entities
{
    public class EstudianteEntidad
    {
        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public Decimal Monto { get; set; }

        public int TipoCurso { get; set; }

        public class TipoCursoEntidad
        {
            public string DescripcionTipoCurso { get; set; }
        }
    }
}