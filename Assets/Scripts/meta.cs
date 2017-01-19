using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meta : MonoBehaviour {

    public movimiento m;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        m.enabled = false;
    }
}
