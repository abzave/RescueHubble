using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorNiveles : MonoBehaviour {
	public Animator animMenu;
	private bool menuActivado;

	public void menu(){
		if (menuActivado) {
			menuActivado = false;
			animMenu.SetTrigger ("cerrar");
		} else {
			menuActivado = true;
			animMenu.SetTrigger ("abrir");
		}
	}

	public void SelectorDeGalaxias()
	{
		SceneManager.LoadScene ("SelectorDeGalaxias");
	}
}
