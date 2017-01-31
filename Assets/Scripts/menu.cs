using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
	[SerializeField] GameObject spawnmensaje;
	//AudioSource sonido;

	void Start(){
		//sonido = GetComponent<AudioSource> ();
	}
	public void carganivel(){
		SceneManager.LoadScene (1,LoadSceneMode.Single);
		Time.timeScale = 1f;
	}
	public void opciones(){
		spawnmensaje.SetActive (true);
	}
	public void cerrar(){
		spawnmensaje.SetActive (false);
	}
	public void salir(){
		Application.Quit ();

	}
	public void mute(){
		//sonido.mute = true;
		Debug.Log ("silencio");
		
	}
	public void unmute(){
		//sonido.mute = false;
		Debug.Log ("sonido");
	}
}
