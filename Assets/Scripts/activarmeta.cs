using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarmeta : MonoBehaviour {

	[SerializeField] GameObject metatrigger;

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag=="jugador"){
			metatrigger.SetActive (true);
		}
	}
}
