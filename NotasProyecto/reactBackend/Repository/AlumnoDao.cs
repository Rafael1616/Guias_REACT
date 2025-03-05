using reactBackend.Context;
using reactBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reactBackend.Repository
{
    public class AlumnoDao
    {
        #region Context

        public RegistroAlumnoContext contexto = new RegistroAlumnoContext();

        #endregion

        #region Select All

        public List<Alumno> SelectAll()
            => contexto.Alumnos.ToList<Alumno>();

        #endregion

        #region Seleccionamos por ID

        public Alumno? GetById(int id)
        {
            var alumno = contexto.Alumnos.Where(x => x.Id == id).FirstOrDefault();
            return alumno == null ? null : alumno;
        }
        #endregion
    }
}
