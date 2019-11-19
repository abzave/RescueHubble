using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class EstadoDelJuego : MonoBehaviour 
{
	public static EstadoDelJuego estadoDelJuego;
	private string rutaArchivo ;


	//Variables A Guardar
	public int PuntuacionMaxima = 0;
	public string Idioma;
	public bool Sonido = true;
	public bool EFX = true;

	void Awake ()
	{
		rutaArchivo = Application.persistentDataPath + "/Datos.dat";
		if (estadoDelJuego == null) 
		{
			EstadoDelJuego.estadoDelJuego = this;
			DontDestroyOnLoad (gameObject); 
		}
		else if (estadoDelJuego != this)
		{
			Destroy (gameObject);
		}
	}
	void Start () 
	{
		Cargar ();	
	}
	public void Guardar()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (rutaArchivo);
		DatosAGuardar datos = new DatosAGuardar ();
		//Aqui pongo todo lo que quiero guardar
		
		datos.PuntuacionMaxima = PuntuacionMaxima;
		datos.Idioma = Idioma;
		datos.Sonido = Sonido;
		datos.EFX = EFX;
		bf.Serialize (file,datos);
		file.Close ();
	}
	public void Cargar()
	{
		if (File.Exists (rutaArchivo))
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (rutaArchivo, FileMode.Open);
			DatosAGuardar datos = (DatosAGuardar)bf.Deserialize (file);
			//Aqui saco todo lo que guarde
			PuntuacionMaxima = datos.PuntuacionMaxima;
			Idioma = datos.Idioma;
			Sonido = datos.Sonido;
			EFX = datos.EFX;
			file.Close ();
		}
		else
		{
			// Valores Por Defecto
			PuntuacionMaxima = 0;
			Idioma = "Ingles";
			Sonido = true;
		}
	}
	void OnDestroy()
	{
		if (EstadoDelJuego.estadoDelJuego == this) 
		{
			EstadoDelJuego.estadoDelJuego = null;
		}
	}

	[Serializable]
	class DatosAGuardar
	{
		//Aqui meto todo lo que quiero guardar
		public int PuntuacionMaxima;
		public string Idioma;
		public bool Sonido;
		public bool EFX;
	}
}
