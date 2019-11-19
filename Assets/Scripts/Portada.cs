using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Portada : MonoBehaviour 
{
	public GameObject EmpezarBoton;
	public GameObject InfoBoton;
	public GameObject AjustesBoton;
	public GameObject SalirBoton;
	public GameObject Titulo;
	public GameObject PanelInformacion;
	public GameObject PanelAjustes;
	public GameObject PanelSeguroSalir;
	public GameObject cerrar;

	void Awake()
	{
		EstadoDelJuego.estadoDelJuego.Cargar ();
	}
	
	public void SelectorDeNiveles()
	{
		SceneManager.LoadScene ("SelectorDeGalaxias");
	}
	public void Salir()
	{
		Application.Quit ();
	}
	public void ApagarBotones()
	{
		EmpezarBoton.SetActive (false);
		InfoBoton.SetActive (false);
		AjustesBoton.SetActive (false);
		SalirBoton.SetActive (false);
		Titulo.SetActive (false);
	}
	public void EncenderBotones()
	{
		EmpezarBoton.SetActive (true);
		InfoBoton.SetActive (true);
		AjustesBoton.SetActive (true);
		SalirBoton.SetActive (true);
		Titulo.SetActive (true);
	}
	public void Info()
	{
		ApagarBotones ();
		PanelInformacion.SetActive (true);
	}
	public void SalirInfo()
	{
		EncenderBotones ();
		PanelInformacion.SetActive (false);
	}
	public void Ajustes() 
	{
		ApagarBotones ();
		PanelAjustes.SetActive (true);
	}
	public void SalirAjustes()
	{
		EncenderBotones ();
		PanelAjustes.SetActive (false);
	}
	public void SeguroSalir()
	{
		ApagarBotones ();
		PanelSeguroSalir.SetActive (true);
	}
	public void SalirSeguroSalir()
	{
		EncenderBotones ();
		PanelSeguroSalir.SetActive (false);
	}

	public void CambiarSonido()
	{
		if (EstadoDelJuego.estadoDelJuego.Sonido == true) 
		{
			EstadoDelJuego.estadoDelJuego.Sonido = false;
			EstadoDelJuego.estadoDelJuego.Guardar ();
		}
		else 
		{
			EstadoDelJuego.estadoDelJuego.Sonido = true;
			EstadoDelJuego.estadoDelJuego.Guardar ();
		}
	}

	public void CambiarEFX()
	{
		if (EstadoDelJuego.estadoDelJuego.EFX == true) 
		{
			EstadoDelJuego.estadoDelJuego.EFX = false;
			EstadoDelJuego.estadoDelJuego.Guardar ();
		}
		else 
		{
			EstadoDelJuego.estadoDelJuego.EFX = true;
			EstadoDelJuego.estadoDelJuego.Guardar ();
		}
	}
}
