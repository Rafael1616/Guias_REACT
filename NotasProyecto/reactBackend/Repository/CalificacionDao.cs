using reactBackend.Context;
using reactBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reactBackend.Repository
{
    public class CalificacionDao
    {
        private RegistroAlumnoContext _contexto = new RegistroAlumnoContext();

        #region Seleccionar_lista_caificaciones 
        public List<Calificacion> seleccion(int matriculaid)
        {

            var matricula = _contexto.Matriculas.Where(x => x.Id == matriculaid);
            Console.WriteLine("matricula encontrada");
            try
            {
                if (matricula != null)
                {

                    var calificacion = _contexto.Calificacions.Where(x => x.Id == matriculaid).ToList();

                    return calificacion;
                }
                else
                {

                    return null;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                return null;
            }


        }
        #endregion

        #region insertarDatos
        public bool insertar(Calificacion calificacion)
        {
            try
            {
                if(calificacion == null)
                {
                    return false;
                }
                var addCalificacion = _contexto.Calificacions.Add(calificacion);
                _contexto.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
