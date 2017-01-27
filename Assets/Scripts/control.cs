using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class control : MonoBehaviour {
	float delaya;
	movimiento mover;
    bool active = true;
	public GameObject semaforo;
	void Start () {
		mover=GetComponent<movimiento>();
		mover.enabled=false;

	}

	void Update () {
		if(Input.GetKeyUp(KeyCode.R)){
			SceneManager.LoadScene (1,LoadSceneMode.Single);
			//Instantiate (semaforo);
			Debug.Log(delaya);
		}
		
		if(delaya<=Time.time-3f && active){
			delaya=Time.time;
			mover.enabled=true;
            active = false;
		}

	}
}
