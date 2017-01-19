using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

	public float giro;
	public Rigidbody rigid;
	public WheelCollider frontl;
	public WheelCollider frontr;
	public WheelCollider backl;
	public WheelCollider backr;
	public GameObject fl;
	public GameObject fr;
	public GameObject bl;
	public GameObject br;
    public float brakeTorque;


	[SerializeField] float centro_masa;
	[SerializeField] float maxtorque;

	void Start () {
		rigid.centerOfMass = new Vector3 (0.0f, centro_masa, 0.0f);
	}

	void Update () {
		
		frontl.steerAngle = 0;
		frontr.steerAngle = 0;

		if (Input.GetKey (KeyCode.RightArrow)) {
			frontr.steerAngle = giro;
			frontl.steerAngle = giro;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			frontl.steerAngle = -giro;
			frontr.steerAngle = -giro;
		}


		float torque = maxtorque * Input.GetAxis ("Vertical");

        brakeTorque = brakeTorque < 1000 ? Mathf.Abs(Input.GetAxis("Jump")) : 1000;

		if (brakeTorque > 0.001) {
			brakeTorque = maxtorque;
			torque = 0;
		} else {
			brakeTorque = 0;
		}

		backl.motorTorque = torque;
		backr.motorTorque = torque;
		backl.brakeTorque = brakeTorque;
		backr.brakeTorque = brakeTorque;
		frontl.motorTorque = torque;
		frontr.motorTorque = torque;
		frontl.brakeTorque = brakeTorque;
		frontr.brakeTorque = brakeTorque;

		Quaternion rot;
		Vector3 pos;

		// Llanta Tracera Izquierda
		backl.GetWorldPose ( out pos, out rot);
		bl.transform.position = pos;
		bl.transform.rotation = rot;

		// Llanta Tracera Derecha
		backr.GetWorldPose ( out pos, out rot);
		br.transform.position = pos;
		br.transform.rotation = rot;

		// Llanta Delantera Izquierda
		frontl.GetWorldPose ( out pos, out rot);
		fl.transform.position = pos;
		fl.transform.rotation = rot;

		// Llanta Delantera Izquierda
		frontr.GetWorldPose ( out pos, out rot);
		fr.transform.position = pos;
		fr.transform.rotation = rot;

	}


}

