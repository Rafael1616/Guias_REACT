using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reactBackend.Models;
using reactBackend.Repository;

namespace WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {

        private AlumnoDao _dao = new AlumnoDao();

        #region endPointAlumnoProfesor
        [HttpGet("alumnoProfesor")]

        public List<AlumnoProfesor> GetAlumnoProfesors(string usuario)
        {
            return _dao.alumnoProfesors(usuario);
        }
        #endregion

        #region SelectById
        [HttpGet("alumno")]

        public Alumno selectById(int id)
        {
            var alumno = _dao.GetById(id);
            return alumno;
        }
        #endregion

        #region actualizarDatos
        [HttpPut("alumno")]

        public bool actualizarAlumno([FromBody] Alumno alumno)
        {
            return _dao.update(alumno.Id, alumno);
        }
        #endregion

    }
}
