using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
    public float velocidad;
	float misidefriction;
	float miforwarfriction;
	float mislipsidefriction;
	float mislipforwarfriction;
	public float giro;
	public Rigidbody rigid;
	public WheelCollider frontl;
	public WheelCollider frontr;
	public WheelCollider backl;
	public WheelCollider backr;
	bool downhill;
	[SerializeField] float centro_masa;
	[SerializeField] float maxtorque;
	void Start () {
		rigid.GetComponent<Rigidbody>();
		rigid.centerOfMass=new Vector3(0.0f,centro_masa,0.0f);

		valores();
	}
	void valores(){
		miforwarfriction=frontl.forwardFriction.stiffness;
		misidefriction=frontl.sidewaysFriction.stiffness;
		mislipforwarfriction=0.8f;
		mislipsidefriction=0.5f;
	}
	void setslip(float forwardfriccion,float sidefriccion){
		forwardfriccion=frontl.forwardFriction.stiffness;
		forwardfriccion=frontr.forwardFriction.stiffness;
		forwardfriccion=backl.forwardFriction.stiffness;
		forwardfriccion=backr.forwardFriction.stiffness;

		sidefriccion=frontl.sidewaysFriction.stiffness;
		sidefriccion=frontr.sidewaysFriction.stiffness;
		sidefriccion=backl.sidewaysFriction.stiffness;
		sidefriccion=backr.sidewaysFriction.stiffness;
	}

	void Update () {
		
		frontl.steerAngle = 0;
		frontr.steerAngle = 0;

		if (Input.GetKey (KeyCode.RightArrow)) {
			setslip (mislipforwarfriction, mislipsidefriction);
			frontr.steerAngle = giro;
			frontl.steerAngle = giro;
			transform.Rotate (0, giro * Time.deltaTime, 0);

		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			setslip (mislipforwarfriction, mislipsidefriction);
			frontl.steerAngle = -giro;
			frontr.steerAngle = -giro;
			transform.Rotate (0, -giro * Time.deltaTime, 0);

	
		}

		/*
		if(downhill==true){transform.Translate(0,-0.3f*Time.deltaTime,0);}
	}
	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.tag=="hill"){
			downhill=true;
			}
		if(other.gameObject.tag=="hillout"){
			downhill=false;

		}
	}
	*/
		float torque = maxtorque * Input.GetAxis ("Vertical");
		backl.motorTorque = torque;
		backr.motorTorque = torque;
		backl.brakeTorque = 0f;
		backr.brakeTorque = 0f;
		frontl.motorTorque = torque;
		frontr.motorTorque = torque;
		frontl.brakeTorque = 0f;
		frontr.brakeTorque = 0f;

}


}

