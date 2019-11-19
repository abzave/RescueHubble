using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlGiroscopio : MonoBehaviour {
	private Gyroscope gyro;
	private Quaternion rot;
	public Text x;
	public Text y;
	public Text z;


	private void Start(){
		gyro = Input.gyro;
		gyro.enabled = true;
		gameObject.transform.rotation = Quaternion.Euler (90f,90f,90f);
		rot = new Quaternion (0,0,1,0);
	}

	private void Update () {
		transform.localRotation = gyro.attitude * rot;
		x.text = "x: "+Mathf.RoundToInt(gameObject.transform.rotation.x*100).ToString();
		y.text = "y: "+Mathf.RoundToInt(gameObject.transform.rotation.y*100).ToString();
		z.text = "z: "+Mathf.RoundToInt(gameObject.transform.rotation.z*100).ToString();
	}
}
