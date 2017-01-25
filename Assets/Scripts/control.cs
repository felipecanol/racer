using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class control : MonoBehaviour {
	float delay;
	movimiento mover;
    bool active = true;
	public GameObject semaforo;
	void Start () {
		mover=GetComponent<movimiento>();
		mover.enabled=false;
	}

	void Update () {
		if(Input.GetKeyUp(KeyCode.R)){
			SceneManager.LoadScene (1);
			Instantiate (semaforo);
			Time.timeScale = 1f;
		}
		
		if(delay<=Time.time-3f && active){
			delay=Time.time;
			mover.enabled=true;
            active = false;
		}

	}
}
