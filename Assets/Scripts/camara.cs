using UnityEngine;
using System.Collections;

public class camara : MonoBehaviour {
	[SerializeField] private Transform objetivo;
	//float smooth=9f;
	Vector3 offset;
	[SerializeField] float damping=15f;
	//Vector3 offsetb;
	void Start () {
		//offsetb=transform.position-objetivo.position;
		offset=objetivo.transform.position-transform.position;
	}
	void Update () {
		float anguloactual=transform.eulerAngles.y;
		float angulodeseado=objetivo.transform.eulerAngles.y;
		float angulo=Mathf.LerpAngle(anguloactual,angulodeseado,Time.deltaTime*damping);
		Quaternion rotation=Quaternion.Euler(0,angulo,0);
		transform.position=objetivo.transform.position-(rotation*offset);
		//Vector3 positioncamobj=objetivo.position+offsetb;
		//transform.position=Vector3.Lerp(transform.position,positioncamobj,smooth*Time.deltaTime);
		transform.LookAt(objetivo.transform);
	}
}
