using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class velocimetro : MonoBehaviour {
	public Rigidbody objeto;
	public Text texto;
	float km;
	void Start(){
		objeto = GetComponent<Rigidbody> ();
	}
	void Update(){
		km=objeto.velocity.magnitude*3.6f;
		texto.text = "Km/h : " +Mathf.FloorToInt (km);
	}
}
