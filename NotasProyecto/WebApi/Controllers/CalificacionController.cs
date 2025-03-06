﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reactBackend.Models;
using reactBackend.Repository;

namespace WebApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CalificacionController : ControllerBase
    {
        private CalificacionDao _cdao = new CalificacionDao();

        #region Lista de calificaciones
        [HttpGet("calificaciones")]

        public List<Calificacion> get(int idMatricula)
        {
            return _cdao.seleccion(idMatricula);
        }
        #endregion

        #region ingesarDatos
        [HttpPost("calificacion")]

        public bool insertar([FromBody] Calificacion calificacion)
        {
            return _cdao.insertar(calificacion);
        }
        #endregion

    }

}
