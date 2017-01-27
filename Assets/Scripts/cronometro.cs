using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cronometro : MonoBehaviour {
	public Text crono;
	float tiempo;
	public float point;
	public movimiento mover;
	public GameObject mensaje;
	bool contador=false;
	void Start(){
		mover = GetComponent<movimiento> ();
	}
	void Update(){
		if(contador==false){
		if(tiempo<=Time.time-4f){
			//retraso = Time.time;
			tiempo = Time.deltaTime;
			point-=tiempo;
			crono.text = "tiempo: " +point.ToString();
		}
		}
		if(point<=0f){
			mensaje.SetActive (true);
			mover.enabled = false;
			tiempo = 0f;
			crono.text = "" +tiempo.ToString();
			mover.backl.brakeTorque = 10000;
			mover.backr.brakeTorque = 10000;
			mover.frontl.brakeTorque = 10000;
			mover.frontr.brakeTorque = 10000;
			mover.backl.motorTorque = 0;
			mover.backr.motorTorque = 0;
			mover.frontl.motorTorque = 0;
			mover.frontr.motorTorque = 0;
		}

	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag=="meta"){
			contador = true;

		}
	}

}
