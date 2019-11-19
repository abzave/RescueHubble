using UnityEngine;

public class Asistente : MonoBehaviour {
	public GameObject ayuda;

	public void mostrarAyuda(){
        if(ayuda.activeSelf){
            ayuda.SetActive(false);
        }else{
            ayuda.SetActive(true);
        }
	}

}