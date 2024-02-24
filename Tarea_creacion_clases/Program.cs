using System;

namespace Tarea_creacion_clases
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bienvenido a el colegio La Venturas");
			Console.WriteLine("Escriba '1' si desea ingresar datos de alumno y '2' si desea ingresar datos de profesor");
			string opcion = Console.ReadLine();
			if (int.TryParse(opcion, out int eleccion))
			{
				if (eleccion == 1)
				{
					var alumno = new Alumno("Valery", "Palma", new DateTime(2000, 5, 4), "55654432", "AV. Aviacion", "DJS323", DateTime.Now);
					Console.WriteLine("Datos de alumno: " + alumno.Nombre + ", " + alumno.Apellido + ", " + alumno.Direccion + ", " + alumno.FNacimiento + ", " + alumno.Telefono + ", " + alumno.FIngreso + ", " + alumno.Carnet);
				}
				if (eleccion == 2)
				{
					var profesor = new Profesor("Armando", "Paredes", new DateTime(1992, 7, 20), "56689001", "Av. Petunia", "Algebra I", "Facultad ingeniería");

					Console.WriteLine("Datos de Profesor: " + profesor.Nombre + ", " + profesor.Apellido + "," + profesor.Direccion + ", " + profesor.FNacimiento + ", " + profesor.Telefono + ", " + profesor.Departamento + ", " + profesor.Curso);
				}
			}
           
        }
	}
}
