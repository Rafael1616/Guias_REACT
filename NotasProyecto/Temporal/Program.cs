using reactBackend.Models;
using reactBackend.Repository;

AlumnoDao alumnoDao = new AlumnoDao();

#region SelectAll
var alumno = alumnoDao.SelectAll();

foreach(var item in alumno)
{
    Console.WriteLine(item.Nombre);
}
#endregion
Console.WriteLine(" ");

#region SelectByID
var selectById = alumnoDao.GetById(1000);
Console.WriteLine(selectById?.Nombre);
#endregion
Console.WriteLine(" ");

#region addAlumno

var nuevoAlumno = new Alumno
{
    Direccion = "Chalatenango, Barrio el Centro",
    Dni = "1345",
    Edad = 30,
    Email = "12344321@email",
    Nombre = "Ricardo JR Milos"
};

var resultado = alumnoDao.insertarAlumno(nuevoAlumno);
Console.WriteLine(resultado);

#endregion

#region updateAlumno
var nuevoAlumno2 = new Alumno
{
    Direccion = "Chalatenango, Barrio el Centro",
    Dni = "1345",
    Edad = 30,
    Email = "5@email",
    Nombre = "Wiliams"
};

var resultado2 = alumnoDao.update(2, nuevoAlumno2);
Console.WriteLine(resultado2);
#endregion

#region borrar
var result = alumnoDao.deleteAlumno(2);
Console.WriteLine("Se elimino " + result);
#endregion