using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo : MonoBehaviour {

	public GameObject luz1;
	public GameObject luz2;
	public GameObject luz3;
    float delay;
	bool activo;

		
			
		
	void Start(){
		activo = true;

	}


	
	// Update is called once per frame
	void Update () {
		
		Renderer r;
		if(activo==true){
			this.gameObject.SetActive (true);
			activo = false;
		}

		if (delay <= Time.time - 1f){
            r= luz1.GetComponent<Renderer> ();
            r.sharedMaterial = Resources.Load("Materials/LuzRoja") as Material;
        }

        if (delay <= Time.time - 2f)
		{
			
            r = luz2.GetComponent<Renderer>();
            r.sharedMaterial = Resources.Load("Materials/LuzRoja") as Material;
        }

        if (delay <= Time.time - 3f)
		{
			
            r = luz3.GetComponent<Renderer>();
            r.sharedMaterial = Resources.Load("Materials/LuzVerde") as Material;
        }

		 if (delay <= Time.time - 5f)
        {
			delay = Time.time;
			this.gameObject.SetActive (false);
			activo = true;

        }
		Debug.Log (delay);

	}
}
