using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Traductor : MonoBehaviour 
{
	public string Ingles;
	public string Espanol;
	public Text TextoACambiar;
	public Traductor[] Traductores;
	void Start()
	{
		ComprobarIdioma ();
	}
	 void ComprobarIdioma()
	{
		if (EstadoDelJuego.estadoDelJuego.Idioma == "Espanol") 
		{
			TextoACambiar.text = Espanol;
		}
		else 
		{
			TextoACambiar.text = Ingles;
		}
	}
	public void IdiomaEspanol()
	{
		EstadoDelJuego.estadoDelJuego.Idioma = "Espanol";
		CambiarIdioma ();
	}
	public void IdiomaIngles()
	{
		EstadoDelJuego.estadoDelJuego.Idioma = "Ingles";
		CambiarIdioma ();
	}
	void CambiarIdioma()
	{
		Traductores = FindObjectsOfType (typeof(Traductor)) as Traductor[];
		for (int i = 0; i < Traductores.Length; i++) 
		{
			Traductores [i].ComprobarIdioma ();
		}
		EstadoDelJuego.estadoDelJuego.Guardar ();
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
