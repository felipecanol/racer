using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meta : MonoBehaviour {

    public movimiento m;
	[SerializeField] GameObject mensaje;

	// Use this for initialization
	

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="jugador"){
         m.enabled = false;
         m.backl.brakeTorque = 10000;
         m.backr.brakeTorque = 10000;
         m.frontl.brakeTorque = 10000;
         m.frontr.brakeTorque = 10000;
         m.backl.motorTorque = 0;
         m.backr.motorTorque = 0;
         m.frontl.motorTorque = 0;
         m.frontr.motorTorque = 0;
			mensaje.SetActive (true);
        }

       
    }
   
}
