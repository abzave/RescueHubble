using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerHubble : MonoBehaviour {
	public Animator animMenu;
	public Button menuObject;
	public Animator animMenuPiezas;
	public Button menuPiezas;
	public Text textoAyuda;
	private bool menuActivado;
	private bool menuPiezasActivado;

	public void menu(){
		if (menuActivado) {
			menuActivado = false;
			animMenu.SetTrigger ("cerrar");
			menuPiezas.interactable = true;
		} else {
			menuActivado = true;
			animMenu.SetTrigger ("abrir");
			menuPiezas.interactable = false;
		}
	}

	public void cambiarTextoAyuda(){
		if (textoAyuda.enabled) {
			textoAyuda.enabled = false;
		} else {
			textoAyuda.enabled = true;
		}
	}

	public void cambiarMenuPiezas(){
		if (menuPiezasActivado) {
			menuPiezasActivado = false;
			animMenuPiezas.SetTrigger ("cerrar");
			menuObject.interactable = true;
		} else {
			menuPiezasActivado = true;
			animMenuPiezas.SetTrigger ("abrir");
			menuObject.interactable = false;
		}
	}

}
