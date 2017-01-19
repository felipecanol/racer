using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	float delay;
	movimiento mover;
    bool active = true;
	void Start () {
		mover=GetComponent<movimiento>();
		mover.enabled=false;
	}

	void Update () {
		
		if(delay<=Time.time-3f && active){
			delay=Time.time;
			mover.enabled=true;
            active = false;
		}

	}
}
