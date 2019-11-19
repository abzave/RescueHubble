using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDelJuego : MonoBehaviour {
	public GameObject MenuGameOver;
	public GameObject MenuPausa;
	public GameObject PausaGO;
	public GameObject canvas;
	public Animator animMenu;
	private bool menuActivado;

	void Awake()
	{
		canvas.SetActive (true);
		ComprobarSonido ();
	}
	public void GameOver()
	{
		MenuGameOver.SetActive (true);
		Time.timeScale = 0f;
	}
	public void Reiniciar()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void menu(){
		if (menuActivado) {
			menuActivado = false;
			animMenu.SetTrigger ("cerrar");
		} else {
			menuActivado = true;
			animMenu.SetTrigger ("abrir");
		}
	}

	public void Continuar()
	{
		MenuPausa.SetActive (false);
		PausaGO.SetActive (true);
		Time.timeScale = 1f;
	}
	public void Portada()
	{
		SceneManager.LoadScene ("Portada");
	}
	public void SelectorDeNiveles()
	{
		SceneManager.LoadScene ("SelectorDeNiveles");
	}


	public void ComprobarSonido()
	{
		if (EstadoDelJuego.estadoDelJuego == true) 
		{
			AudioListener.volume = 1f;
		}
		else 
		{
			AudioListener.volume = 0f;
		}
	}
	public void CambiarSonido()
	{
		if (EstadoDelJuego.estadoDelJuego == true) 
		{
			AudioListener.volume = 0f;
		}
		else 
		{
			AudioListener.volume = 1f;
		}
	}
}
