using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scores : MonoBehaviour {
	[SerializeField] int score;
	[SerializeField] int hiscore;
	[SerializeField] Text texto;
	// Use this for initialization
	void Start () {
		texto = GetComponent<Text> ();
		score = 0;
		hiscore = PlayerPrefs.GetInt ("maaximo puntaje",hiscore);
//		texto.text = hiscore.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		if(score>hiscore){
			hiscore = score;
			texto.text = "" + score;
			PlayerPrefs.SetInt ("maximopuntaje",hiscore);
		}
	}
//	void agregapt(int ptagregar){
	//	score += ptagregar;
	//}
	//void Reset(){
	//	score = 0;
	//}
}
