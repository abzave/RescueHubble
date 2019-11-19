using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectorDeNiveles : MonoBehaviour 
{
	private string NombreDeLaEscena;

	public void OnClicked(Button boton)
	{
		NombreDeLaEscena = boton.gameObject.name;
		SceneManager.LoadScene (NombreDeLaEscena);
	}
	public void portada()
	{
		SceneManager.LoadScene ("Portada");
	}
}
