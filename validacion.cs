/*
 * Creado por SharpDevelop.
 * Usuario: betty de luna
 * Fecha: 01/05/2014
 * Hora: 11:01 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of validacion.
	/// </summary>
	public class validacion
	{
		private String Nombre;
		private String Codigo;
		
		public validacion( String Nombre, String Codigo)
		{
			this.Nombre = Nombre;
			this.Codigo = Codigo;
		}
		public bool Accesar (){
			return(this.Nombre=="Betty" && this.Codigo=="2087");
		}
			
	}
		
		}

