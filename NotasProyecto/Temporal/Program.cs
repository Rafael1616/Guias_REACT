using reactBackend.Repository;

AlumnoDao alumnoDao = new AlumnoDao();

var alumno = alumnoDao.SelectAll();

foreach(var item in alumno)
{
    Console.WriteLine(item.Nombre);
}

Console.WriteLine(" ");

#region SelectByID
var selectById = alumnoDao.GetById(1000);
Console.WriteLine(selectById?.Nombre);
#endregion