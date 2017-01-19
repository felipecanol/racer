using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	float delay;
	movimiento mover;
	void Start () {
		mover=GetComponent<movimiento>();
		mover.enabled=false;
	}

	void Update () {
		
		if(delay<=Time.time-3f){
			delay=Time.time;
			mover.enabled=true;
		}

	}
}
