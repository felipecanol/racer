using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class salir : MonoBehaviour {
	bool activo=true;
	bool presion=false;
	[SerializeField] GameObject spawnmensajesalida;

	public void Update(){
		if(Input.GetKeyUp(KeyCode.Return)&&activo==false&&presion==true){
			spawnmensajesalida.SetActive (true);
			Time.timeScale = 0.0f;
			presion = false;
				activo = true;
		}
		else if(Input.GetKeyUp(KeyCode.Return)&&activo==true&&presion==false){
			spawnmensajesalida.SetActive (false);
			presion = true;
			Time.timeScale = 1f;
			activo=false;
		}
	
	}
	public void pregunta(){
		spawnmensajesalida.SetActive (true);
		Time.timeScale = 0.0f;
	}
	public void cerrar(){
		spawnmensajesalida.SetActive (false);
		Time.timeScale = 1f;
	}
	public void aceptar(){
		SceneManager.LoadScene (0,LoadSceneMode.Single);


	}
}
