using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class salir : MonoBehaviour {
	bool activo=false;
	[SerializeField] GameObject spawnmensajesalida;
	public void Update(){
		if(Input.GetKeyUp(KeyCode.Escape)||Input.GetKeyUp(KeyCode.Return)&&activo==false){
			spawnmensajesalida.SetActive (true);
			Time.timeScale = 0.0f;
			activo = true;
		}
		else if(Input.GetKeyUp(KeyCode.Return)||Input.GetKeyUp(KeyCode.Escape)&&activo==true){
			spawnmensajesalida.SetActive (false);
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
		SceneManager.LoadScene (0);

	}
}
